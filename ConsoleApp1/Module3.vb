Imports System.Console

Module Module3
    'Function without Parameters'
    Function Add()
        Dim a As Integer, b As Integer, c As Integer
        WriteLine("Enter first number: ")
        a = ReadLine()
        WriteLine("Enter second number: ")
        b = ReadLine()
        c = a + b
        WriteLine("The sum is: " & c)
    End Function

    Sub Main()
        Add()
        ReadLine()
    End Sub

End Module
