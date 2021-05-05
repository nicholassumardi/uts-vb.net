Public Class DataBarang
    Inherits MasterData
    Public Sub New(idBarang As Integer, namaBarang As String, hargaBarang As String, stokBarang As Integer)
        MyBase.New(idBarang, namaBarang, hargaBarang, stokBarang)
    End Sub

    Public Sub New()

    End Sub

    Public Overrides Function getId() As Integer
        Return idBarang
    End Function

    Public Overrides Function getNama()
        Return namaBarang
    End Function

    Public Overrides Function getHarga()
        Return hargaBarang
    End Function
    Public Overrides Function getStok() As Integer
        Return stokBarang
    End Function
End Class
