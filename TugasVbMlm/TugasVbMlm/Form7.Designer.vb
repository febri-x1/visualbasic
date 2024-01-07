<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtKodeBrg = New System.Windows.Forms.TextBox
        Me.TxtNamaBrg = New System.Windows.Forms.TextBox
        Me.TxtSatuan = New System.Windows.Forms.TextBox
        Me.TxtHrgSatuan = New System.Windows.Forms.TextBox
        Me.TxtJumlah = New System.Windows.Forms.TextBox
        Me.TxtTotalHarga = New System.Windows.Forms.TextBox
        Me.BtnHitung = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnKeluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Satuan Berat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Harga"
        '
        'TxtKodeBrg
        '
        Me.TxtKodeBrg.Location = New System.Drawing.Point(99, 19)
        Me.TxtKodeBrg.Name = "TxtKodeBrg"
        Me.TxtKodeBrg.Size = New System.Drawing.Size(100, 20)
        Me.TxtKodeBrg.TabIndex = 6
        '
        'TxtNamaBrg
        '
        Me.TxtNamaBrg.Location = New System.Drawing.Point(99, 55)
        Me.TxtNamaBrg.Name = "TxtNamaBrg"
        Me.TxtNamaBrg.Size = New System.Drawing.Size(100, 20)
        Me.TxtNamaBrg.TabIndex = 7
        '
        'TxtSatuan
        '
        Me.TxtSatuan.Location = New System.Drawing.Point(99, 92)
        Me.TxtSatuan.Name = "TxtSatuan"
        Me.TxtSatuan.Size = New System.Drawing.Size(100, 20)
        Me.TxtSatuan.TabIndex = 8
        '
        'TxtHrgSatuan
        '
        Me.TxtHrgSatuan.Location = New System.Drawing.Point(99, 124)
        Me.TxtHrgSatuan.Name = "TxtHrgSatuan"
        Me.TxtHrgSatuan.Size = New System.Drawing.Size(100, 20)
        Me.TxtHrgSatuan.TabIndex = 9
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(99, 153)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TxtJumlah.TabIndex = 10
        '
        'TxtTotalHarga
        '
        Me.TxtTotalHarga.Location = New System.Drawing.Point(99, 189)
        Me.TxtTotalHarga.Name = "TxtTotalHarga"
        Me.TxtTotalHarga.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalHarga.TabIndex = 11
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(45, 242)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 23)
        Me.BtnHitung.TabIndex = 12
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(141, 242)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 13
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(233, 242)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 14
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 300)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtTotalHarga)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtHrgSatuan)
        Me.Controls.Add(Me.TxtSatuan)
        Me.Controls.Add(Me.TxtNamaBrg)
        Me.Controls.Add(Me.TxtKodeBrg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtKodeBrg As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaBrg As System.Windows.Forms.TextBox
    Friend WithEvents TxtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgSatuan As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
