<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        BtnSend = New Button()
        TextBox2 = New TextBox()
        GroupBox1 = New GroupBox()
        RichTextBox1 = New RichTextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18.1565228F, FontStyle.Bold)
        Label1.Location = New Point(91, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(334, 32)
        Label1.TabIndex = 3
        Label1.Text = "Hi, I'm The Converter AI  "
        ' 
        ' BtnSend
        ' 
        BtnSend.BackColor = Color.Gainsboro
        BtnSend.Cursor = Cursors.Hand
        BtnSend.Location = New Point(175, 467)
        BtnSend.Name = "BtnSend"
        BtnSend.Size = New Size(156, 40)
        BtnSend.TabIndex = 16
        BtnSend.Text = "Send"
        BtnSend.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Times New Roman", 11.8956518F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(51, 513)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(399, 29)
        TextBox2.TabIndex = 20
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RichTextBox1)
        GroupBox1.Location = New Point(37, 77)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(432, 367)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Chat"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(14, 25)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(405, 328)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(498, 566)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox2)
        Controls.Add(BtnSend)
        Controls.Add(Label1)
        ForeColor = SystemColors.InactiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form2"
        Text = "AI Converter"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSend As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
