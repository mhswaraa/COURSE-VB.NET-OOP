Public Class Hewan
    Public Overridable Sub Suara()
        Console.WriteLine("Hewan mengeluarkan suara")
    End Sub
End Class

Public Class Anjing
    Inherits Hewan
    Public Overrides Sub Suara()
        Console.WriteLine("Anjing Menggonggong")
    End Sub
End Class

Public Class Kucing
    Inherits Hewan
    Public Overrides Sub Suara()
        Console.WriteLine("Kucing Mengeong")
    End Sub
End Class

Module Module1

    Sub Main()
        Dim hewan As Hewan

        hewan = New Anjing()
        hewan.Suara()

        hewan = New Kucing()
        hewan.Suara()

        Console.ReadLine()
    End Sub
End Module
