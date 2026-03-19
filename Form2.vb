
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http.Headers 'custm

Public Class Form2
    Private OpenAKey As String = "YOUR_OPENAI_API_KEY_HERE"
    Private OpenAEndpoint As String = "https://api.openai.com/v1/chat/completions"

    Private Async Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim userMessage As String = TextBox2.Text.Trim()
        If String.IsNullOrEmpty(userMessage) Then Exit Sub
        RichTextBox1.SelectionColor = Color.Blue
        RichTextBox1.AppendText("You: " & userMessage & vbCrLf)
        BtnSend.Enabled = False
        BtnSend.Text = "Processing..."

        Try
            Dim aiReply As String = Await GetAResponse(userMessage)
            RichTextBox1.SelectionColor = Color.Green
            RichTextBox1.AppendText("AI Converter: " & aiReply & vbCrLf)
        Finally
            BtnSend.Enabled = True
            BtnSend.Text = "Send"
        End Try
        TextBox2.Text = " "
    End Sub
    Private Async Function GetAResponse(prompt As String) As Task(Of String)
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", OpenAKey)

            Dim jsonPayload As String = JsonConvert.SerializeObject(New With {
                .model = "gpt-4-turbo",
                .messages = New Object() {
                    New With {.role = "system", .content = "You are a helpful assistant."},
                    New With {.role = "user", .content = prompt}
                },
                .max_tokens = 500
            })

            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync(OpenAEndpoint, content)

            If response.IsSuccessStatusCode Then
                Dim body = Await response.Content.ReadAsStringAsync()
                Dim json = JsonConvert.DeserializeObject(Of Newtonsoft.Json.Linq.JObject)(body)
                Return json("choices")(0)("message")("content").ToString()
            Else
                Return "Error "
            End If
        End Using
    End Function

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not BtnSend.Enabled = False Then
            BtnSend.PerformClick()
            'Ding
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.ReadOnly = True
    End Sub
End Class