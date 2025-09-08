Imports System.Data.SqlClient

Public Class Inicio
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Me.Shown
        Label1.Text = "Bem vindo, " + UserLogado.Nome
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TituloBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles DescricaoBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim titulo As String = TituloBox.Text
        Dim descricao As String = DescricaoBox.Text
        Dim dataLimite As Date = DateTimePicker1.Value
        Dim userId As Integer = UserLogado.Id
        Dim dataAtual As Date = DateTime.Now

        'fazer a validacao de campos vazios
        If titulo = "" AndAlso descricao = "" Then
            MessageBox.Show("Por favor, preencha os campos em falta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dataLimite < dataAtual Then
            MessageBox.Show("A data limite não pode ser anterior à data atual", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GuardarTarefa(titulo, descricao, dataLimite, userId, dataAtual)
            MessageBox.Show("Tarefa guardada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'reset do formulario
            TituloBox.Text = ""
            DescricaoBox.Text = ""
            DateTimePicker1.Value = DateTime.Now
        End If
    End Sub

    'funcao para guardar tarefas
    Public Function GuardarTarefa(titulo, descricao, dataLimite, userId, dataAtual) As Boolean
        Dim connectionString As String = "Server=LAPTOP-OUQNUDE4\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;"
        Dim insercao As String = "Insert into Tarefa (Nome,Descricao,DataLimite,DataCriacao,Concluida,UserId) values (@titulo,@descricao,@dataLimite,@dataAtual,@concluida,@userId)"

        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(insercao, connection)
                    command.Parameters.AddWithValue("@titulo", titulo)
                    command.Parameters.AddWithValue("@descricao", descricao)
                    command.Parameters.AddWithValue("@dataLimite", dataLimite)
                    command.Parameters.AddWithValue("@dataAtual", dataAtual)
                    command.Parameters.AddWithValue("@concluida", False)
                    command.Parameters.AddWithValue("@userId", userId)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Erro ao guardar a tarefa: " & ex.Message)
            Return False
        End Try
    End Function

End Class




