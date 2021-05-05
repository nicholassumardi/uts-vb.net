Public MustInherit Class MasterData
    Protected idBarang As Integer
    Protected namaBarang As String
    Protected hargaBarang As String
    Protected stokBarang As Integer


    Public Sub New(idBarang As Integer, namaBarang As String, hargaBarang As String, stokBarang As Integer)
        Me.idBarang = idBarang
        Me.namaBarang = namaBarang
        Me.hargaBarang = hargaBarang
        Me.stokBarang = stokBarang
    End Sub

    Public Sub New()

    End Sub

    Public Overridable Function getId() As Integer
        Return idBarang
    End Function

    Public Overridable Function getNama()
        Return namaBarang
    End Function

    Public Overridable Function getHarga()
        Return hargaBarang
    End Function

    Public Overridable Function getStok() As Integer
        Return stokBarang
    End Function
    Public Overridable Sub setIdBarang(idBarang As Integer)
        Me.idBarang = idBarang
    End Sub
    Public Overridable Sub setNamaBarang(stokBarang As String)
        Me.namaBarang = namaBarang
    End Sub
    Public Overridable Sub setHargaBarang(stokBarang As String)
        Me.hargaBarang = hargaBarang
    End Sub
    Public Overridable Sub setStok(stokBarang As Integer)
        Me.stokBarang = stokBarang
    End Sub


End Class
