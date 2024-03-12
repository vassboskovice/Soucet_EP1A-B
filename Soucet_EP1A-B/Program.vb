Imports System

Module Program
    Sub Main(args As String())

        Okno(10, 20)

        Console.ReadKey()
    End Sub

    Sub Okno(left As Integer, top As Integer)
        Console.SetCursorPosition(left, top)
        Console.WriteLine("╔═══╗")
        Console.SetCursorPosition(left, top + 1)
        Console.WriteLine("║ X ║")
        Console.SetCursorPosition(left, top + 2)
        Console.WriteLine("╚═══╝")
    End Sub
End Module
