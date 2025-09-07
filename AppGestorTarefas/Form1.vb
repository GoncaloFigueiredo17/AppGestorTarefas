Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

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
            erroPassword.Text = "Por favor , introduza uma password válida.."
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
        If erroNome.Text = "" AndAlso erroEmail.Text = "" AndAlso erroPassword.Text = "" Then
            If NameLabel.Text.Trim() <> "" AndAlso EmailLabel.Text.Trim() <> "" AndAlso PasswordLabel.Text.Trim() <> "" Then
                'MessageBox.Show("Registo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Por favor , corrija os erros antes de submeter o formulário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Por favor,preencha os espaços em falta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim connectionString As String = "Server=LAPTOP-OUQNUDE4\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;"
        Dim insercao As String = "Insert into Utilizadores (Nome,Email,Password) values (@nome,@email,@password)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(insercao, connection)
                command.Parameters.AddWithValue("@nome", NameLabel.Text.Trim())
                command.Parameters.AddWithValue("@email", EmailLabel.Text.Trim())
                command.Parameters.AddWithValue("@password", HashPassword(PasswordLabel.Text.Trim()))
                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registo efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Falha no registo. Tente novamente.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & ex.Message)
                End Try
            End Using
        End Using
        Dim formsLogin As New LoginForm()
        formsLogin.Show()
        Me.Hide()
    End Sub

    Private Sub erroPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'encriptacao de password
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim formularioLogin As New LoginForm()
        formularioLogin.Show()
        Me.Hide() 'para fechar o formulario de registo
    End Sub
End Class
