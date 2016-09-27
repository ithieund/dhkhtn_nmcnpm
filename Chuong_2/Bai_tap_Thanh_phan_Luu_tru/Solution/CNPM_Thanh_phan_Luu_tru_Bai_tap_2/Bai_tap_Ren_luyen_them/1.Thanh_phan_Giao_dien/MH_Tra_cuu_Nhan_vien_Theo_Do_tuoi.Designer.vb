<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi
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
        Me.TH_Do_tuoi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Th_Danh_sach_Nhan_vien = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TH_Do_tuoi
        '
        Me.TH_Do_tuoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TH_Do_tuoi.Location = New System.Drawing.Point(117, 80)
        Me.TH_Do_tuoi.Name = "TH_Do_tuoi"
        Me.TH_Do_tuoi.Size = New System.Drawing.Size(309, 26)
        Me.TH_Do_tuoi.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Độ tuổi"
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.AutoScroll = True
        Me.Th_Danh_sach_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(19, 126)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(971, 513)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 9
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.Navy
        Me.Th_Tieu_de.Location = New System.Drawing.Point(366, 15)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(408, 31)
        Me.Th_Tieu_de.TabIndex = 8
        Me.Th_Tieu_de.Text = "Tra cứu nhân viên theo độ tuổi"
        '
        'MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 655)
        Me.Controls.Add(Me.TH_Do_tuoi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Name = "MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi"
        Me.Text = "MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TH_Do_tuoi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Th_Tieu_de As Label
End Class
