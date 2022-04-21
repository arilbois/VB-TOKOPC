<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tkode = New System.Windows.Forms.TextBox()
        Me.Tnama = New System.Windows.Forms.TextBox()
        Me.Talamat = New System.Windows.Forms.TextBox()
        Me.Tharga = New System.Windows.Forms.TextBox()
        Me.Tjumlah = New System.Windows.Forms.TextBox()
        Me.TsubH = New System.Windows.Forms.TextBox()
        Me.Tpotongan = New System.Windows.Forms.TextBox()
        Me.TsubG = New System.Windows.Forms.TextBox()
        Me.Tpajak = New System.Windows.Forms.TextBox()
        Me.Tgrand = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Tjenis = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.tdb = New System.Windows.Forms.DataGridView()
        Me.insert = New System.Windows.Forms.Button()
        CType(Me.tdb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tkode
        '
        Me.Tkode.Location = New System.Drawing.Point(179, 182)
        Me.Tkode.Name = "Tkode"
        Me.Tkode.Size = New System.Drawing.Size(168, 20)
        Me.Tkode.TabIndex = 0
        '
        'Tnama
        '
        Me.Tnama.Location = New System.Drawing.Point(179, 234)
        Me.Tnama.Name = "Tnama"
        Me.Tnama.Size = New System.Drawing.Size(402, 20)
        Me.Tnama.TabIndex = 2
        '
        'Talamat
        '
        Me.Talamat.Location = New System.Drawing.Point(179, 260)
        Me.Talamat.Multiline = True
        Me.Talamat.Name = "Talamat"
        Me.Talamat.Size = New System.Drawing.Size(535, 111)
        Me.Talamat.TabIndex = 3
        '
        'Tharga
        '
        Me.Tharga.Location = New System.Drawing.Point(179, 420)
        Me.Tharga.Name = "Tharga"
        Me.Tharga.ReadOnly = True
        Me.Tharga.Size = New System.Drawing.Size(181, 20)
        Me.Tharga.TabIndex = 4
        '
        'Tjumlah
        '
        Me.Tjumlah.Location = New System.Drawing.Point(179, 456)
        Me.Tjumlah.Name = "Tjumlah"
        Me.Tjumlah.Size = New System.Drawing.Size(181, 20)
        Me.Tjumlah.TabIndex = 5
        '
        'TsubH
        '
        Me.TsubH.Location = New System.Drawing.Point(179, 492)
        Me.TsubH.Name = "TsubH"
        Me.TsubH.ReadOnly = True
        Me.TsubH.Size = New System.Drawing.Size(181, 20)
        Me.TsubH.TabIndex = 6
        '
        'Tpotongan
        '
        Me.Tpotongan.Location = New System.Drawing.Point(179, 532)
        Me.Tpotongan.Name = "Tpotongan"
        Me.Tpotongan.ReadOnly = True
        Me.Tpotongan.Size = New System.Drawing.Size(181, 20)
        Me.Tpotongan.TabIndex = 7
        '
        'TsubG
        '
        Me.TsubG.Location = New System.Drawing.Point(530, 456)
        Me.TsubG.Name = "TsubG"
        Me.TsubG.ReadOnly = True
        Me.TsubG.Size = New System.Drawing.Size(184, 20)
        Me.TsubG.TabIndex = 8
        '
        'Tpajak
        '
        Me.Tpajak.Location = New System.Drawing.Point(530, 492)
        Me.Tpajak.Name = "Tpajak"
        Me.Tpajak.ReadOnly = True
        Me.Tpajak.Size = New System.Drawing.Size(184, 20)
        Me.Tpajak.TabIndex = 9
        '
        'Tgrand
        '
        Me.Tgrand.Location = New System.Drawing.Point(530, 532)
        Me.Tgrand.Name = "Tgrand"
        Me.Tgrand.ReadOnly = True
        Me.Tgrand.Size = New System.Drawing.Size(184, 20)
        Me.Tgrand.TabIndex = 10
        '
        'Tjenis
        '
        Me.Tjenis.FormattingEnabled = True
        Me.Tjenis.Items.AddRange(New Object() {"CPU", "MONITOR LG", "MOUSE", "KEYBOARD", "PRINTER"})
        Me.Tjenis.Location = New System.Drawing.Point(179, 386)
        Me.Tjenis.Name = "Tjenis"
        Me.Tjenis.Size = New System.Drawing.Size(181, 21)
        Me.Tjenis.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "KODE TRANSAKSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TANGGAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "NAMA PELANGGAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ALAMAT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "JENIS BARANG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "HARGA SATUAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 463)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "JUMLAH"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 499)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "SUB HARGA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 539)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "POTONGAN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(376, 459)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "SUB GRAND"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(377, 498)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "PAJAK"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(376, 539)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "GRAND"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Bright", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(388, 36)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "PT. TEKNO TERMASUR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(436, 20)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "MENJUAL PERANGKAT KOMPUTER DAN PHERIPHERAL"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(462, 15)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Jl. Pelajar Perjuangan No. 45 Bandung Tlp. (022) 6754390. (022) 6754287"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(549, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 15)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "NPM : 20304005"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(549, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(179, 15)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "NAMA : SYAHRIL LUKMAN"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(563, 596)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(179, 211)
        Me.tanggal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(193, 20)
        Me.tanggal.TabIndex = 32
        '
        'tdb
        '
        Me.tdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tdb.Location = New System.Drawing.Point(735, 186)
        Me.tdb.Name = "tdb"
        Me.tdb.Size = New System.Drawing.Size(847, 437)
        Me.tdb.TabIndex = 33
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(461, 596)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(75, 23)
        Me.insert.TabIndex = 34
        Me.insert.Text = "Baru"
        Me.insert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1749, 681)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.tdb)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tjenis)
        Me.Controls.Add(Me.Tgrand)
        Me.Controls.Add(Me.Tpajak)
        Me.Controls.Add(Me.TsubG)
        Me.Controls.Add(Me.Tpotongan)
        Me.Controls.Add(Me.TsubH)
        Me.Controls.Add(Me.Tjumlah)
        Me.Controls.Add(Me.Tharga)
        Me.Controls.Add(Me.Talamat)
        Me.Controls.Add(Me.Tnama)
        Me.Controls.Add(Me.Tkode)
        Me.Name = "Form1"
        Me.Text = " Penjualan"
        CType(Me.tdb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tkode As TextBox
    Friend WithEvents Tnama As TextBox
    Friend WithEvents Talamat As TextBox
    Friend WithEvents Tharga As TextBox
    Friend WithEvents Tjumlah As TextBox
    Friend WithEvents TsubH As TextBox
    Friend WithEvents Tpotongan As TextBox
    Friend WithEvents TsubG As TextBox
    Friend WithEvents Tpajak As TextBox
    Friend WithEvents Tgrand As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Tjenis As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents tdb As DataGridView
    Friend WithEvents insert As Button
End Class
