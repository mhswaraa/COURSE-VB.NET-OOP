Public Class Employee
    'Atribut or Property (encapsulation yang di modifier "Private")
    Private Nama As String
    Private NIK As Integer
    Private NoHp As Long
    Private Kota As String

    'Constructor Property
    Public Sub New(ByVal nama As String, ByVal nik As Integer, ByVal noHP As Long, ByVal kota As String)
        Me.Nama = nama
        Me.NIK = nik
        Me.NoHp = noHP
        Me.Kota = kota
    End Sub

    'Method Untuk employee get info
    Public Function GetData() As String
        Return "Nama : " & Nama & vbCrLf & "NIK : " & NIK & vbCrLf & "NoHP : " & NoHp & vbCrLf & "Kota : " & Kota & vbCrLf
    End Function

    'Method Untuk Merubah Kota
    Public Sub GantiKota(ByVal KotaBaru As String)
        Kota = KotaBaru
    End Sub
End Class

Module Module3

    Sub Main()

        Console.Write("Masukkan nama : ")
        Dim nama1 As String = Console.ReadLine

        Console.Write("Masukkan NIK : ")
        Dim nik1 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Masukkan NoHp : ")
        Dim NoHp1 As Long = Long.Parse(Console.ReadLine())

        Console.Write("Masukkan Kota : ")
        Dim kota1 As String = Console.ReadLine

        Dim Employee1 As New Employee(nama1, nik1, NoHp1, kota1)
        Console.WriteLine(Employee1.GetData())


        Console.Write("Masukkan Kota : ")
        Dim KotaBaru As String = Console.ReadLine

        Employee1.GantiKota(KotaBaru)
        Console.WriteLine("Setelah di ganti kota : " & vbCrLf & Employee1.GetData())

        Console.ReadLine()
    End Sub


End Module
