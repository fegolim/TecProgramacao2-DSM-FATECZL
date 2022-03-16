Public Class Form1
    Private Sub BtExibirAluno_Click(sender As Object, e As EventArgs) Handles BtExibirAluno.Click
        Dim obj_aluno As New Aluno("666666", "Fulano de tal")
        TxtRgmAluno.Text = obj_aluno.pRgm
        TxtNomeAluno.Text = obj_aluno.PNome
    End Sub

    Private Sub BtExibirProf_Click(sender As Object, e As EventArgs) Handles BtExibirProf.Click
        Dim obj_professor As New Professor("Doutor", "Ciclano de Tal")
        TxtProfTitulo.Text = obj_professor.pTitulo
        TxtNomeProf.Text = obj_professor.profNome
    End Sub
End Class
