<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Tra_cuu_Nhan_vien_Theo_Muc_luong
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Th_Ket_qua = New System.Windows.Forms.Label()
        Me.Th_Muc_luong_Min = New System.Windows.Forms.TextBox()
        Me.Th_Muc_luong_Max = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(31, 134)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(921, 353)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(315, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tra cứu nhân viên theo mức lương"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mức lương"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "-"
        '
        'Th_Ket_qua
        '
        Me.Th_Ket_qua.AutoSize = True
        Me.Th_Ket_qua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Ket_qua.ForeColor = System.Drawing.Color.Red
        Me.Th_Ket_qua.Location = New System.Drawing.Point(434, 92)
        Me.Th_Ket_qua.Name = "Th_Ket_qua"
        Me.Th_Ket_qua.Size = New System.Drawing.Size(0, 20)
        Me.Th_Ket_qua.TabIndex = 12
        Me.Th_Ket_qua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Th_Muc_luong_Min
        '
        Me.Th_Muc_luong_Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Muc_luong_Min.Location = New System.Drawing.Point(143, 88)
        Me.Th_Muc_luong_Min.Name = "Th_Muc_luong_Min"
        Me.Th_Muc_luong_Min.Size = New System.Drawing.Size(100, 26)
        Me.Th_Muc_luong_Min.TabIndex = 13
        '
        'Th_Muc_luong_Max
        '
        Me.Th_Muc_luong_Max.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Muc_luong_Max.Location = New System.Drawing.Point(267, 88)
        Me.Th_Muc_luong_Max.Name = "Th_Muc_luong_Max"
        Me.Th_Muc_luong_Max.Size = New System.Drawing.Size(100, 26)
        Me.Th_Muc_luong_Max.TabIndex = 14
        '
        'MH_Tra_cuu_Nhan_vien_Theo_Muc_luong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 516)
        Me.Controls.Add(Me.Th_Muc_luong_Max)
        Me.Controls.Add(Me.Th_Muc_luong_Min)
        Me.Controls.Add(Me.Th_Ket_qua)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Tra_cuu_Nhan_vien_Theo_Muc_luong"
        Me.Text = "MH_Tra_cuu_Nhan_vien_Theo_Muc_luong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Th_Ket_qua As Label
    Friend WithEvents Th_Muc_luong_Min As TextBox
    Friend WithEvents Th_Muc_luong_Max As TextBox
End Class
