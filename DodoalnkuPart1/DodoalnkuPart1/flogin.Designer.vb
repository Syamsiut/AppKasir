<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flogin
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.btmasuk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(42, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Login........"
        '
        'tpass
        '
        Me.tpass.Location = New System.Drawing.Point(125, 140)
        Me.tpass.Name = "tpass"
        Me.tpass.Size = New System.Drawing.Size(262, 30)
        Me.tpass.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'tuser
        '
        Me.tuser.Location = New System.Drawing.Point(125, 104)
        Me.tuser.Name = "tuser"
        Me.tuser.Size = New System.Drawing.Size(262, 30)
        Me.tuser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(259, 176)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(128, 40)
        Me.btkeluar.TabIndex = 3
        Me.btkeluar.Text = "Keluar"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btmasuk
        '
        Me.btmasuk.Location = New System.Drawing.Point(125, 176)
        Me.btmasuk.Name = "btmasuk"
        Me.btmasuk.Size = New System.Drawing.Size(128, 40)
        Me.btmasuk.TabIndex = 2
        Me.btmasuk.Text = "Masuk"
        Me.btmasuk.UseVisualStyleBackColor = True
        '
        'flogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(428, 244)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tuser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btmasuk)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "flogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents tpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tuser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btkeluar As Button
    Friend WithEvents btmasuk As Button
End Class
