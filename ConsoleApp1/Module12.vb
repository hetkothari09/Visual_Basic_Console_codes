Imports System.Console

Module Module12

    Sub Main()

        Dim score As Integer

        WriteLine("Enter Your Marks (0-100): ")
        score = ReadLine()

        score = score / 10

        Select Case score
            Case 10, 9
                WriteLine("Excellent!")
            Case 8, 7
                WriteLine("Well Done")
            Case 5, 6
                WriteLine("Very Good")
            Case 4
                WriteLine("Good")
            Case 3, 2, 1
                WriteLine("Try Again Next Time")
            Case Else
                WriteLine("Invalid Grade")
        End Select

        ReadLine()


    End Sub
End Module
