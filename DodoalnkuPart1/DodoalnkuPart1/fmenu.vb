Public Class fmenu
    Private Sub fmenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        lbltgl.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        lbljam.Text = TimeOfDay
        Timer1.Enabled = True
    End Sub
    Sub bukaform(ByVal FR As Form)
        For Each F As Form In Me.MdiChildren
            If F.Name = FR.Name Then
                MsgBox("Form Sudah terbuka...")
                Exit Sub
            End If
        Next
        FR.MdiParent = Me
        FR.Show()
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        bukaform(fkaryawan)
    End Sub

    Private Sub DataBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem1.Click
        bukaform(fbarang)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim FR As New flogin
        FR.Show()
        Me.Close()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        bukaform(fmasuk)
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click
        bukaform(fkeluar)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltgl.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        lbljam.Text = TimeOfDay
    End Sub
End Class