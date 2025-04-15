<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Position
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.infoGridView = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblMaster = New System.Windows.Forms.Label()
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'infoGridView
        '
        Me.infoGridView.AllowUserToAddRows = False
        Me.infoGridView.AllowUserToDeleteRows = False
        Me.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.infoGridView.Location = New System.Drawing.Point(15, 67)
        Me.infoGridView.Name = "infoGridView"
        Me.infoGridView.ReadOnly = True
        Me.infoGridView.Size = New System.Drawing.Size(701, 324)
        Me.infoGridView.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnAdd.Location = New System.Drawing.Point(613, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 33)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblMaster
        '
        Me.lblMaster.AutoSize = True
        Me.lblMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblMaster.Location = New System.Drawing.Point(10, 19)
        Me.lblMaster.Name = "lblMaster"
        Me.lblMaster.Size = New System.Drawing.Size(146, 25)
        Me.lblMaster.TabIndex = 3
        Me.lblMaster.Text = "Master Position"
        '
        'Position
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.infoGridView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblMaster)
        Me.Name = "Position"
        Me.Size = New System.Drawing.Size(727, 407)
        CType(Me.infoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents infoGridView As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblMaster As Label
End Class
