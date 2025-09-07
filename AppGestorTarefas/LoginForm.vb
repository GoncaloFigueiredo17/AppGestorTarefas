Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class LoginForm

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim email As String = UsernameTextBox.Text
        Dim password As String = HashPassword(PasswordTextBox.Text)

        Dim connectionString As String = "Server=LAPTOP-OUQNUDE4\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;"
        Dim conexao As New SqlConnection(connectionString)


        conexao.Open()

        Dim dados As String = "Select * from MyDatabase.dbo.Utilizadores where Email = @email and Password=@password"
        Dim comando As New SqlCommand(dados, conexao)
        comando.Parameters.AddWithValue("@email", email)
        comando.Parameters.AddWithValue("@password", password)

        'executar a query e verificar se existe o utilizador
        Dim count As Integer = CInt(comando.ExecuteScalar())

        If count > 0 Then
            'autenticação bem sucedida
            MessageBox.Show("Login efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim homescreen As New HomeScreen()
            homescreen.Show()
            Me.Hide() 'para fechar o formulario de login
        Else
            MessageBox.Show("Esse utilizador não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim formularioRegisto As New Form1()
        formularioRegisto.Show()
        Me.Hide() 'para fechar o formulario de login
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    'encriptacao de password
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
