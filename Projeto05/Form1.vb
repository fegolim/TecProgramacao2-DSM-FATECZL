Public Class Form1
    Private Sub BtComp_Click(sender As Object, e As EventArgs) Handles BtComp.Click
        Dim idade1, idade2 As Integer

        idade1 = CInt(TxtIdade1.Text)
        idade2 = CInt(TxtIdade2.Text)


        If idade1 > idade2 Then
            MessageBox.Show("A idade " & idade1 & " anos é maior que " & idade2 & " anos.")
        ElseIf idade2 > idade1 Then
            MessageBox.Show("A idade " & idade2 & " anos é maior que " & idade1 & " anos.")
        Else
            MessageBox.Show("A idade " & idade1 & " anos é igual a idade " & idade2 & " anos.")
        End If

    End Sub

    Private Sub BtLimp_Click(sender As Object, e As EventArgs) Handles BtLimp.Click
        LimparCampos()

    End Sub

    Private Sub LimparCampos()
        TxtIdade1.Clear()
        TxtIdade2.Clear()
    End Sub
End Class
