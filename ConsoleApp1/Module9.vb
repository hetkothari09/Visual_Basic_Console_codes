Imports System.Console

Module Module9

    Function Company()

        Dim name As String
        Dim address As String
        Dim phno As Long
        Dim fax As Long
        Dim website As String
        Dim manager As String

        WriteLine("Company:")
        WriteLine()
        WriteLine("Name of the company: ")
        name = ReadLine()
        WriteLine("Address : ")
        address = ReadLine()
        WriteLine("Phone Number:")
        phno = ReadLine()
        manager = ReadLine()
        WriteLine("Fax Number:")
        fax = ReadLine()

        WriteLine("Official Website of the Company: ")

        website = ReadLine()

        WriteLine("Who is the Manager of The Company: ")

        WriteLine()

        WriteLine()

        WriteLine()

        WriteLine("The name of the Company is : " & name)

        WriteLine("The Address of the Company is : " & address)

        WriteLine("For Further information you can call on : " & phno)

        WriteLine("The FAX number of the Company is : " & fax)

        WriteLine("The Official Website of the Company is : " & website)

        WriteLine("The Name of the Manager of the Company is : " & manager)

    End Function

    Function Manager()

        Dim name As String

        Dim surname As String

        Dim phno As Long

        WriteLine("Manager:")

        WriteLine()

        WriteLine("Name of the Manager: ")

        name = ReadLine()

        WriteLine("Surname of the Manager: ")

        surname = ReadLine()

        WriteLine("Phone Number of the Manager: ")

        phno = ReadLine()

        WriteLine()

        WriteLine()

        WriteLine()

        WriteLine("The name of the Manager is : " & name)

        WriteLine("The surname of the Manager is : " & surname)

        WriteLine("The Phone Number of the Manager is : " & phno)

    End Function

    Sub Main()

        Company()

        WriteLine()

        WriteLine()

        WriteLine()

        WriteLine()

        Manager()

        ReadLine()

    End Sub

End Module