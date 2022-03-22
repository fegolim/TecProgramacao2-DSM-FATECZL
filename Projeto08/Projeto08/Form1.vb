Public Class Form1
    Private Sub BtIMC_Click(sender As Object, e As EventArgs) Handles BtIMC.Click
        Dim peso As Decimal = CDec(TxtPeso.Text)
        Dim altura As Decimal = CDec(TxtAltura.Text)

        Dim obj_imc As New ModelIMC(peso, altura)

        Dim resultado = obj_imc.CalcularIMC(obj_imc.pPeso, obj_imc.pAltura)
        Dim classificacao As String = obj_imc.classificarIMC(obj_imc.pImc)
        MessageBox.Show("O IMC é: " & resultado & " e a sua classificação é: " & classificacao)
    End Sub

    Private Sub BtSair_Click(sender As Object, e As EventArgs) Handles BtSair.Click
        Me.Close()
    End Sub

    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        TxtAltura.Clear()
        TxtPeso.Clear()
    End Sub
End Class
