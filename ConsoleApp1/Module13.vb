Imports System.Console
Module Module13
    Sub Main()

        '      ****         ARRAYS         ****         '

        Dim a(2) As Integer
        Dim i As Integer
        a(0) = 10
        a(1) = 20
        a(2) = 30

        For Each i In a
            WriteLine("Elements are: " & i)
        Next
        For i = 0 To 2
            WriteLine("Elements are: " & a(i))
        Next
    End Sub
End Module
