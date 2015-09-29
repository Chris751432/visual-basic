Module Module1

    Sub Main()

        Dim userValue As String
        Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?")
        userValue = Console.ReadLine()

        Console.WriteLine("You typed: " & userValue)

        If userValue = "1" Then
            Console.WriteLine("You won a car!")
            Console.ReadLine()

        ElseIf userValue = "2" Then
            Console.WriteLine("You won a boat!")
            Console.ReadLine()

        ElseIf userValue = "3" Then
            Console.WriteLine("You won a truck!")
            Console.ReadLine()

        Else
            Console.WriteLine("Sorry, we did not understand your response you lose!")
            Console.ReadLine()
        End If

    End Sub

End Module
