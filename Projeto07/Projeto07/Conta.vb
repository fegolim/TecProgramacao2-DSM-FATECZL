Public Class Conta

    Private cliente As String
    Private conta As String
    Private saldo As Decimal ''float

    Public Sub New(nome As String, conta As String, saldo As Decimal)
        Me.cliente = cliente
        Me.conta = conta
        Me.saldo = saldo
    End Sub

    Public Sub New()
    End Sub

    Public Property pCliente As String
        Get
            Return cliente
        End Get
        Set(value As String)
            cliente = value
        End Set
    End Property

    Public Property pConta As String
        Get
            Return conta
        End Get
        Set(value As String)
            conta = value
        End Set
    End Property

    Public Property pSaldo As Decimal
        Get
            Return saldo
        End Get
        Set(value As Decimal)
            saldo = value
        End Set
    End Property

    Public Sub Depositar(valor As Decimal)
        If (valor > 1) Then
            Me.saldo = saldo + valor
        Else
            MsgBox("Valor mínimo para depósito é de R$1")
        End If
    End Sub

    Public Sub Sacar(valor As Decimal)
        If (valor <= Me.saldo) Then
            Me.saldo = saldo - valor
        Else
            MsgBox("Valor maior que saldo disponível")
        End If
    End Sub
End Class
