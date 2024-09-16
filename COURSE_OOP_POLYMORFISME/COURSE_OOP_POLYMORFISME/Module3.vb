Public Class lingkaran
    Implements IOperasi

    Public Property JariJari As Double

    Public Sub New(ByVal jariJari As Double)
        Me.JariJari = jariJari
    End Sub

    'Inplementasi metode Hitung dari interface
    Public Function Hitung() As Double Implements IOperasi.Hitung
        Return Math.PI * JariJari * JariJari
    End Function
End Class

'Kelas Persegi mengimplementasi IOperasi
Public Class Persegi
    Implements IOperasi

    Public Property Sisi As Double

    Public Sub New(ByVal sisi As Double)
        Me.Sisi = sisi
    End Sub

    Public Function Hitung() As Double Implements IOperasi.Hitung
        Return Sisi * Sisi
    End Function
End Class

Module Module3

    Sub Main()

    End Sub

End Module
