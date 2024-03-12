Imports System

Module Program
    Sub Main(args As String())
        Okno(25, 5, "  Součet n čísel  ")
        Okno(25, 8, " Zadej číslo:     ")
        Okno(25, 11, " Součet je        ")
        Console.ReadKey()
    End Sub

    Sub Okno(left As Integer, top As Integer, text As String)
        Dim cara As String = New String("═", text.Length)

        Console.SetCursorPosition(left, top)
        Console.WriteLine($"╔═{cara}═╗")
        Console.SetCursorPosition(left, top + 1)
        Console.WriteLine($"║ {text} ║")
        Console.SetCursorPosition(left, top + 2)
        Console.WriteLine($"╚═{cara}═╝")
    End Sub
End Module
