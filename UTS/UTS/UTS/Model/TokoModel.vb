Public Class TokoModel

    Dim dataInventaris As New DataBarang
    Dim dataInventaris2 As New List(Of DataBarang)
    Dim idForSearch As Integer() = {}

    Public Sub DataBarang() ''DATABARANG
        Dim idBarang As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
        Dim namaBarang As String() = {"BENGBENG", "CHOCOLATOS", "LEMPER", "AQUA", "RISOLES", "BUKU", "PENSIL",
            "LUMPIA", "BOLPOIN", "MOUSEPAD", "BEBEK", "BUBUR", "INDOMIE", "MIE SEDAP", "SARIMIE", "SARDEN", "KUE KUKUS",
            "KERUPUK", "PEYEK", "SABUN"}
        Dim hargaBarang As String() = {"1000", "2000", "3000", "4000", "5000", "6000", "7000", "8000", "9000", "10000", "11000",
            "12000", "13000", "14000", "15000", "16000", "17000", "18000", "19000", "20000"}
        Dim stokBarang As Integer() = {20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20}
        For i = 0 To namaBarang.Length - 1
            dataInventaris2.Add(New DataBarang(idBarang(i), namaBarang(i), hargaBarang(i), stokBarang(i)))
        Next
    End Sub

    Public Function ShowDataBarang()
        Dim DataGrid As New DataTable
        DataGrid.Columns.Add("ID")
        DataGrid.Columns.Add("NAMA BARANG")
        DataGrid.Columns.Add("HARGA")
        DataGrid.Columns.Add("STOK")
        For i = 0 To dataInventaris2.Count - 1
            Dim show As String() = {dataInventaris2.Item(i).getId.ToString, dataInventaris2.Item(i).getNama.ToString,
                              dataInventaris2.Item(i).getHarga.ToString, dataInventaris2.Item(i).getStok.ToString}
            DataGrid.Rows.Add(show)
        Next
        Return DataGrid

    End Function


    Public Sub addBarang(idBarang As Integer, namaBarang As String, hargaBarang As String, stokBarang As Integer)
        dataInventaris2.Add(New DataBarang(idBarang, namaBarang, hargaBarang, stokBarang))
    End Sub

    Public Sub deleteBarang(idBarang As Integer)
        dataInventaris2.RemoveAt(getID(idBarang))
    End Sub

    Public Function getID(idBarang As Integer)
        Dim index As Integer = -1
        For i = 0 To dataInventaris2.Count - 1
            If dataInventaris2.Item(i).getId = idBarang Then
                index = i
            End If
        Next
        Return index
    End Function

    Public Sub updateStok(idBarang As Integer, stokMinus As Integer)
        For i = 0 To dataInventaris2.Count - 1
            If dataInventaris2.Item(i).getId = idBarang Then
                Dim stokBarangUpdateStok As Integer = dataInventaris2.Item(i).getStok
                Dim newTotalStok = stokBarangUpdateStok - stokMinus
                dataInventaris2.Item(i).setStok(newTotalStok)
            End If
        Next

    End Sub

    Public Function Search(idBarang As Integer)
        Dim Index As New Integer
        Index = Array.BinarySearch(idForSearch, idBarang)

        Return Index
    End Function

    Public Function getData(index As Integer)

        Return dataInventaris2.Item(index).getNama
    End Function

    Public Sub dataSearchingInput()

        For i = 0 To dataInventaris2.Count - 1
            ReDim Preserve idForSearch(i)
            idForSearch(i) = dataInventaris2.Item(i).getId

        Next

    End Sub


End Class
