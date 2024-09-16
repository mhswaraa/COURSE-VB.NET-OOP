Public Class Motor
    'Atribut or properti (Encapsulation dengan modifier "private")
    Private Merk As String
    Private Tipe As String
    Private Tahun As String

    'Mendeklarasikan constructor dari kelas motor
    Public Sub New(ByVal merk As String, ByVal tipe As String, ByVal tahun As Integer)
        Me.Merk = merk
        Me.Tipe = tipe
        Me.Tahun = tahun
    End Sub

    'Membuat method untuk menampilkan data motor
    Public Function GetInfo() As String
        Return "Merk : " & Merk & vbCrLf & "Tipe : " & Tipe & vbCrLf & "Tahun : " & Tahun & vbCrLf
    End Function

    'merubah warna motor
    Public Sub UbahTipe(ByVal TipeBaru As String)
        Tipe = TipeBaru
    End Sub
End Class

Module Module2

    Sub Main()
        ' Mendeklarasikan kelas motor
        Dim Motor1 As New Motor("Cb100", "Standar", 2000)

        'Menampilkan info motor
        Console.WriteLine(Motor1.GetInfo())

        'Setelah di rubah typenya
        Motor1.UbahTipe("herex")
        Console.WriteLine("Tiper baru :" & vbCrLf & Motor1.GetInfo())

        Console.ReadLine()
    End Sub


End Module
