Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class Form1

    Private OpenAIKey As String = "YOUR_OPENAI_API_KEY_HERE"
    Private OpenAIEndpoint As String = "https://api.openai.com/v1/chat/completions"

    Private Sub PicSwap_Click(sender As Object, e As EventArgs) Handles PicSwap.Click
        TextBox1.Text = " "
        Label9.Text = " "
        Label12.Text = " "
        Dim temp As String = ComboBox1.SelectedItem
        ComboBox1.SelectedItem = ComboBox2.SelectedItem
        ComboBox2.SelectedItem = temp
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso TextBox1.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Async Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim inputText As String = TextBox1.Text
        Dim amount As Double

        If String.IsNullOrWhiteSpace(inputText) OrElse Not Double.TryParse(inputText, amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = ""
            Label9.Text = " "
            Label12.Text = " "
            Label13.Text = " "
            Return
        End If

        Dim baseCurrency As String = ComboBox1.SelectedItem.ToString()
        Dim targetCurrency As String = ComboBox2.SelectedItem.ToString()

        Dim result As Double = Await GetExchangeRateFromOpenAI(baseCurrency, targetCurrency)
        Dim VAL1 As Double = CDbl(1 / result)

        If result <> -1 Then
            Label9.Text = " ~ " & (amount * result).ToString("F2")
            Label12.Text = $"For 1 {baseCurrency} ~ " & VAL1.ToString("F3") & $" {targetCurrency}"
            Label13.Text = $"Convert {amount} {baseCurrency} To {targetCurrency}"
        Else
            Label9.Text = "Error"
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        Label9.Text = " "
        ComboBox1.SelectedItem = Nothing
        ComboBox2.SelectedItem = Nothing
        Label13.Text = " "
        Label12.Text = " "
    End Sub

    Private Async Function GetExchangeRateFromOpenAI(baseCurrency As String, targetCurrency As String) As Task(Of Double)
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {OpenAIKey}")

            Dim prompt As String = $"Give only the exchange rate from {baseCurrency} to {targetCurrency}. Return only the number, no explanation."

            ' Serialize JSON format
            Dim jsonPayload As String = JsonConvert.SerializeObject(New With {
                .model = "gpt-3.5-turbo",
                .messages = New Object() {
                    New With {.role = "system", .content = "You are a helpful assistant."},
                    New With {.role = "user", .content = prompt}
                },
                .max_tokens = 50
            })

            Dim content As New StringContent(jsonPayload, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync(OpenAIEndpoint, content)

            If response.IsSuccessStatusCode Then
                Dim responseBody = Await response.Content.ReadAsStringAsync()

                Dim jsonResponse = JsonConvert.DeserializeObject(Of Newtonsoft.Json.Linq.JObject)(responseBody) 'filter,search...
                Dim messageContent = jsonResponse("choices")(0)("message")("content").ToString()

                Dim match = System.Text.RegularExpressions.Regex.Match(messageContent, "\d+(\.\d+)?")
                If match.Success Then
                    Dim rate As Double
                    If Double.TryParse(match.Value, rate) Then
                        Return rate
                    End If
                End If
            End If
            Return -1
        End Using
    End Function

    Private Sub BtnAssistance_Click(sender As Object, e As EventArgs) Handles BtnAssistance.Click
        Dim assistantForm As New Form2()
        Dim MainPage As New Form1()
        assistantForm.Show()
        MainPage.Hide()
    End Sub

End Class