Public Class Inicio
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Me.Shown
        Label1.Text = UserLogado.Nome
    End Sub
End Class