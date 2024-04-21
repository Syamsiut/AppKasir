Public Class flogin
    Private Sub btmasuk_Click(sender As Object, e As EventArgs) Handles btmasuk.Click
        If tuser.Text = "" Then
            MsgBox("User kosong...")
        ElseIf tpass.Text = "" Then
            MsgBox("Password Kosong...")
        Else
            If tuser.Text = "masgie" And tpass.Text = "masgie" Then
                Dim FR As New fmenu
                FR.Show()
                Me.Hide()
            Else
                MsgBox("Passsword Salah!")
            End If
        End If
    End Sub

    Private Sub btkeluar_Click(sender As Object, e As EventArgs) Handles btkeluar.Click
        End
    End Sub

    Private Sub tuser_KeyDown(sender As Object, e As KeyEventArgs) Handles tuser.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tpass.Focus()
        End Select
    End Sub

    Private Sub tpass_KeyDown(sender As Object, e As KeyEventArgs) Handles tpass.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btmasuk_Click(e, AcceptButton)
        End Select
    End Sub

    Private Sub flogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        tpass.UseSystemPasswordChar = True
        'If My.Settings.dsn = "" Or My.Settings.uid = "" Or My.Settings.server = "" Or My.Settings.database = "" Or My.Settings.port = "" Then
        '    MsgBox("Data Belum di setting..", MsgBoxStyle.Information, "Informasi")
        '    Dim FR As New fkoneksi
        '    FR.ShowDialog()
        'Else
        '    KONEKAN()
        'End If
        cekkoneksi()
    End Sub
End Class
