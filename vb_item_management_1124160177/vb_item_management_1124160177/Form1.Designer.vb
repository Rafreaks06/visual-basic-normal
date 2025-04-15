<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleAlgorithmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecapitulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.lblqotd = New System.Windows.Forms.Label()
        Me.panelTitle.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.panelContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTitle
        '
        Me.panelTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTitle.Controls.Add(Me.Title)
        Me.panelTitle.Location = New System.Drawing.Point(2, 29)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(727, 78)
        Me.panelTitle.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Title.Location = New System.Drawing.Point(227, 22)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(241, 24)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Management Application"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageToolStripMenuItem, Me.EntityToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleAlgorithmToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SampleAlgorithmToolStripMenuItem
        '
        Me.SampleAlgorithmToolStripMenuItem.Name = "SampleAlgorithmToolStripMenuItem"
        Me.SampleAlgorithmToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SampleAlgorithmToolStripMenuItem.Text = "Sample Algorithm"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem, Me.PositionToolStripMenuItem, Me.RecapitulationToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PositionToolStripMenuItem.Text = "Position"
        '
        'RecapitulationToolStripMenuItem
        '
        Me.RecapitulationToolStripMenuItem.Name = "RecapitulationToolStripMenuItem"
        Me.RecapitulationToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RecapitulationToolStripMenuItem.Text = "Recapitulation"
        '
        'EntityToolStripMenuItem
        '
        Me.EntityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendorToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.EntityToolStripMenuItem.Name = "EntityToolStripMenuItem"
        Me.EntityToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EntityToolStripMenuItem.Text = "Entity"
        '
        'VendorToolStripMenuItem
        '
        Me.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        Me.VendorToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.VendorToolStripMenuItem.Text = "Vendor"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'panelContent
        '
        Me.panelContent.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelContent.Controls.Add(Me.lblqotd)
        Me.panelContent.Location = New System.Drawing.Point(2, 111)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(727, 415)
        Me.panelContent.TabIndex = 3
        '
        'lblqotd
        '
        Me.lblqotd.AutoSize = True
        Me.lblqotd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblqotd.Location = New System.Drawing.Point(22, 19)
        Me.lblqotd.Name = "lblqotd"
        Me.lblqotd.Size = New System.Drawing.Size(39, 13)
        Me.lblqotd.TabIndex = 0
        Me.lblqotd.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 527)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelContent.ResumeLayout(False)
        Me.panelContent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelTitle As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SampleAlgorithmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecapitulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelContent As Panel
    Friend WithEvents VendorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Title As Label
    Friend WithEvents lblqotd As Label
End Class
