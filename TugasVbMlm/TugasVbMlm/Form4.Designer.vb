<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form4
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
        Me.txtteks = New System.Windows.Forms.TextBox
        Me.txtjumlah = New System.Windows.Forms.TextBox
        Me.bproses = New System.Windows.Forms.Button
        Me.bclear = New System.Windows.Forms.Button
        Me.bkeluar = New System.Windows.Forms.Button
        Me.List1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuliskan Teks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Penambahan"
        '
        'txtteks
        '
        Me.txtteks.Location = New System.Drawing.Point(125, 27)
        Me.txtteks.Name = "txtteks"
        Me.txtteks.Size = New System.Drawing.Size(184, 20)
        Me.txtteks.TabIndex = 2
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(125, 67)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtjumlah.TabIndex = 3
        '
        'bproses
        '
        Me.bproses.Location = New System.Drawing.Point(140, 109)
        Me.bproses.Name = "bproses"
        Me.bproses.Size = New System.Drawing.Size(75, 23)
        Me.bproses.TabIndex = 4
        Me.bproses.Text = "Proses"
        Me.bproses.UseVisualStyleBackColor = True
        '
        'bclear
        '
        Me.bclear.Location = New System.Drawing.Point(80, 268)
        Me.bclear.Name = "bclear"
        Me.bclear.Size = New System.Drawing.Size(75, 23)
        Me.bclear.TabIndex = 5
        Me.bclear.Text = "Clear"
        Me.bclear.UseVisualStyleBackColor = True
        '
        'bkeluar
        '
        Me.bkeluar.Location = New System.Drawing.Point(222, 268)
        Me.bkeluar.Name = "bkeluar"
        Me.bkeluar.Size = New System.Drawing.Size(75, 23)
        Me.bkeluar.TabIndex = 6
        Me.bkeluar.Text = "Keluar"
        Me.bkeluar.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(45, 154)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(300, 95)
        Me.List1.TabIndex = 7
        '
        'form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 316)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.bkeluar)
        Me.Controls.Add(Me.bclear)
        Me.Controls.Add(Me.bproses)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtteks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtteks As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents bproses As System.Windows.Forms.Button
    Friend WithEvents bclear As System.Windows.Forms.Button
    Friend WithEvents bkeluar As System.Windows.Forms.Button
    Friend WithEvents List1 As System.Windows.Forms.ListBox
End Class
