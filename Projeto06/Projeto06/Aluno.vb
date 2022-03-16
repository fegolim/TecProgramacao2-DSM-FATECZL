Public Class Aluno

    Inherits Pessoa
    Private rgm As String

    Public Sub New(rgm As String, nome As String)
        MyBase.New(nome)
        Me.rgm = rgm
    End Sub

    Public Property pRgm As String
        Get
            Return rgm
        End Get
        Set(value As String)
            rgm = value
        End Set
    End Property
End Class
