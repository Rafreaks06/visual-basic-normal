Imports Npgsql

Public Class VendorDao
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String

    Public Function loadAlldata() As DataTable
        query = "select * from Vendors v where v.isdelete is null" 'query database'
        npgsqlConn = Dbconnnection.openconnection 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn) 'eksekusi query berdasarkan koneksi'
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim table As New DataTable() 'definisi tabel penampungan'
        adp.Fill(table) 'data ditampung di table'

        Return table

    End Function
    Public Function insert(code As String, name As String, address As String,
                           phone As String, email As String, pic As String) As Integer 'memberikan value'
        npgsqlConn = Dbconnnection.openconnection()
        query = "insert into vendors (code, name, address, phone, email, pic_name)"
        query = query & " Values (@code, @name, @address, @phone, @email, @pic)" 'query insert'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@phone", phone)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@pic", pic)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function
    Public Function update(code As String, name As String, address As String, phone As String,
                           email As String, pic As String, id As Integer) As Integer 'memberikan value'
        query = "UPDATE vendors set  code = @code, name = @name, address = @address, phone = @phone, email = @email, pic_name = @pic "
        query = query & "WHERE id = @id"
        npgsqlConn = Dbconnnection.openconnection()   'query insert'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@phone", phone)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@pic", pic)
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result
    End Function
    Public Function delete(id As Integer) As Integer

        query = "UPDATE vendors set isdelete = @flagYes "
        query = query & "where id = @id"
        npgsqlConn = Dbconnnection.openconnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@flagYes", 1)
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        Dbconnnection.CloseConnection()
        Return result


    End Function
End Class
