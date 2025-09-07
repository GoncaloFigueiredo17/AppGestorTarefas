Imports System.Drawing.Drawing2D

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
        components = New ComponentModel.Container()
        Label1 = New Label()
        NameLabel = New TextBox()
        EmailLabel = New TextBox()
        PasswordLabel = New TextBox()
        Label2 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        checkPass = New CheckBox()
        TextBox1 = New TextBox()
        erroNome = New Label()
        erroEmail = New Label()
        erroPassword = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(217, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' NameLabel
        ' 
        NameLabel.Location = New Point(172, 146)
        NameLabel.Name = "NameLabel"
        NameLabel.PlaceholderText = "Introduza o seu nome"
        NameLabel.Size = New Size(205, 23)
        NameLabel.TabIndex = 1
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Location = New Point(172, 213)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.PlaceholderText = "Introduza o seu email"
        EmailLabel.Size = New Size(205, 23)
        EmailLabel.TabIndex = 3
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(172, 273)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.PlaceholderText = "Introduza a palavra-passe"
        PasswordLabel.Size = New Size(205, 23)
        PasswordLabel.TabIndex = 4
        PasswordLabel.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(242, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 5
        Label2.Text = "Welcome"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Location = New Point(172, 193)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Nome"
        TextBox5.Size = New Size(61, 16)
        TextBox5.TabIndex = 8
        TextBox5.Text = "Email"
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Location = New Point(172, 256)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Nome"
        TextBox6.Size = New Size(61, 16)
        TextBox6.TabIndex = 9
        TextBox6.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuBar
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(232, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 24)
        Button1.TabIndex = 10
        Button1.Text = "Registar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' checkPass
        ' 
        checkPass.AutoSize = True
        checkPass.Location = New Point(383, 275)
        checkPass.Name = "checkPass"
        checkPass.Size = New Size(54, 19)
        checkPass.TabIndex = 11
        checkPass.Text = "show"
        checkPass.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(172, 128)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Nome"
        TextBox1.Size = New Size(61, 16)
        TextBox1.TabIndex = 12
        TextBox1.Text = "Nome"
        ' 
        ' erroNome
        ' 
        erroNome.AutoSize = True
        erroNome.ForeColor = Color.Red
        erroNome.Location = New Point(170, 172)
        erroNome.Name = "erroNome"
        erroNome.Size = New Size(0, 15)
        erroNome.TabIndex = 16
        ' 
        ' erroEmail
        ' 
        erroEmail.AutoSize = True
        erroEmail.ForeColor = Color.Red
        erroEmail.Location = New Point(170, 238)
        erroEmail.Name = "erroEmail"
        erroEmail.Size = New Size(0, 15)
        erroEmail.TabIndex = 17
        ' 
        ' erroPassword
        ' 
        erroPassword.AutoSize = True
        erroPassword.ForeColor = Color.Red
        erroPassword.Location = New Point(170, 299)
        erroPassword.Name = "erroPassword"
        erroPassword.Size = New Size(0, 15)
        erroPassword.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Hand
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label3.Location = New Point(217, 374)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 15)
        Label3.TabIndex = 19
        Label3.Text = "Já tens conta? Faz login."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(579, 524)
        Controls.Add(Label3)
        Controls.Add(erroPassword)
        Controls.Add(erroEmail)
        Controls.Add(erroNome)
        Controls.Add(TextBox1)
        Controls.Add(checkPass)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label2)
        Controls.Add(PasswordLabel)
        Controls.Add(EmailLabel)
        Controls.Add(NameLabel)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameLabel As TextBox
    Friend WithEvents EmailLabel As TextBox
    Friend WithEvents PasswordLabel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents checkPass As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents erroNome As Label
    Friend WithEvents erroEmail As Label
    Friend WithEvents erroPassword As Label
    Friend WithEvents Label3 As Label

End Class
