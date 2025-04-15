Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblqotd.Text = "Manajemen yang baik bukan tentang mengendalikan semuanya, tapi tentang mengarahkan semuanya ke arah yang benar." & Environment.NewLine
        lblqotd.Text = lblqotd.Text & "Efisiensi adalah kunci. Waktu yang terorganisir dengan baik adalah kesuksesan yang direncanakan." & Environment.NewLine
        lblqotd.Text = lblqotd.Text & "Bukan tentang bekerja lebih keras, tapi bekerja lebih cerdas." & Environment.NewLine
        lblqotd.Text = lblqotd.Text & "Keputusan terbaik datang dari data yang dikelola dengan baik." & Environment.NewLine
        lblqotd.Text = lblqotd.Text & "Sebuah sistem yang baik membuat pekerjaan lebih ringan, bukan lebih rumit." & Environment.NewLine
        lblqotd.Text = lblqotd.Text & "Manajemen bukan hanya tentang mengelola tugas, tapi juga tentang mengelola harapan." & Environment.NewLine
        lblqotd.Text = lblqotd.Text & "Kualitas manajemen menentukan kualitas hasil." & Environment.NewLine & Environment.NewLine
        lblqotd.Text = lblqotd.Text & "Sigma-Man"

    End Sub

    Private Sub loadmenu(control As UserControl)
        panelContent.Controls.Clear()
        control.Dock = DockStyle.Fill
        panelContent.Controls.Add(control)
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        loadmenu(New Item)
    End Sub

    Private Sub PositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionToolStripMenuItem.Click
        loadmenu(New Position)
    End Sub

    Private Sub VendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorToolStripMenuItem.Click
        loadmenu(New Vendor)
    End Sub


End Class
