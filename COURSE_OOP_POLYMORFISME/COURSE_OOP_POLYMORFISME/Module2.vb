Public Class Matematika

    'Buatkan Method Untuk menambahkan 2 bilangan
    Public Function Tambah(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    'Buatkan Method Untuk menambahkan 3 bilangan
    Public Function Tambah(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return a + b + c
    End Function
End Class


Module Module2

    Sub Main()
        'Mendeklarasikan untuk properti class terlebih dahulu
        Dim hitung As New Matematika

        Console.WriteLine("Hasil 1 : " & hitung.Tambah(4, 4))

        Console.WriteLine("Hasil 2 : " & hitung.Tambah(4, 4, 4))

        Console.ReadLine()
    End Sub

End Module
