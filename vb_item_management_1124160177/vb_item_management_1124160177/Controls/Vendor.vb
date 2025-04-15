Public Class Vendor

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        vendorForm.Show()
    End Sub

    Public Sub loadData()
        Try
            Dim VendorDao As New VendorDao() 'mengambi database'
            Dim table As DataTable = VendorDao.loadAlldata() 'memuat semua data'
            infoGridView.DataSource = table 'tempel ke design'
            infoGridView.Columns("id").Visible = False 'umpetin id'
            infoGridView.Columns("isdelete").Visible = False 'umpetin id'

        Catch ex As Exception
            MessageBox.Show("Gagal Mengambil data:" & ex.Message)
        End Try
    End Sub


    Private Sub Vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub infoGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles infoGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = infoGridView.Rows(e.RowIndex)
            Dim vendorform As New vendorForm()
            vendorform.txtAddress.Text = row.Cells("address").Value.ToString()
            vendorform.txtCode.Text = row.Cells("code").Value.ToString()
            vendorform.txtEmail.Text = row.Cells("email").Value.ToString()
            vendorform.txtId.Text = row.Cells("id").Value.ToString()
            vendorform.txtName.Text = row.Cells("Name").Value.ToString()
            vendorform.txtPhone.Text = row.Cells("Phone").Value.ToString()
            vendorform.txtPerson.Text = row.Cells("pic_name").Value.ToString()
            vendorform.Show()

        End If
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        loadData()
    End Sub
End Class
