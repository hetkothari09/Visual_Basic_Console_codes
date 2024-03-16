Imports System.Console

Module Module8
    Function Perimeter()
        Dim r As Double
        Dim pi As Double = 3.14
        Dim result As Double

        WriteLine("Enter the radius of the circle: ")
        r = ReadLine()
        result = (2 * pi * r)
        WriteLine("The perimeter of the circle with radius {0} is : {1} ", r, result)
    End Function

    Function Area()
        Dim r1 As Double
        Dim pi1 As Double = 3.14
        Dim result1 As Double

        WriteLine("Enter the radius of the circle: ")
        r1 = ReadLine()
        result1 = (pi1) * (r1 * r1)
        WriteLine("The area of the circle with radius {0} is : {1}", r1, result1)

    End Function


    Sub Main()
        Perimeter()
        WriteLine()
        Area()
        ReadLine()
    End Sub



End Module
