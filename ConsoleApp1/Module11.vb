﻿Class Student
    Private roll_no As Integer
    Private name As String
    Private fees As Integer
    Private address As String

    Sub ReadInfo()
        Console.Write("Enter roll number: ")
        roll_no = Integer.Parse(Console.ReadLine())

        Console.Write("Enter student name: ")
        name = Console.ReadLine()

        Console.Write("Enter student fees: ")
        fees = Integer.Parse(Console.ReadLine())

        Console.Write("Enter student address: ")
        address = Console.ReadLine()
    End Sub

    Sub PrintInfo()
        Console.WriteLine("Student Information")
        Console.WriteLine(vbTab & "Roll Number: " & roll_no)
        Console.WriteLine(vbTab & "Roll Name  : " & name)
        Console.WriteLine(vbTab & "Fees       : " & fees)
        Console.WriteLine(vbTab & "address    : " & address)
    End Sub
End Class

Module Module11
    Sub Main()
        Dim S As New Student

        S.ReadInfo()
        S.PrintInfo()
    End Sub
End Module