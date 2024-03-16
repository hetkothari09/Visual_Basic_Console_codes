Imports System.Console

Module Module4
    Function Add(ByVal a As Integer, ByVal b As Integer)
        Dim c As Integer
        c = a + b
        WriteLine("Sum is: " & c)
    End Function

    Sub Main()
        Dim X As Integer, Y As Integer

        WriteLine("Enter first number: ")
        X = ReadLine()
        WriteLine("Enter second Number: ")
        Y = ReadLine()

        Add(X, Y)
        ReadLine()
    End Sub
End Module
