Imports System.Data.Odbc
Module MdlKoneksi
    Dim connection As String = "Dsn=masgie;server=localhost;uid=root;database=dodolan1;port=3306"
    Public conn As New OdbcConnection(connection)
    Public eksekusi As New OdbcCommand
    Public cek As OdbcDataReader
    Public ds As New DataSet
    Public mda As New OdbcDataAdapter
    Public userlogin, namauser, level, namatoko, alamattoko, nohptoko, pimpinantoko As String

    Public Sub cekkoneksi()
        ' SERVER = NAMA SERVER;USER ID=USERID;PASSWORD=PASSWORD;DATABASE=DATABASE;'

        'Dim str As String = "dsn=" & My.Settings.dsn & ";server=" & My.Settings.server & ";uid=" & My.Settings.uid & ";database=" & My.Settings.database & ";port=" & My.Settings.port & ""
        'Dsn=" & My.Settings.Dsn & ";uid=" & My.Settings.uid & "; "
        Try
            conn = New OdbcConnection(connection)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke server terputus!", MsgBoxStyle.Information)
            End
            Exit Sub
            'With My.Settings
            '    .dsn = ""
            '    .server = ""
            '    .uid = ""
            '    .database = ""
            '    .port = ""
            '    .Save()
            'End With
        End Try
    End Sub

End Module
