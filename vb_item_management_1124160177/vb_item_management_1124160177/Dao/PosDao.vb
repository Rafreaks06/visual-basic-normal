Imports Npgsql

Public Class PosDao
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String

    Public Function loadAlldata() As DataTable
        query = "select * from Positions p where p.isdelete is null" 'query database'
        npgsqlConn = Dbconnnection.openconnection 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn) 'eksekusi query berdasarkan koneksi'
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim table As New DataTable() 'definisi tabel penampungan'
        adp.Fill(table) 'data ditampung di table'
        Return table

    End Function
    Public Function insert(code As String, name As String, Description As String,
                           max_capacity As Double, Filled As Double, updated_on As DateTime) As Integer 'memberikan value'
        npgsqlConn = Dbconnnection.openconnection()
        query = "insert into positions (code, name, description, max_capacity, filled, updated_on)"
        query = query & " Values (@code, @name, @description, @max_capacity, @filled, @updated_on)" 'query insert'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@description", Description)
        cmd.Parameters.AddWithValue("@max_capacity", CDbl(max_capacity))
        cmd.Parameters.AddWithValue("@filled", CDbl(Filled))
        cmd.Parameters.AddWithValue("@updated_on", updated_on)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function
End Class
