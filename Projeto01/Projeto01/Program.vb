Imports System

Module Program
    Sub Main(args As String())
        'Dim nome As String
        'Dim idade As Integer
        'Dim salario As Double
        'Dim verdadeiro As Boolean

        'nome = "Vicente"
        'idade = 25
        'salario = 1000.0
        'verdadeiro = True

        'Console.WriteLine(nome)
        'Console.WriteLine(idade)
        'Console.WriteLine(salario)
        'Console.WriteLine(verdadeiro)

        'Dim nota1, nota2, media As Double
        'Dim aluno As String

        'Console.WriteLine("Nome do aluno: ")
        'aluno = Console.ReadLine()

        'Console.WriteLine("Primeira nota: ")
        'nota1 = Console.ReadLine()

        'Console.WriteLine("Segunda Nota: ")
        'nota2 = Console.ReadLine()

        'media = (nota1 + nota2) / 2

        'Console.WriteLine("A m�dia do aluno " & aluno & " � igual a " & media)

        Dim funcionario As String
        Dim salario, reajuste, novosalario As Double

        Console.WriteLine("Funcion�rio: ")
        funcionario = Console.ReadLine()

        Console.WriteLine("Sal�rio inicial: ")
        salario = Console.ReadLine

        Console.WriteLine("Percentual de reajuste: ")
        reajuste = Console.ReadLine

        novosalario = salario + salario * reajuste / 100

        Console.WriteLine("O novo sal�rio do funcion�rio " & funcionario & " � de R$" & novosalario)

    End Sub
End Module
