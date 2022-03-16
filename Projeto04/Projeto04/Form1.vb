Public Class Form1
    Private Sub BtSair_Click(sender As Object, e As EventArgs) Handles BtSair.Click
        Me.Close()
    End Sub

    Private Sub BtOk_Click(sender As Object, e As EventArgs) Handles BtOk.Click
        MessageBox.Show("Olá " & TxtNome.Text & ". Seja Bem-vindo!", "Mensagem ao usuário")
    End Sub
End Class
