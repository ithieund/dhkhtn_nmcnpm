<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Tra_cuu_Nhan_vien_Theo_1_Ngoai_ngu
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
        Me.Th_Danh_sach_Nhan_vien = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Danh_sach_Ngoai_ngu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.AutoScroll = True
        Me.Th_Danh_sach_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(20, 126)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(971, 513)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 5
        '
        'Th_Danh_sach_Ngoai_ngu
        '
        Me.Th_Danh_sach_Ngoai_ngu.Location = New System.Drawing.Point(20, 63)
        Me.Th_Danh_sach_Ngoai_ngu.Name = "Th_Danh_sach_Ngoai_ngu"
        Me.Th_Danh_sach_Ngoai_ngu.Size = New System.Drawing.Size(653, 47)
        Me.Th_Danh_sach_Ngoai_ngu.TabIndex = 4
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.Navy
        Me.Th_Tieu_de.Location = New System.Drawing.Point(367, 15)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(471, 31)
        Me.Th_Tieu_de.TabIndex = 3
        Me.Th_Tieu_de.Text = "Tra cứu nhân viên theo 1 ngoại ngữ"
        '
        'MH_Tra_cuu_Nhan_vien_Theo_1_Ngoai_ngu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 655)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Th_Danh_sach_Ngoai_ngu)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Name = "MH_Tra_cuu_Nhan_vien_Theo_1_Ngoai_ngu"
        Me.Text = "MH_Tra_cuu_Nhan_vien_Theo_1_Ngoai_ngu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Th_Danh_sach_Ngoai_ngu As FlowLayoutPanel
    Friend WithEvents Th_Tieu_de As Label
End Class
