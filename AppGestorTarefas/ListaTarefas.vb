Imports System.Data.SqlClient

Public Class ListaTarefas
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim home As New Inicio()
        home.Show()
        Me.Hide()
    End Sub

    Private Sub Inicio_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CarregarDados()
    End Sub

    Public Sub CarregarDados()
        Dim sql As String = "Select Nome, Descricao, DataLimite, DataCriacao, Concluida from Tarefa where UserId = @Id"


        Using conexao As New SqlConnection("Server=LAPTOP-OUQNUDE4\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;")
            Using comando As New SqlCommand(sql, conexao)
                comando.Parameters.AddWithValue("@Id", UserLogado.Id)

                Dim adapter As New SqlDataAdapter(comando)
                Dim tabela As New DataTable()
                adapter.Fill(tabela)
                DataGridView1.DataSource = tabela
            End Using
        End Using
    End Sub
End Class