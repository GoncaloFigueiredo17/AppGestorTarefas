Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    'validacoes para o nome do utilizador
    Private Sub NameLabel_TextChanged(sender As Object, e As EventArgs) Handles NameLabel.Leave
        Dim nome As String = NameLabel.Text.Trim()

        ' Limpa mensagem de erro
        erroNome.Text = ""

        ' Validação de tamanho
        If nome.Length < 3 Or nome.Length > 20 Then
            erroNome.Text = "O nome precisa de ter entre 3 e 20 caracteres"
        ElseIf Not Regex.IsMatch(nome, "^[a-zA-Z ]+$") Then
            erroNome.Text = "O nome não pode conter números ou caracteres especiais."
        End If

    End Sub

    'validacoes para o email do utilizador
    Private Sub EmailLabel_TextChanged(sender As Object, e As EventArgs) Handles EmailLabel.Leave
        Dim email As String = EmailLabel.Text.Trim()

        erroEmail.Text = ""

        If String.IsNullOrEmpty(email) Then
            erroEmail.Text = "Por favor , preencha este campo"
        ElseIf Not Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            erroEmail.Text = "Email inválido , tente novamente"
        End If

    End Sub

    'validacoes para a password
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles PasswordLabel.Leave
        Dim password As String = PasswordLabel.Text.Trim()

        erroPassword.Text = ""

        If String.IsNullOrEmpty(password) Then
            erroPassword.Text = "Por favor , introduza a sua password"
        ElseIf Not Regex.IsMatch(password, "^[a-zA-Z0-9!@#$%&*()_+\-=\.,?]+$") Then
            erroPassword.Text = "Por favor , introduza uma password válida"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkPass.CheckedChanged
        If checkPass.Checked = True Then
            PasswordLabel.UseSystemPasswordChar = False
        Else
            PasswordLabel.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nome As String = NameLabel.Text.Trim()
        Dim email As String = EmailLabel.Text.Trim()
        Dim password As String = PasswordLabel.Text.Trim()
    End Sub

    Private Sub erroPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class
