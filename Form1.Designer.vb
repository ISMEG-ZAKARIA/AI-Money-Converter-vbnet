<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PicSwap = New PictureBox()
        BtnConvert = New Button()
        BtnClear = New Button()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        ComboBox2 = New ComboBox()
        Label4 = New Label()
        BtnAssistance = New Button()
        Label9 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSwap, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(853, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(843, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 199)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.InactiveCaptionText
        Label2.Location = New Point(773, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(353, 32)
        Label2.TabIndex = 2
        Label2.Text = "Online Currency Converter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.InactiveCaptionText
        Label3.Location = New Point(886, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 32)
        Label3.TabIndex = 3
        Label3.Text = "Welcome"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkOliveGreen
        Label6.Location = New Point(722, 430)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 32)
        Label6.TabIndex = 7
        Label6.Text = "From"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkOliveGreen
        Label7.Location = New Point(1045, 430)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 32)
        Label7.TabIndex = 11
        Label7.Text = "Convert To"
        ' 
        ' PicSwap
        ' 
        PicSwap.Cursor = Cursors.Hand
        PicSwap.Image = CType(resources.GetObject("PicSwap.Image"), Image)
        PicSwap.Location = New Point(906, 430)
        PicSwap.Name = "PicSwap"
        PicSwap.Size = New Size(80, 78)
        PicSwap.SizeMode = PictureBoxSizeMode.StretchImage
        PicSwap.TabIndex = 14
        PicSwap.TabStop = False
        ' 
        ' BtnConvert
        ' 
        BtnConvert.BackColor = Color.Gainsboro
        BtnConvert.Location = New Point(705, 898)
        BtnConvert.Name = "BtnConvert"
        BtnConvert.Size = New Size(191, 44)
        BtnConvert.TabIndex = 15
        BtnConvert.Text = "Convert"
        BtnConvert.UseVisualStyleBackColor = False
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Color.Gainsboro
        BtnClear.Location = New Point(986, 898)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(186, 44)
        BtnClear.TabIndex = 16
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Gainsboro
        ComboBox1.DropDownHeight = 200
        ComboBox1.FlatStyle = FlatStyle.Popup
        ComboBox1.FormattingEnabled = True
        ComboBox1.IntegralHeight = False
        ComboBox1.Items.AddRange(New Object() {"United States Dollar", "EURO", "Indian Rupee", "Australian Dollar", "Canadian Dollar", "Singapore Dollar", "Yen", "Chinese Yuan Renminbi", "Argentine Peso", "Bahraini Dinar", "Botswana Pula", "Brazilian Real", "British Pound", "Bruneian Dollar", "Bulgarian Lev", "Chilean Peso", "Colombian Peso", "Czech Koruna", "Danish Krone", "Emirati Dirham", "Hungarian Forint", "Icelandic Krona", "Indonesian Rupiah", "Iranian Rial", "Israeli Shekel", "Kazakhstani Tenge", "Kuwaiti Dinar", "Libyan Dinar", "Malaysian Ringgit", "Mauritian Rupee", "Mexican Peso", "Nepalese Rupee", "New Zealand Dollar", "Norwegian Krone", "Omani Rial", "Pakistani Rupee", "Philippine Peso", "Polish Zloty", "Qatari Riyal", "Romanian New Leu", "Russian Ruble", "Saudi Arabian Riyal", "South African Rand", "South Korean Won", "Sri Lankan Rupee", "Swedish Krona", "Swiss Franc", "Taiwan New Dollar", "Thai Baht", "Trinidadian Dollar", "Turkish Lira"})
        ComboBox1.Location = New Point(650, 465)
        ComboBox1.MaxDropDownItems = 5
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(232, 27)
        ComboBox1.TabIndex = 17
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Times New Roman", 11.8956518F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(842, 566)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(210, 29)
        TextBox1.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkOliveGreen
        Label5.Location = New Point(891, 531)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 32)
        Label5.TabIndex = 18
        Label5.Text = "Amount"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Gainsboro
        ComboBox2.DropDownHeight = 200
        ComboBox2.FlatStyle = FlatStyle.Popup
        ComboBox2.FormattingEnabled = True
        ComboBox2.IntegralHeight = False
        ComboBox2.Items.AddRange(New Object() {"United States Dollar", "EURO", "Indian Rupee", "Australian Dollar", "Canadian Dollar", "Singapore Dollar", "Yen", "Chinese Yuan Renminbi", "Argentine Peso", "Bahraini Dinar", "Botswana Pula", "Brazilian Real", "British Pound", "Bruneian Dollar", "Bulgarian Lev", "Chilean Peso", "Colombian Peso", "Czech Koruna", "Danish Krone", "Emirati Dirham", "Hungarian Forint", "Icelandic Krona", "Indonesian Rupiah", "Iranian Rial", "Israeli Shekel", "Kazakhstani Tenge", "Kuwaiti Dinar", "Libyan Dinar", "Malaysian Ringgit", "Mauritian Rupee", "Mexican Peso", "Nepalese Rupee", "New Zealand Dollar", "Norwegian Krone", "Omani Rial", "Pakistani Rupee", "Philippine Peso", "Polish Zloty", "Qatari Riyal", "Romanian New Leu", "Russian Ruble", "Saudi Arabian Riyal", "South African Rand", "South Korean Won", "Sri Lankan Rupee", "Swedish Krona", "Swiss Franc", "Taiwan New Dollar", "Thai Baht", "Trinidadian Dollar", "Turkish Lira"})
        ComboBox2.Location = New Point(1008, 465)
        ComboBox2.MaxDropDownItems = 5
        ComboBox2.MaxLength = 5
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(232, 27)
        ComboBox2.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.InactiveCaptionText
        Label4.Location = New Point(928, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 32)
        Label4.TabIndex = 20
        Label4.Text = "to"
        ' 
        ' BtnAssistance
        ' 
        BtnAssistance.BackColor = Color.Gainsboro
        BtnAssistance.Location = New Point(853, 966)
        BtnAssistance.Name = "BtnAssistance"
        BtnAssistance.Size = New Size(186, 44)
        BtnAssistance.TabIndex = 26
        BtnAssistance.Text = "Chat with Converter AI"
        BtnAssistance.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 26.2956524F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkOliveGreen
        Label9.Location = New Point(867, 725)
        Label9.Name = "Label9"
        Label9.Size = New Size(31, 48)
        Label9.TabIndex = 27
        Label9.Text = " "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 26.2956524F, FontStyle.Bold)
        Label12.Location = New Point(562, 808)
        Label12.Name = "Label12"
        Label12.Size = New Size(31, 48)
        Label12.TabIndex = 30
        Label12.Text = " "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 26.2956524F, FontStyle.Bold)
        Label13.Location = New Point(509, 651)
        Label13.Name = "Label13"
        Label13.Size = New Size(31, 48)
        Label13.TabIndex = 31
        Label13.Text = " "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1834, 1102)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label9)
        Controls.Add(BtnAssistance)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(Label5)
        Controls.Add(BtnClear)
        Controls.Add(BtnConvert)
        Controls.Add(PicSwap)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        ForeColor = SystemColors.InactiveCaptionText
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSwap, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PicSwap As PictureBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAssistance As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label

End Class
