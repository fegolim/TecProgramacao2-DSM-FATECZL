Public Class ModelIMC

    Private imc As Decimal
    Private peso As Decimal
    Private altura As Decimal

    Public Sub New(peso As Decimal, altura As Decimal)
        Me.peso = peso
        Me.altura = altura
    End Sub

    Public Property pImc As Decimal
        Get
            Return imc
        End Get
        Set(value As Decimal)
            imc = value
        End Set
    End Property

    Public Property pPeso As Decimal
        Get
            Return peso
        End Get
        Set(value As Decimal)
            peso = value
        End Set
    End Property

    Public Property pAltura As Decimal
        Get
            Return altura
        End Get
        Set(value As Decimal)
            altura = value
        End Set
    End Property

    Public Function classificarIMC(imc As Decimal)

        Dim classificacao As String

        If (imc <= 18.5) Then
            classificacao = "Desnutrido"
        ElseIf (imc >= 18.6 && imc <= 24.9) Then
            classificacao = "Adequado"
        ElseIf

        End If
    End Function

End Class
