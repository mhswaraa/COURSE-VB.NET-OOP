Public Class Mobil
    'Atribut atau properti (encapsualtion dengan modifier "Private")
    Private Merk As String
    Private Warna As String
    Private Tahun As String

    'Mendeklarasi Constructor dari kelas "Mobil"
    Public Sub New(ByVal merk As String, ByVal warna As String, ByVal tahun As Integer)
        Me.Merk = merk
        Me.Warna = warna
        Me.Tahun = tahun
    End Sub

    'Method untuk menampilkan info mobil
    Public Function GetInfo() As String
        Return "Merk :" & Merk & vbCrLf & "Warna :" & Warna & vbCrLf & "Tahun :" & Tahun & vbCrLf
    End Function

    'Method untuk menampilkan setelah di rubah warnanya
    Public Sub GantiWarna(ByVal WarnaBaru As String)
        Warna = WarnaBaru
    End Sub
End Class

Module Module1

    Sub Main()
        'Mendeklarasikan Constructor
        Dim Mobil1 As New Mobil("Toyota", "Merah", 2022)
        'Mengambil data method kelas mobil 
        Console.WriteLine(Mobil1.GetInfo())

        'Merubah warna
        Mobil1.GantiWarna("Pink")
        Console.WriteLine("Setelah di ganti warna :" & vbCrLf & Mobil1.GetInfo())

        Console.ReadLine()
    End Sub

End Module
