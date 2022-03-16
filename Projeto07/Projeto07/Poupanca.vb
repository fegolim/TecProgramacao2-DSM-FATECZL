Public Class Poupanca

    Inherits Conta
    Private aniversario As Integer

    Public Sub New(conta As String, cliente As String, saldo As Decimal, aniversario As Integer)
        MyBase.New(conta, cliente, saldo)
        Me.aniversario = aniversario
    End Sub

    Public Sub New()
    End Sub

    Public Property pAniversario As Integer
        Get
            Return aniversario
        End Get
        Set(value As Integer)
            aniversario = value
        End Set
    End Property
End Class
