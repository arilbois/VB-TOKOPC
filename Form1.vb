Public Class Form1
    Dim Xkode, Xtanggal, Xharga, Sharga, Xjumlah, Xsubh, Spotongan, SSubG, Spajak, Sgrand As Double

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Xtanggal = Val(Ttanggal.Text)
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
