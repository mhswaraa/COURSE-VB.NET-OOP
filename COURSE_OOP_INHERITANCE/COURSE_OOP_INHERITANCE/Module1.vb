'Membuat class induk
Public Class Person
    'membuat properti untuk semua orang
    Public Property Nama As String
    Public Property Usia As Integer

    'membuat constructor untuk menginialisasi properti
    Public Sub New(ByVal nama As String, ByVal usia As Integer)
        Me.Nama = nama
        Me.Usia = usia
    End Sub

    'Method untuk menampilkan informasi dari kelas induk
    Public Overridable Function GetInfo() As String
        Return "Nama : " & Nama & vbCrLf & "Usia : " & Usia & vbCrLf
    End Function
End Class

Public Class Employee
    Inherits Person

    'membuat properti untuk kelas anak
    Public Property Jabatan As String
    Public Property Gaji As Decimal

    'Membuat constructor untuk mengambil kelas induk dan menginialisasi kelas anak
    Public Sub New(ByVal nama As String, ByVal usia As Integer, ByVal jabatan As String, ByVal gaji As Decimal)
        MyBase.New(nama, usia)
        Me.Jabatan = jabatan
        Me.Gaji = gaji
    End Sub

    ' Override metode dari kelas induk untuk menambahkan informasi tambahan
    Public Overrides Function GetInfo() As String
        Dim InfoInduk As String = MyBase.GetInfo()
        Return InfoInduk & vbCrLf & "Jabatan: " & Jabatan & vbCrLf & "Gaji: " & Gaji.ToString("C")
    End Function

End Class

Module Module1

    Sub Main()
        ' Membuat objek dari kelas Employee
        Dim emp As New Employee("Maheswara Wirayogata", 30, "Software Developer", 15000000)

        ' Menampilkan informasi karyawan
        Console.WriteLine(emp.GetInfo())

        Console.ReadLine() ' Menunggu input untuk menjaga console tetap terbuka
    End Sub

End Module
