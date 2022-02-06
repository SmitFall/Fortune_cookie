'Fallon Smith
'RCET0265
'Spring 2022
'Fortune Cookie
'https://github.com/SmitFall/Fortune_cookie

Option Explicit On
Option Strict On

Module Fortune_cookie

    Sub Main()

        Randomize()

        Dim randoNumber As Integer = CInt(Int((10 * Rnd()) + 1))

        Select Case randoNumber
            Case 1
                Console.WriteLine("Everything not saved will be lost ")
                Console.ReadLine()
            Case 2
                Console.WriteLine("Liquidize your assets! Buy Powerball tickets! It works")
                Console.ReadLine()
            Case 3
                Console.WriteLine("When life gives you lemons, squirt someone in the eye ")
                Console.ReadLine()
            Case 4
                Console.WriteLine("Believe. I know it sounds like a cat poster but its true ")
                Console.ReadLine()
            Case 5
                Console.WriteLine("Behind every great man is a woman rolling her eyes ")
                Console.ReadLine()
            Case 6
                Console.WriteLine("Life is pain. Anyone who says otherwise is selling something ")
                Console.ReadLine()
            Case 7
                Console.WriteLine("Two wrongs don't make a right, but they make a good excuse ")
                Console.ReadLine()
            Case 8
                Console.WriteLine("You only live once ")
                Console.ReadLine()
            Case 9
                Console.WriteLine("Think fast, but talk slow ")
                Console.ReadLine()
            Case 10
                Console.WriteLine("Don't eat yellow snow ")
                Console.ReadLine()
        End Select
    End Sub

End Module
