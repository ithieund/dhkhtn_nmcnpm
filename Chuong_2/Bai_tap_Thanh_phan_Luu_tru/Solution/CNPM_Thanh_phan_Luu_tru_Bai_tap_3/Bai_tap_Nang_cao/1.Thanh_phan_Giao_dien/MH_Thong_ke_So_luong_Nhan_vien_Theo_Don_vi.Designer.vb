<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi
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
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.TH_Luoi_Du_lieu = New System.Windows.Forms.DataGridView()
        CType(Me.TH_Luoi_Du_lieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.Navy
        Me.Th_Tieu_de.Location = New System.Drawing.Point(57, 9)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(538, 31)
        Me.Th_Tieu_de.TabIndex = 32
        Me.Th_Tieu_de.Text = "Thống kê số lượng nhân viên theo đơn vị"
        '
        'TH_Luoi_Du_lieu
        '
        Me.TH_Luoi_Du_lieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TH_Luoi_Du_lieu.Location = New System.Drawing.Point(32, 72)
        Me.TH_Luoi_Du_lieu.Name = "TH_Luoi_Du_lieu"
        Me.TH_Luoi_Du_lieu.Size = New System.Drawing.Size(355, 196)
        Me.TH_Luoi_Du_lieu.TabIndex = 33
        '
        'MH_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 298)
        Me.Controls.Add(Me.TH_Luoi_Du_lieu)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Name = "MH_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi"
        Me.Text = "MH_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi"
        CType(Me.TH_Luoi_Du_lieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents TH_Luoi_Du_lieu As DataGridView
End Class
