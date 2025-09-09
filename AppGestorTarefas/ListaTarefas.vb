Imports System.Configuration
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
        Dim sql As String = "Select Nome, Descricao, DataLimite, Concluida from Tarefa where UserId = @Id"
        Using conexao As New SqlConnection(ConfigurationManager.ConnectionStrings("MyDatabase").ConnectionString)
            Using comando As New SqlCommand(sql, conexao)
                comando.Parameters.AddWithValue("@Id", UserLogado.Id)

                Dim adapter As New SqlDataAdapter(comando)
                Dim tabela As New DataTable()
                adapter.Fill(tabela)

                DataGridView2.DataSource = tabela


            End Using
        End Using
    End Sub

    Private Sub ListaTarefas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FecharApp(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
        CarregarDados()
    End Sub
End Class