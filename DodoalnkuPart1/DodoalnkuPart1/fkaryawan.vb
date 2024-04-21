Imports System.Data.Odbc
Public Class fkaryawan
    Dim startrecord As Integer = 0
    Dim totalrecordperhalaman = 5
    Sub tampil(ByVal sql As String)
        conn.Close()
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = sql
        mda.SelectCommand = eksekusi
        ds.Tables.Clear()
        mda.Fill(ds, startrecord, totalrecordperhalaman, "data")
        dgv.DataSource = (ds.Tables("data"))
        conn.Close()
        'Dim STR As String = "select * from tkaryawan where nama like '%" & tcari.Text & "%'"
        'Dim da As OdbcDataAdapter
        'da = New OdbcDataAdapter(STR, conn)
        'Dim tbl As New DataTable
        'da.Fill(tbl)
        'dgv.DataSource = tbl
    End Sub
    Sub aturgrid()
        dgv.Columns(0).HeaderText = "NIK"
        dgv.Columns(1).HeaderText = "NAMA KARYAWAN"
        dgv.Columns(2).HeaderText = "ASAL"
        dgv.Columns(3).HeaderText = "TGL LAHIR"
        dgv.Columns(4).HeaderText = "JK"
        dgv.Columns(5).HeaderText = "ALAMAT"
        dgv.Columns(6).HeaderText = "NO HP"

        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 275
        dgv.Columns(2).Width = 90
        dgv.Columns(3).Width = 200
        dgv.Columns(4).Width = 70
        dgv.Columns(5).Width = 300
        dgv.Columns(6).Width = 150

        dgv.RowHeadersVisible = False
        dgv.GridColor = Color.Blue
        dgv.DefaultCellStyle.ForeColor = Color.DarkRed
        dgv.DefaultCellStyle.BackColor = Color.SkyBlue
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        dgv.GridColor = Color.DarkRed
    End Sub

    Private Function getrowscount() As Integer
        Call tampil("select * from tkaryawan ")
        ds = New DataSet
        mda.Fill(ds)
        Return ds.Tables(0).Rows.Count
    End Function

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Sub cekdata()
        Dim endofrecord As Integer = getrowscount() / totalrecordperhalaman
        If startrecord = 0 Then
            bprev.Enabled = False
        ElseIf startrecord / totalrecordperhalaman + 1 = endofrecord Then
            bnext.Enabled = False
        Else
            bprev.Enabled = True
            bnext.Enabled = True
        End If
    End Sub

    Sub bersih()
        tnik.Text = ""
        tnama.Text = ""
        tasal.Text = ""
        talamat.Text = ""
        tnohp.Text = ""
        bsimpan.Text = "Simpan"
        'tnik.Enabled = True
    End Sub

    Private Sub fkaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
        dgv.Columns.Clear()
        Call tampil("select * from tkaryawan")
        Call aturgrid()
        Call tombol()
        Call cekdata()
        tnik.Text = autonik()
    End Sub

    Sub tombol()
        Dim bedit As New DataGridViewButtonColumn
        Dim bhapus As New DataGridViewButtonColumn

        bedit.Name = "bedit"
        bedit.HeaderText = ""
        bedit.FlatStyle = FlatStyle.Popup
        bedit.DefaultCellStyle.ForeColor = Color.Green
        bedit.Text = "Edit"
        bedit.Width = "50"
        bedit.UseColumnTextForButtonValue = True
        dgv.Columns.AddRange(bedit)

        bhapus.Name = "bhapus"
        bhapus.HeaderText = ""
        bhapus.FlatStyle = FlatStyle.Popup
        bhapus.DefaultCellStyle.ForeColor = Color.Green
        bhapus.Text = "Hapus"
        bhapus.Width = "60"
        bhapus.UseColumnTextForButtonValue = True
        dgv.Columns.AddRange(bhapus)
    End Sub

    Private Sub fkaryawan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
        dgv.Columns.Clear()
        Call tampil("select * from tkaryawan")
        Call aturgrid()
        Call tombol()
        Call cekdata()
        tnik.Text = autonik()
    End Sub

    Private Sub tnik_KeyDown(sender As Object, e As KeyEventArgs) Handles tnik.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tnama.Focus()
        End Select
    End Sub

    Private Sub tnama_KeyDown(sender As Object, e As KeyEventArgs) Handles tnama.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tasal.Focus()
        End Select
    End Sub

    Private Sub tasal_KeyDown(sender As Object, e As KeyEventArgs) Handles tasal.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                dtplahir.Focus()
        End Select
    End Sub

    Private Sub dtplahir_KeyDown(sender As Object, e As KeyEventArgs) Handles dtplahir.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cbjenis.Focus()
        End Select
    End Sub

    Private Sub cbjenis_KeyDown(sender As Object, e As KeyEventArgs) Handles cbjenis.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                talamat.Focus()
        End Select
    End Sub

    Private Sub talamat_KeyDown(sender As Object, e As KeyEventArgs) Handles talamat.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tnohp.Focus()
        End Select
    End Sub

    Private Sub tnohp_KeyDown(sender As Object, e As KeyEventArgs) Handles tnohp.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                bsimpan_Click(e, AcceptButton)
        End Select
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        If tnik.Text = "" Or tnama.Text = "" Or tasal.Text = "" Or cbjenis.Text = "" Or talamat.Text = "" Or tnohp.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            Dim jk As String = ""
            If cbjenis.Text = "Laki-Laki" Then
                jk = "L"
            ElseIf cbjenis.Text = "Perempuan" Then
                jk = "P"
            End If

            cekkoneksi()
            Dim str As String = "SELECT * FROM tkaryawan WHERE NIK='" & tnik.Text & "'"
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi = New OdbcCommand(str)
            cek = eksekusi.ExecuteReader
            If cek.HasRows Then
                cek.Close()
                str = "update tkaryawan set nama='" & tnama.Text & "',asal='" &
