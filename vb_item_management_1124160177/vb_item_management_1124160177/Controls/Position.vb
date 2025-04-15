Public Class Position
    Private Sub Position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Public Sub loadData()
        Try
            Dim PosDao As New PosDao() 'mengambi database'
            Dim table As DataTable = PosDao.loadAlldata() 'memuat semua data'
            infoGridView.DataSource = table 'tempel ke design'
            infoGridView.Columns("id").Visible = False 'umpetin id'
        Catch ex As Exception
            MessageBox.Show("Gagal Mengambil data:" & ex.Message)
        End Try
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        postForm_.Show()
    End Sub

    Private Sub infoGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellContentClick

    End Sub
End Class
