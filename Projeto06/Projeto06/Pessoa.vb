Public Class Pessoa

    Private nome As String

    Public Sub New(nome As String)
        Me.nome = nome
    End Sub


    Public Property PNome As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Property profNome As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

End Class