tasal.Text & "',tgl='" & Format(Today, "yyyy-MM-dd") & ",jk='" &
jk & "',alamat='" & talamat.Text & "',nohp='" & tnohp.Text & "' where nik='" & tnik.Text & "'"
            Else
                cek.Close()
                str = "INSERT INTO tkaryawan VALUES ('" & tnik.Text & "','" & tnama.Text & "','" & tasal.Text & "','" & Format(Today, "yyyy-MM-dd") & "','" &
jk & "','" & talamat.Text & "','" & tnohp.Text & "')"
            End If
            eksekusi = New OdbcCommand(str)
            eksekusi.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan")
            dgv.Columns.Clear()
            Call tampil("select * from tkaryawan")
            Call aturgrid()
            Call bersih()
            Call tombol()
            tnik.Text = autonik()

        End If
    End Sub

    Private Sub tnik_TextChanged(sender As Object, e As EventArgs) Handles tnik.TextChanged
        conn.Close()
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "SELECT * FROM TKARYAWAN WHERE NIK='" & tnik.Text & "'"
        cek = eksekusi.ExecuteReader

        If cek.HasRows Then
            cek.Read()
            tnama.Text = cek.Item("NAMA").ToString.Trim
            tasal.Text = cek.Item("ASAL").ToString.Trim
            dtplahir.Value = cek.Item("TGL")
            If cek.Item("JK") = "L" Then
                cbjenis.Text = "Laki=Laki"
            ElseIf cek.Item("JK") = "P" Then
                cbjenis.Text = "Perempuan"
            End If
            talamat.Text = cek.Item("ALAMAT").ToString.Trim
            tnohp.Text = cek.Item("NOHP").ToString.Trim
            'bsimpan.Text = "Update"
            'tnik.Enabled = False
            cek.Close()
        Else
            tnama.Clear()
            tasal.Clear()
            talamat.Clear()
            tnohp.Clear()
            cek.Close()
        End If
        cek.Close()
    End Sub

    Private Sub bprev_Click(sender As Object, e As EventArgs) Handles bprev.Click
        dgv.Columns.Clear()
        startrecord = startrecord - totalrecordperhalaman
        Call tampil("select * from tkaryawan")
        Call cekdata()
        Call aturgrid()
        Call tombol()
    End Sub

    Private Sub bnext_Click(sender As Object, e As EventArgs) Handles bnext.Click
        dgv.Columns.Clear()
        startrecord = startrecord + totalrecordperhalaman
        Call tampil("select * from tkaryawan")
        Call cekdata()
        Call aturgrid()
        Call tombol()
    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged
        dgv.Columns.Clear()
        Call tampil("select * from tkaryawan where nik like '%" & tcari.Text & "%' or nama like '%" & tcari.Text & "%'")
        Call aturgrid()
        Call tombol()
    End Sub

    Private Function autonik() As String
        conn.Close()
        cekkoneksi()
        Dim nik_awal As String = Format(Date.Now, "yyyyMM")
        Dim nik_akhir As String = ""
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "Select max(NIK) As NIK from tkaryawan"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If Not IsDBNull(cek.Item("NIK")) Then
            Dim NIK As Integer = Mid(cek.Item("NIK"), 7, 6) + 1
            cek.Close()
            autonik = nik_awal & Format(NIK, "000000")
        Else
            cek.Close()
            autonik = nik_awal & Format(1, "000000")
        End If
        cek.Close()
    End Function

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As String
        Dim kode As String
        i = dgv.CurrentRow.Index
        kode = dgv.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 7 Then
            tnik.Text = kode
            tnik.Focus()
        End If

        If e.ColumnIndex = 8 Then
            Dim x As Byte
            i = dgv.CurrentRow.Index
            x = MsgBox("Hapus data karyawan dengan kode " & kode & "?", MsgBoxStyle.Critical + vbYesNo, "Konfirmasi")
            If x = vbYes Then
                conn.Close()
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "delete from tkaryawan where nik='" & kode & "'"
                eksekusi.ExecuteNonQuery()

                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Informasi")
                dgv.Columns.Clear()
                Call tampil("select * from tkaryawan")
                Call aturgrid()
                Call tombol()
            End If
        End If
    End Sub
End Class