Public Class fkoneksi

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        End
    End Sub

    Private Sub fkoneksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub bkonek_Click(sender As Object, e As EventArgs) Handles bkonek.Click
        If tdsn.Text = "" Or tserver.Text = "" Or tuid.Text = "" Or tdatabase.Text = "" Or tport.Text = "" Then
            MsgBox("Data Tidak Lengkap...", MsgBoxStyle.Information, "Informasi")
        Else
            With My.Settings
                .dsn = ""
                .server = ""
                .uid = ""
                .database = ""
                .port = ""
                .Save()
            End With
            cekkoneksi()
            Dim FR As New flogin
            FR.Show()
            Me.Close()
        End If
    End Sub
End Class