Public Class Form1
    Dim ModelToko As New TokoModel
    Dim idBarang As Integer
    Dim namaBarang As String
    Dim hargaBarang As Integer
    Dim jumlahBarang As Integer
    Dim uangPembeli As Integer
    Dim totalHarga As Integer
    Dim stokBarang As Integer

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        hargaBarang = Integer.Parse(TextBox3.Text)
        jumlahBarang = Integer.Parse(TextBox4.Text)
        Dim totalHagraKeseluruhan As Integer
        totalHagraKeseluruhan = jumlahBarang * hargaBarang
        TextBox5.Text = totalHagraKeseluruhan
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Index As Integer
        idBarang = Integer.Parse(TextBox1.Text)
        Index = ModelToko.Search(idBarang)
        If Index > -1 Then
            MsgBox("DATA DENGAN NAMA = " + ModelToko.getData(Index) + " DITEMUKAN", MessageBoxButtons.OK, "SEARCHING")
        Else
            MsgBox("TIDAK DITEMUKAN", MessageBoxButtons.OK, "SEARCHING")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        idBarang = Integer.Parse(TextBox1.Text)
        jumlahBarang = Integer.Parse(TextBox4.Text)
        totalHarga = Integer.Parse(TextBox5.Text)
        uangPembeli = Integer.Parse(TextBox6.Text)

        Dim Kembalian As Integer
        Kembalian = uangPembeli - totalHarga
        ModelToko.updateStok(idBarang, jumlahBarang)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView1.DataSource = ModelToko.ShowDataBarang
        DataGridView2.DataSource = Nothing
        DataGridView2.Refresh()
        DataGridView2.DataSource = ModelToko.ShowDataBarang
        MsgBox("Kembalian = " & Kembalian)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        idBarang = Integer.Parse(TextBox7.Text)
        ModelToko.deleteBarang(idBarang)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView1.DataSource = ModelToko.ShowDataBarang
        DataGridView2.DataSource = Nothing
        DataGridView2.Refresh()
        DataGridView2.DataSource = ModelToko.ShowDataBarang
        ModelToko.dataSearchingInput()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        idBarang = Integer.Parse(TextBox7.Text)
        namaBarang = TextBox8.Text
        hargaBarang = TextBox9.Text
        stokBarang = Integer.Parse(TextBox10.Text)

        ModelToko.addBarang(idBarang, namaBarang, hargaBarang, stokBarang)
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView1.DataSource = ModelToko.ShowDataBarang
        DataGridView2.DataSource = Nothing
        DataGridView2.Refresh()
        DataGridView2.DataSource = ModelToko.ShowDataBarang
        ModelToko.dataSearchingInput()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Index As Integer
        idBarang = Integer.Parse(TextBox7.Text)
        Index = ModelToko.Search(idBarang)
        If Index > -1 Then
            MsgBox("DATA DENGAN NAMA = " + ModelToko.getData(Index) + " DITEMUKAN", MessageBoxButtons.OK, "SEARCHING")
        Else
            MsgBox("TIDAK DITEMUKAN", MessageBoxButtons.OK, "SEARCHING")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.Enabled = False
        ModelToko.DataBarang()
        ModelToko.dataSearchingInput()
        DataGridView1.DataSource = ModelToko.ShowDataBarang
        DataGridView2.DataSource = ModelToko.ShowDataBarang
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        TextBox7.Text = selectedrow.Cells(0).Value.ToString
        TextBox8.Text = selectedrow.Cells(1).Value.ToString
        TextBox9.Text = selectedrow.Cells(2).Value.ToString
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)
        TextBox1.Text = selectedrow.Cells(0).Value.ToString
        TextBox2.Text = selectedrow.Cells(1).Value.ToString
        TextBox3.Text = selectedrow.Cells(2).Value.ToString
    End Sub

End Class
