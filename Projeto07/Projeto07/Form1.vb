Public Class Form1

    Dim obj_poupanca As New Poupanca

    Private Sub BtCriar_Click(sender As Object, e As EventArgs) Handles BtCriar.Click
        obj_poupanca.pConta = TxtConta.Text
        obj_poupanca.pCliente = TxtCliente.Text
        obj_poupanca.pSaldo = CDec(TxtSaldoInicial.Text)
        obj_poupanca.pAniversario = CInt(TxtAniversario.Text)

        TxtSaldoFinal.Text = obj_poupanca.pSaldo

        AtualizaSaldo()
    End Sub
    Private Sub AtualizaSaldo()
        TxtSaldoFinal.Text = obj_poupanca.pSaldo
    End Sub

    Private Sub BtDepositar_Click(sender As Object, e As EventArgs) Handles BtDepositar.Click
        obj_poupanca.Depositar(CDec(TxtValor.Text))
        AtualizaSaldo()
    End Sub

    Private Sub BtSacar_Click(sender As Object, e As EventArgs) Handles BtSacar.Click
        obj_poupanca.Sacar(CDec(TxtValor.Text))
        AtualizaSaldo()
    End Sub

    Private Sub BtSair_Click(sender As Object, e As EventArgs) Handles BtSair.Click
        Me.Close()

    End Sub
End Class
