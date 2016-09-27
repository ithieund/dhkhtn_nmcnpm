<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Them_moi_Nhan_vien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Th_Muc_luong = New System.Windows.Forms.MaskedTextBox()
        Me.Th_Danh_sach_Don_vi = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Dia_chi = New System.Windows.Forms.TextBox()
        Me.Th_Ngay_sinh = New System.Windows.Forms.DateTimePicker()
        Me.Th_Cmnd = New System.Windows.Forms.TextBox()
        Me.Th_Gioi_tinh = New System.Windows.Forms.CheckBox()
        Me.Th_Ho_ten = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XL_Dong_y = New System.Windows.Forms.Button()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(213, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm nhân viên mới"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Th_Muc_luong)
        Me.Panel1.Controls.Add(Me.Th_Danh_sach_Don_vi)
        Me.Panel1.Controls.Add(Me.Th_Dia_chi)
        Me.Panel1.Controls.Add(Me.Th_Ngay_sinh)
        Me.Panel1.Controls.Add(Me.Th_Cmnd)
        Me.Panel1.Controls.Add(Me.Th_Gioi_tinh)
        Me.Panel1.Controls.Add(Me.Th_Ho_ten)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(24, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 342)
        Me.Panel1.TabIndex = 1
        '
        'Th_Muc_luong
        '
        Me.Th_Muc_luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Muc_luong.Location = New System.Drawing.Point(413, 108)
        Me.Th_Muc_luong.Mask = "0000009"
        Me.Th_Muc_luong.Name = "Th_Muc_luong"
        Me.Th_Muc_luong.Size = New System.Drawing.Size(191, 26)
        Me.Th_Muc_luong.TabIndex = 11
        '
        'Th_Danh_sach_Don_vi
        '
        Me.Th_Danh_sach_Don_vi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Th_Danh_sach_Don_vi.Location = New System.Drawing.Point(123, 258)
        Me.Th_Danh_sach_Don_vi.Name = "Th_Danh_sach_Don_vi"
        Me.Th_Danh_sach_Don_vi.Size = New System.Drawing.Size(481, 65)
        Me.Th_Danh_sach_Don_vi.TabIndex = 13
        '
        'Th_Dia_chi
        '
        Me.Th_Dia_chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Dia_chi.Location = New System.Drawing.Point(123, 152)
        Me.Th_Dia_chi.Multiline = True
        Me.Th_Dia_chi.Name = "Th_Dia_chi"
        Me.Th_Dia_chi.Size = New System.Drawing.Size(481, 84)
        Me.Th_Dia_chi.TabIndex = 12
        '
        'Th_Ngay_sinh
        '
        Me.Th_Ngay_sinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Th_Ngay_sinh.Location = New System.Drawing.Point(123, 106)
        Me.Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Me.Th_Ngay_sinh.Size = New System.Drawing.Size(141, 26)
        Me.Th_Ngay_sinh.TabIndex = 10
        '
        'Th_Cmnd
        '
        Me.Th_Cmnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Cmnd.Location = New System.Drawing.Point(413, 64)
        Me.Th_Cmnd.Name = "Th_Cmnd"
        Me.Th_Cmnd.Size = New System.Drawing.Size(191, 26)
        Me.Th_Cmnd.TabIndex = 9
        '
        'Th_Gioi_tinh
        '
        Me.Th_Gioi_tinh.AutoSize = True
        Me.Th_Gioi_tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Gioi_tinh.Location = New System.Drawing.Point(123, 71)
        Me.Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Me.Th_Gioi_tinh.Size = New System.Drawing.Size(15, 14)
        Me.Th_Gioi_tinh.TabIndex = 8
        Me.Th_Gioi_tinh.UseVisualStyleBackColor = True
        '
        'Th_Ho_ten
        '
        Me.Th_Ho_ten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Ho_ten.Location = New System.Drawing.Point(123, 21)
        Me.Th_Ho_ten.Name = "Th_Ho_ten"
        Me.Th_Ho_ten.Size = New System.Drawing.Size(385, 26)
        Me.Th_Ho_ten.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(301, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Mức lương"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(301, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "CMND"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Đơn vị"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Địa chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ngày sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Giới tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ tên"
        '
        'XL_Dong_y
        '
        Me.XL_Dong_y.BackColor = System.Drawing.Color.Red
        Me.XL_Dong_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XL_Dong_y.ForeColor = System.Drawing.Color.White
        Me.XL_Dong_y.Location = New System.Drawing.Point(263, 425)
        Me.XL_Dong_y.Name = "XL_Dong_y"
        Me.XL_Dong_y.Size = New System.Drawing.Size(157, 53)
        Me.XL_Dong_y.TabIndex = 2
        Me.XL_Dong_y.Text = "Đồng ý"
        Me.XL_Dong_y.UseVisualStyleBackColor = False
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.ForeColor = System.Drawing.Color.Navy
        Me.Th_Thong_bao.Location = New System.Drawing.Point(675, 72)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(0, 24)
        Me.Th_Thong_bao.TabIndex = 3
        '
        'MH_Them_moi_Nhan_vien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 494)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.XL_Dong_y)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Them_moi_Nhan_vien"
        Me.Text = "MH_Them_moi_Nhan_vien"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Th_Ngay_sinh As DateTimePicker
    Friend WithEvents Th_Cmnd As TextBox
    Friend WithEvents Th_Gioi_tinh As CheckBox
    Friend WithEvents Th_Ho_ten As TextBox
    Friend WithEvents Th_Dia_chi As TextBox
    Friend WithEvents Th_Danh_sach_Don_vi As FlowLayoutPanel
    Friend WithEvents Th_Muc_luong As MaskedTextBox
    Friend WithEvents XL_Dong_y As Button
    Friend WithEvents Th_Thong_bao As Label
End Class
