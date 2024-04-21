<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fkaryawan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.tnik = New System.Windows.Forms.TextBox()
        Me.btutup = New System.Windows.Forms.Button()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.tnohp = New System.Windows.Forms.TextBox()
        Me.talamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tasal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bnext = New System.Windows.Forms.Button()
        Me.bprev = New System.Windows.Forms.Button()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bsimpan)
        Me.GroupBox1.Controls.Add(Me.tnik)
        Me.GroupBox1.Controls.Add(Me.btutup)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.tnohp)
        Me.GroupBox1.Controls.Add(Me.talamat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtplahir)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbjenis)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tasal)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1333, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'bsimpan
        '
        Me.bsimpan.Location = New System.Drawing.Point(133, 128)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(135, 42)
        Me.bsimpan.TabIndex = 7
        Me.bsimpan.Text = "Simpan"
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'tnik
        '
        Me.tnik.Location = New System.Drawing.Point(133, 23)
        Me.tnik.Name = "tnik"
        Me.tnik.Size = New System.Drawing.Size(193, 30)
        Me.tnik.TabIndex = 0
        '
        'btutup
        '
        Me.btutup.Location = New System.Drawing.Point(274, 129)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(135, 42)
        Me.btutup.TabIndex = 8
        Me.btutup.Text = "Tutup"
        Me.btutup.UseVisualStyleBackColor = True
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(133, 58)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(423, 30)
        Me.tnama.TabIndex = 1
        '
        'tnohp
        '
        Me.tnohp.Location = New System.Drawing.Point(726, 129)
        Me.tnohp.Name = "tnohp"
        Me.tnohp.Size = New System.Drawing.Size(272, 30)
        Me.tnohp.TabIndex = 6
        '
        'talamat
        '
        Me.talamat.Location = New System.Drawing.Point(726, 94)
        Me.talamat.Name = "talamat"
        Me.talamat.Size = New System.Drawing.Size(423, 30)
        Me.talamat.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Asal"
        '
        'dtplahir
        '
        Me.dtplahir.CustomFormat = "yyyy-MM-dd"
        Me.dtplahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtplahir.Location = New System.Drawing.Point(726, 23)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(272, 30)
        Me.dtplahir.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(611, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "No Hp"
        '
        'cbjenis
        '
        Me.cbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbjenis.Location = New System.Drawing.Point(726, 58)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(272, 31)
        Me.cbjenis.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(611, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(611, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(611, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tgl Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nik"
        '
        'tasal
        '
        Me.tasal.Location = New System.Drawing.Point(133, 94)
        Me.tasal.Name = "tasal"
        Me.tasal.Size = New System.Drawing.Size(276, 30)
        Me.tasal.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bnext)
        Me.GroupBox2.Controls.Add(Me.bprev)
        Me.GroupBox2.Controls.Add(Me.tcari)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1333, 322)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'bnext
        '
        Me.bnext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnext.Location = New System.Drawing.Point(1281, 19)
        Me.bnext.Name = "bnext"
        Me.bnext.Size = New System.Drawing.Size(46, 30)
        Me.bnext.TabIndex = 3
        Me.bnext.Text = ">"
        Me.bnext.UseVisualStyleBackColor = True
        '
        'bprev
        '
        Me.bprev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bprev.Location = New System.Drawing.Point(1229, 19)
        Me.bprev.Name = "bprev"
        Me.bprev.Size = New System.Drawing.Size(46, 30)
        Me.bprev.TabIndex = 2
        Me.bprev.Text = "<"
        Me.bprev.UseVisualStyleBackColor = True
        '
        'tcari
        '
        Me.tcari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcari.Location = New System.Drawing.Point(6, 19)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(1217, 30)
        Me.tcari.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(6, 55)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1321, 261)
        Me.dgv.TabIndex = 1
        '
        'fkaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 511)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "fkaryawan"
        Me.Text = "DATA KARYAWAN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bsimpan As Button
    Friend WithEvents tnik As TextBox
    Friend WithEvents btutup As Button
    Friend WithEvents tnama As TextBox
    Friend WithEvents tnohp As TextBox
    Friend WithEvents talamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtplahir As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cbjenis As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tasal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents tcari As TextBox
    Friend WithEvents bnext As Button
    Friend WithEvents bprev As Button
End Class
