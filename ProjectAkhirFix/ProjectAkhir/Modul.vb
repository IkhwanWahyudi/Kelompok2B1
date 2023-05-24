Imports MySql.Data.MySqlClient
Module Modul
    Public PPD As Integer = 0 'Poliklinik Penyakit Dalam
    Public PKK As Integer = 0 'Poliklinik Kebidanan dan Kandungan
    Public PA As Integer = 0 'Poliklinik Anak
    Public PBS As Integer = 0 'Poliklinik Bedah Saraf
    Public PTH As Integer = 0 'Poliklinik THT-KL
    Public PKJ As Integer = 0 'Poliklinik Kedokteran Jiwa
    Public PGM As Integer = 0 'Poliklinik Gigi dan Mulut

    Public Jam As String = ""
    Public IDPasien As Integer
    Public globalId As Integer

    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Sub Koneksi()
        Try
            Dim STR As String =
            "server=localhost;userid=root;password=;database=dbrumahsakitpa2"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module