Public Class Kendaraan
    Public Overridable Sub Roda()
        Console.WriteLine("Mempunyai roda :")
    End Sub
End Class

Public Class Mobil
    Inherits Kendaraan
    Public Overrides Sub Roda()
        Console.WriteLine("4")
    End Sub
End Class

Public Class Motor
    Inherits Kendaraan
    Public Overrides Sub Roda()
        Console.WriteLine("2")
    End Sub
End Class


Module Module1a

    Sub Main()
        Dim kendaraan As Kendaraan

        'Object Mobil
        kendaraan = New Mobil()
        kendaraan.Roda()

        'Object Motor
        kendaraan = New Motor()
        kendaraan.Roda()

        Console.ReadLine()
    End Sub

End Module
