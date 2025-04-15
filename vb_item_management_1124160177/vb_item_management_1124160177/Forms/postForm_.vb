

Public Class postForm_
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim Posdao As New PosDao

            Dim code As String = txtCode.Text
            Dim name As String = txtName.Text
            Dim Description As String = txtDesc.Text
            Dim Capacity As Double = txtMax.Text
            Dim Filled As Double = txtField.Text
            Dim updated_on As DateTime = DateTime.Now

            Posdao.insert(code, name, Description, Capacity, Filled, updated_on)
            MessageBox.Show("Data Berhasil Ditambahkan")
        Catch x As Exception
            MessageBox.Show("Failed to insert:" & x.Message)
        End Try
    End Sub
End Class