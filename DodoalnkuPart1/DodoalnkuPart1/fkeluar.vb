Public Class fkeluar
    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub fkeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class