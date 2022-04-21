Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim lokasi As String
    Dim cmd As OleDbCommand

    Sub koneksi()
        lokasi = "provider = microsoft.ace.oledb.12.0; data source = penjualan.accdb"
        conn = New OleDbConnection(lokasi)
        If conn.State = ConnectionState.Closed Then conn.Open()

    End Sub
    Dim Xkode, Xharga, Sharga, Xjumlah, Xsubh, Spotongan, SSubG, Spajak, Sgrand As Double
    Dim Xtanggal As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub tdb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tdb.CellContentClick


    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        If Tkode.Text = "" Or tanggal.Text = "" Or Tnama.Text = "" Or Talamat.Text = "" Or Tjenis.Text = "" Or Tharga.Text = "" Or Tjumlah.Text = "" Then
            MsgBox("Data Harus Terisi Semua")
        Else
            Call koneksi()
            Dim insert As String = "Insert into data values ('" & Tkode.Text & "','" & tanggal.Text & "','" & Tnama.Text & "','" & Talamat.Text & "','" & Tjenis.Text & "','" & Tharga.Text & "','" & Tjumlah.Text & "','" & TsubH.Text & "','" & Tpotongan.Text & "','" & TsubG.Text & "','" & Tpajak.Text & "','" & Tgrand.Text & "')"
            cmd = New OleDbCommand(insert, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            Call Auto()
            Call Clear()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Auto()
        Call Clear()
    End Sub

    Sub Auto()
        Call koneksi()
        da = New OleDbDataAdapter("Select * from data", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data")
        tdb.DataSource = (ds.Tables("data"))
    End Sub

    Sub Clear()
        Tkode.Clear()
        Tnama.Clear()
        Talamat.Clear()
        Tharga.Clear()
        Tjumlah.Clear()
        TsubG.Clear()
        TsubH.Clear()
        Tpotongan.Clear()
        Tpajak.Clear()
        Tgrand.Clear()
    End Sub

    Private Sub Tjumlah_TextChanged(sender As Object, e As EventArgs) Handles Tjumlah.TextChanged

    End Sub

    Dim Xnama, Xalamat As String
    Private Sub Tjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tjenis.SelectedIndexChanged
        Select Case Tjenis.Text

            Case "CPU"
                Xharga = 6000000
            Case "MONITOR LG"
                Xharga = 800000
            Case "MOUSE"
                Xharga = 30000
            Case "KEYBOARD"
                Xharga = 70000
            Case "PRINTER"
                Xharga = 400000
        End Select

        Xkode = Val(Tkode.Text)
        Xtanggal = tanggal.Text
        Xnama = Tnama.Text
        Xalamat = Talamat.Text
        Tharga.Text = "Rp." & Format(Xharga, "##,##0.00")
    End Sub

    Private Sub Tjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tjumlah.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            Xjumlah = Val(Tjumlah.Text)
            Sharga = Xharga * Xjumlah
            TsubH.Text = "Rp." & Format(Sharga, "##,##0.00")
            Spotongan = 10 / 100 * Sharga
            Tpotongan.Text = "Rp." & Format(Spotongan, "##,##0.00")
            SSubG = Sharga - Spotongan
            TsubG.Text = "Rp." & Format(SSubG, "##,##0.00")
            Spajak = 10 / 100 * SSubG
            Tpajak.Text = "Rp." & Format(Spajak, "##,##0.00")
            Sgrand = SSubG + Spajak
            Tgrand.Text = "Rp." & Format(Sgrand, "##,##0.00")

        End If
    End Sub
End Class
