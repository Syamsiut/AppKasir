Public Class fmasuk
    Private Sub fmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.CenterToScreen()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub
End Class