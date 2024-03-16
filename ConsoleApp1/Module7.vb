Imports System.Console
Module Module7

    Function Add()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer

        WriteLine("Enter the First Number: ")
        a = ReadLine()
        WriteLine("Enter the Second Number: ")
        b = ReadLine()
        WriteLine("Enter the Third Number: ")
        c = ReadLine()
        d = a + b + c
        WriteLine("The sum of three Numbers is : " & d)

    End Function

    Sub Main()
        Add()
        ReadLine()
        End Sub



End Module
