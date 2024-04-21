<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fkeluar
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
        Me.btutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btutup
        '
        Me.btutup.Location = New System.Drawing.Point(612, 353)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(108, 42)
        Me.btutup.TabIndex = 2
        Me.btutup.Text = "Tutup"
        Me.btutup.UseVisualStyleBackColor = True
        '
        'fkeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 749)
        Me.Controls.Add(Me.btutup)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "fkeluar"
        Me.Text = "fkeluar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btutup As Button
End Class
