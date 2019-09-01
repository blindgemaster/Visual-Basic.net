Module Module1

    Sub Main()
        Dim q As Integer
        Dim g, h, i, j, k, l, m, n, o As String
        Dim sign As String
        Dim index As Integer
        Dim counter As Integer
        Dim flag As Boolean
        Do Until q = 2
            flag = False
            g = "1"
            h = "2"
            i = "3"
            j = "4"
            k = "5"
            l = "6"
            m = "7"
            n = "8"
            o = "9"
            counter = 0
            Do Until counter = 9 Or flag = True
                counter = counter + 1
                Console.Clear()
                Console.WriteLine("       |         |       ")
                Console.WriteLine("   " & g & "   |    " & h & "    |   " & i & "   ")
                Console.WriteLine("_______|_________|_______")
                Console.WriteLine("       |         |       ")
                Console.WriteLine("   " & j & "   |    " & k & "    |   " & l & "   ")
                Console.WriteLine("_______|_________|_______")
                Console.WriteLine("       |         |       ")
                Console.WriteLine("   " & m & "   |    " & n & "    |   " & o & "   ")
                Console.WriteLine("       |         |       ")
                Console.WriteLine()
                Console.WriteLine("Enter Number of your box")
                index = Console.ReadLine()
                If counter = 1 Or counter = 3 Or counter = 5 Or counter = 7 Or counter = 9 Then
                    sign = "o"
                Else : sign = "*"
                End If
                If index = 1 Then
                    g = sign
                ElseIf index = 2 Then
                    h = sign
                ElseIf index = 3 Then
                    i = sign
                ElseIf index = 4 Then
                    j = sign
                ElseIf index = 5 Then
                    k = sign
                ElseIf index = 6 Then
                    l = sign
                ElseIf index = 7 Then
                    m = sign
                ElseIf index = 8 Then
                    n = sign
                ElseIf index = 9 Then
                    o = sign
                End If
                If g = k And k = o Or m = k And k = i Or g = j And j = m Or h = k And k = n Or i = l And l = o Or g = h And h = i Or j = k And k = l Or m = n And n = o Then
                    flag = True
                End If

            Loop
            Console.Clear()
            Console.WriteLine("       |         |       ")
            Console.WriteLine("   " & g & "   |    " & h & "    |   " & i & "   ")
            Console.WriteLine("_______|_________|_______")
            Console.WriteLine("       |         |       ")
            Console.WriteLine("   " & j & "   |    " & k & "    |   " & l & "   ")
            Console.WriteLine("_______|_________|_______")
            Console.WriteLine("       |         |       ")
            Console.WriteLine("   " & m & "   |    " & n & "    |   " & o & "   ")
            Console.WriteLine("       |         |       ")
            Console.WriteLine()
            If flag = True Then
                Console.WriteLine("Winner Winner Chicken Dinner!")
            Else : Console.WriteLine("It's a DRAW")
            End If
            Console.ReadKey()
        Loop
    End Sub


End Module
