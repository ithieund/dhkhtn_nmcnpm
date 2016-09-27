<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Nhap_lieu_Phieu_cong_tac
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Th_Dong_y = New System.Windows.Forms.Button()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Th_Nhan_vien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Th_Ho_so = New System.Windows.Forms.Panel()
        Me.Th_Ngay_bat_dau = New System.Windows.Forms.DateTimePicker()
        Me.Th_So_ngay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Th_Tinh_thanh_pho = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Khung_Ho_so = New System.Windows.Forms.Panel()
        Me.Th_Chon_phieu_cong_tac = New System.Windows.Forms.Button()
        Me.Th_Ho_so.SuspendLayout()
        Me.Khung_Ho_so.SuspendLayout()
        Me.SuspendLayout()
        '
        'Th_Dong_y
        '
        Me.Th_Dong_y.BackColor = System.Drawing.Color.White
        Me.Th_Dong_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Dong_y.ForeColor = System.Drawing.Color.Red
        Me.Th_Dong_y.Location = New System.Drawing.Point(192, 205)
        Me.Th_Dong_y.Name = "Th_Dong_y"
        Me.Th_Dong_y.Size = New System.Drawing.Size(116, 45)
        Me.Th_Dong_y.TabIndex = 20
        Me.Th_Dong_y.Text = "Đồng ý"
        Me.Th_Dong_y.UseVisualStyleBackColor = False
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.White
        Me.Th_Tieu_de.Location = New System.Drawing.Point(268, 9)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(86, 29)
        Me.Th_Tieu_de.TabIndex = 26
        Me.Th_Tieu_de.Text = "Label1"
        '
        'Th_Nhan_vien
        '
        Me.Th_Nhan_vien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Nhan_vien.Location = New System.Drawing.Point(156, 20)
        Me.Th_Nhan_vien.Name = "Th_Nhan_vien"
        Me.Th_Nhan_vien.ReadOnly = True
        Me.Th_Nhan_vien.Size = New System.Drawing.Size(313, 26)
        Me.Th_Nhan_vien.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhân viên"
        '
        'Th_Ho_so
        '
        Me.Th_Ho_so.Controls.Add(Me.Th_Ngay_bat_dau)
        Me.Th_Ho_so.Controls.Add(Me.Th_So_ngay)
        Me.Th_Ho_so.Controls.Add(Me.Label4)
        Me.Th_Ho_so.Controls.Add(Me.Label3)
        Me.Th_Ho_so.Controls.Add(Me.Th_Tinh_thanh_pho)
        Me.Th_Ho_so.Controls.Add(Me.Label2)
        Me.Th_Ho_so.Controls.Add(Me.Th_Nhan_vien)
        Me.Th_Ho_so.Controls.Add(Me.Label1)
        Me.Th_Ho_so.Location = New System.Drawing.Point(12, 15)
        Me.Th_Ho_so.Name = "Th_Ho_so"
        Me.Th_Ho_so.Size = New System.Drawing.Size(493, 184)
        Me.Th_Ho_so.TabIndex = 19
        '
        'Th_Ngay_bat_dau
        '
        Me.Th_Ngay_bat_dau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Ngay_bat_dau.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Th_Ngay_bat_dau.Location = New System.Drawing.Point(156, 88)
        Me.Th_Ngay_bat_dau.Name = "Th_Ngay_bat_dau"
        Me.Th_Ngay_bat_dau.Size = New System.Drawing.Size(159, 26)
        Me.Th_Ngay_bat_dau.TabIndex = 8
        '
        'Th_So_ngay
        '
        Me.Th_So_ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_So_ngay.Location = New System.Drawing.Point(156, 125)
        Me.Th_So_ngay.Name = "Th_So_ngay"
        Me.Th_So_ngay.Size = New System.Drawing.Size(159, 26)
        Me.Th_So_ngay.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(17, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Số ngày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(17, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ngày bắt đầu"
        '
        'Th_Tinh_thanh_pho
        '
        Me.Th_Tinh_thanh_pho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tinh_thanh_pho.Location = New System.Drawing.Point(156, 55)
        Me.Th_Tinh_thanh_pho.Name = "Th_Tinh_thanh_pho"
        Me.Th_Tinh_thanh_pho.Size = New System.Drawing.Size(313, 26)
        Me.Th_Tinh_thanh_pho.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tỉnh/Thành phố"
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.ForeColor = System.Drawing.Color.White
        Me.Th_Thong_bao.Location = New System.Drawing.Point(520, 15)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(66, 24)
        Me.Th_Thong_bao.TabIndex = 21
        Me.Th_Thong_bao.Text = "Label1"
        '
        'Khung_Ho_so
        '
        Me.Khung_Ho_so.Controls.Add(Me.Th_Ho_so)
        Me.Khung_Ho_so.Controls.Add(Me.Th_Thong_bao)
        Me.Khung_Ho_so.Controls.Add(Me.Th_Dong_y)
        Me.Khung_Ho_so.Location = New System.Drawing.Point(0, 46)
        Me.Khung_Ho_so.Name = "Khung_Ho_so"
        Me.Khung_Ho_so.Size = New System.Drawing.Size(822, 304)
        Me.Khung_Ho_so.TabIndex = 28
        '
        'Th_Chon_phieu_cong_tac
        '
        Me.Th_Chon_phieu_cong_tac.BackColor = System.Drawing.Color.White
        Me.Th_Chon_phieu_cong_tac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Chon_phieu_cong_tac.ForeColor = System.Drawing.Color.Red
        Me.Th_Chon_phieu_cong_tac.Location = New System.Drawing.Point(513, 4)
        Me.Th_Chon_phieu_cong_tac.Name = "Th_Chon_phieu_cong_tac"
        Me.Th_Chon_phieu_cong_tac.Size = New System.Drawing.Size(209, 37)
        Me.Th_Chon_phieu_cong_tac.TabIndex = 22
        Me.Th_Chon_phieu_cong_tac.Text = "Chọn phiếu công tác"
        Me.Th_Chon_phieu_cong_tac.UseVisualStyleBackColor = False
        '
        'MH_Nhap_lieu_Phieu_cong_tac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(822, 543)
        Me.Controls.Add(Me.Th_Chon_phieu_cong_tac)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Controls.Add(Me.Khung_Ho_so)
        Me.Name = "MH_Nhap_lieu_Phieu_cong_tac"
        Me.Text = "MH_Nhap_lieu_Phieu_cong_tac"
        Me.Th_Ho_so.ResumeLayout(False)
        Me.Th_Ho_so.PerformLayout()
        Me.Khung_Ho_so.ResumeLayout(False)
        Me.Khung_Ho_so.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Dong_y As Button
    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Th_Nhan_vien As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Th_Ho_so As Panel
    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Khung_Ho_so As Panel
    Friend WithEvents Th_Tinh_thanh_pho As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Th_So_ngay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Th_Ngay_bat_dau As DateTimePicker
    Friend WithEvents Th_Chon_phieu_cong_tac As Button
End Class
