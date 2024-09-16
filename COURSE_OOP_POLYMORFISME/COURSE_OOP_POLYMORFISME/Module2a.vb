Public Class Matematika2
    'Membuat method untuk menghitung luas persegi
    Public Function LuasPersegi(ByVal sisi As Double) As Double
        Return sisi * sisi
    End Function

    Public Function LuasPersegiPanjang(ByVal panjang As Double, ByVal lebar As Double) As Double
        Return panjang * lebar
    End Function

    Public Function LuasLingkaran(ByVal jariJari As Double, ByVal isLingkaran As Boolean) As Double
        If isLingkaran Then
            Return Math.PI * jariJari * jariJari
        Else
            Return 0
        End If
    End Function
End Class


Module Module2a

    Sub Main()
        Dim mariHitung As New Matematika2

        Console.WriteLine("Luas Persegi : " & mariHitung.LuasPersegi(5))

        Console.WriteLine("Luas Persegi Panjang: " & mariHitung.LuasPersegiPanjang(5, 5))

        Console.WriteLine("Luas Lingkaran : " & mariHitung.LuasLingkaran(5, False))
        Console.ReadLine()
    End Sub

End Module
