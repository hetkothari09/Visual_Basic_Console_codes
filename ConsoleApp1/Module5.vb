Imports System.Console

Module Module5
    Function Add(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim c As Integer
        c = a + b
        Return c
    End Function

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim X As Integer

        WriteLine("Enter first number: ")
        a = ReadLine()
        WriteLine("Enter second Number: ")
        b = ReadLine()

        X = Add(a, b)
        WriteLine("Sum is: " & X)
        WriteLine("Sum is: " & Add(a, b))
        ReadLine()
    End Sub

End Module
