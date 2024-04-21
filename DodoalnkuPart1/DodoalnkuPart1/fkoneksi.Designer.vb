<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fkoneksi
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
        Me.bkonek = New System.Windows.Forms.Button()
        Me.btutup = New System.Windows.Forms.Button()
        Me.tdsn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tserver = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdatabase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tuid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tport = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bkonek
        '
        Me.bkonek.Location = New System.Drawing.Point(102, 198)
        Me.bkonek.Name = "bkonek"
        Me.bkonek.Size = New System.Drawing.Size(171, 42)
        Me.bkonek.TabIndex = 5
        Me.bkonek.Text = "Konek"
        Me.bkonek.UseVisualStyleBackColor = True
        '
        'btutup
        '
        Me.btutup.Location = New System.Drawing.Point(283, 198)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(171, 42)
        Me.btutup.TabIndex = 6
        Me.btutup.Text = "Tutup"
        Me.btutup.UseVisualStyleBackColor = True
        '
        'tdsn
        '
        Me.tdsn.Location = New System.Drawing.Point(102, 18)
        Me.tdsn.Name = "tdsn"
        Me.tdsn.Size = New System.Drawing.Size(352, 30)
        Me.tdsn.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dsn"
        '
        'tserver
        '
        Me.tserver.Location = New System.Drawing.Point(102, 54)
        Me.tserver.Name = "tserver"
        Me.tserver.Size = New System.Drawing.Size(352, 30)
        Me.tserver.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Server"
        '
        'tdatabase
        '
        Me.tdatabase.Location = New System.Drawing.Point(102, 126)
        Me.tdatabase.Name = "tdatabase"
        Me.tdatabase.Size = New System.Drawing.Size(352, 30)
        Me.tdatabase.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Database"
        '
        'tuid
        '
        Me.tuid.Location = New System.Drawing.Point(102, 90)
        Me.tuid.Name = "tuid"
        Me.tuid.Size = New System.Drawing.Size(352, 30)
        Me.tuid.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Uid"
        '
        'tport
        '
        Me.tport.Location = New System.Drawing.Point(102, 162)
        Me.tport.Name = "tport"
        Me.tport.Size = New System.Drawing.Size(352, 30)
        Me.tport.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Port"
        '
        'fkoneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.tport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tdatabase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tuid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tserver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bkonek)
        Me.Controls.Add(Me.btutup)
        Me.Controls.Add(Me.tdsn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "fkoneksi"
        Me.Text = "fkoneksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bkonek As Button
    Friend WithEvents btutup As Button
    Friend WithEvents tdsn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tserver As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tdatabase As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tuid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tport As TextBox
    Friend WithEvents Label5 As Label
End Class
