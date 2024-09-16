Public Class Mahasiswa
    'Menginialisasi Properti atau atribut untuk kelas induk
    Public Property Nama As String
    Public Property NIM As Integer

    'Buatkan untuk constructor pada kelas mahasiswa
    Public Sub New(ByVal nama As String, ByVal nim As Integer)
        Me.Nama = nama
        Me.NIM = nim
    End Sub

    'Membuat Method untuk menampilkan fungsi dari class mahasiswa
    Public Overridable Function GetInfo() As String
        Return "Nama : " & Nama & vbCrLf & "NIM : " & NIM & vbCrLf
    End Function
End Class

Public Class Organisasi
    Inherits Mahasiswa

    'menginialisasi Properti anatu atribut untuk child class
    Public Property NamaOrganisasi As String
    Public Property KTA As Long

    'Buatkan untuk constructor pada kelas child class
    Public Sub New(ByVal nama As String, ByVal nim As Integer, ByVal namaOrganisasi As String, ByVal kta As Long)
        MyBase.New(nama, nim)
        Me.NamaOrganisasi = namaOrganisasi
        Me.KTA = kta
    End Sub

    'Buatkan method untuk overriding pada method parent class
    Public Overrides Function GetInfo() As String
        Dim Info As String = MyBase.GetInfo()
        Return Info & "Nama Organsisasi : " & NamaOrganisasi & vbCrLf & "KTA : " & KTA & vbCrLf
    End Function
End Class

Public Class jabatan
    Inherits Organisasi

    Public Property Namajabatan As String
    Public Property NoJabatan As Long

    'Buatkan untuk constructor pada kelas child class
    Public Sub New(ByVal nama As String, ByVal nim As Integer, ByVal namaOrganisasi As String, ByVal kta As Long, ByVal namaJabatan As String, ByVal nojabatan As Integer,)
        MyBase.New(nama, nim, namaOrganisasi, kta)
        Me.NamaOrganisasi = namaOrganisasi
        Me.KTA = kta
    End Sub

    'Buatkan method untuk overriding pada method parent class
    Public Overrides Function GetInfo() As String
        Dim Info As String = MyBase.GetInfo()
        Return Info & "Nama Organsisasi : " & NamaOrganisasi & vbCrLf & "KTA : " & KTA & vbCrLf
    End Function

End Class


Module Module2

    Sub Main()
        Dim Org As New Organisasi("Maheswara Wira Yoganata", 210101067, "Pecinta Alam", 102937849)

        Console.WriteLine(Org.GetInfo())
        Console.ReadLine()
    End Sub

End Module
