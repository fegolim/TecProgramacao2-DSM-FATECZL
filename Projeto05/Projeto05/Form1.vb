Public Class Form1
    Private Sub BtComp_Click(sender As Object, e As EventArgs) Handles BtComp.Click
        Dim idade1, idade2 As Integer

        idade1 = CInt(TxtIdade1)
        idade2 = CInt(TxtIdade2)


        If idade1 > idade2 Then
            MessageBox.Show("A idade " & idade1 & " anos é maior que " & idade2 & " anos.")
        ElseIf idade2 > idade1 Then
            MessageBox.Show("A idade " & idade2 & " anos é maior que " & idade1 & " anos.")
        Else
            MessageBox.Show("A idade " & idade1 & " anos é igual a idade " & idade2 & " anos.")
        End If
    End Sub
End Class
