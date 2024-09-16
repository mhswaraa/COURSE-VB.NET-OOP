' Abstrac Class Kendaraan
Public MustInherit Class Kendaraan
    'Property umum untuk kendaraan
    Public Property Merk As String
    Public Property Tahun As String

    'Constructor
    Public Sub New(ByVal merk As String, ByVal tahun As String)
        Me.Merk = merk
        Me.Tahun = tahun
    End Sub

    'Method umum untuk menampilkan infom kendaraan
    Public Function GetInfo() As String
        Return "Merk: " & Merk & ",Tahun : " & Tahun
    End Function

    'Abstract method (harus diimplementasikan di Subclass)
    Public MustOverride Sub Jalankan()
End Class

'Kelas Mobil yang mewarisi dari abstrac class kendaraan
Public Class Mobil
    Inherits Kendaraan

    Public Sub New(ByVal merk As String, ByVal tahun As String)
        MyBase.New(merk, tahun)
    End Sub

    Public Overrides Sub Jalankan()
        Console.WriteLine("Mobil " & Merk & " sedang berjalan.")
    End Sub
End Class

'Kelas Motor yang mewarisi dari abstract class kendaraan
Public Class SepedaMotor
    Inherits Kendaraan

    Public Sub New(ByVal merk As String, ByVal tahun As String)
        MyBase.New(merk, tahun)
    End Sub

    Public Overrides Sub Jalankan()
        Console.WriteLine("Sepeda Motor" & Merk & "sedang berjalan")
    End Sub
End Class

Module Module1

    Sub Main()
        'Membuat arrau dari abstrac class Kendaraan
        Dim kendaraanarray() As Kendaraan
        kendaraanarray = New Kendaraan(1) {}

        'Tambahkan objek Mobil dan SepedaMotor ke dalam array
        kendaraanarray(0) = New Mobil("Toyota", 2022)
        kendaraanarray(1) = New SepedaMotor("Yamaha", 2021)

        'Tampilkan info kendaraan dan jalankan
        For Each Kendaraan As Kendaraan In kendaraanarray
            Console.WriteLine(Kendaraan.GetInfo())
            Kendaraan.Jalankan()
        Next

        Console.ReadLine()
    End Sub

End Module
