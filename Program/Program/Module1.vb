Module Module1

    Sub Main()

            'Console.WriteLine("   *   ")
            'Console.WriteLine("  * *  ")
            'Console.WriteLine(" * * * ")
            'Console.WriteLine("* * * *")

            Dim noRows As Integer
            Console.WriteLine("How many rows do you want?")
            noRows = Console.ReadLine

            Console.Clear()

            Dim number As Integer = -1

            For count = noRows To 1 Step -1

                number = number + 1

                printSpace(count)
                printStars(number)
                printSpace(count)

                Console.WriteLine("")

            Next
        End Sub

        Sub printStars(ByVal number As Integer)
            For x = 0 To number
                Console.Write("* ")
            Next
        End Sub

        Sub printSpace(ByVal count As Integer)
            For x = 0 To count
                Console.Write(" ")
            Next
        End Sub

    End Module






