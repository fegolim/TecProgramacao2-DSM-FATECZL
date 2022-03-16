Public Class Professor

    Inherits Pessoa
    Private titulo As String

    Public Sub New(titulo As String, nome As String)
        MyBase.New(nome)
        Me.titulo = titulo
    End Sub

    Public Property pTitulo As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property

End Class
