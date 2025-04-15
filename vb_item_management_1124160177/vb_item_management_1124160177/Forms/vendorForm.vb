Imports System.Reflection
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class vendorForm


    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            Dim VendorDao As New VendorDao
            Dim code As String = txtCode.Text
            Dim name As String = txtName.Text
            Dim addres As String = txtAddress.Text
            Dim phone As String = txtPhone.Text
            Dim email As String = txtEmail.Text
            Dim pic As String = txtPerson.Text


            If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
                VendorDao.insert(code, name, addres, phone, email, pic)
                MessageBox.Show("Data Berhasil Ditambahkan")
            Else
                Dim id As String = txtId.Text
                VendorDao.update(code, name, addres, phone, email, pic, CInt(id))
                MessageBox.Show("Data Berhasil Diupdate")
            End If

        Catch x As Exception
            MessageBox.Show("Failed to insert:" & x.Message)
        End Try

    End Sub

    Private Sub VendorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
            btnDelete.Hide()
        Else
            btnDelete.Show()
        End If
    End Sub


    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim VendorDao As New VendorDao
        If String.IsNullOrEmpty(txtId.Text) Then 'kondisi jika id kosong' 
            MessageBox.Show("Data is not exist")
        Else
            Dim id As String = txtId.Text
            VendorDao.delete(CInt(id))
            MessageBox.Show("Data has been delete succesfully")
            Hide()
        End If
    End Sub




End Class