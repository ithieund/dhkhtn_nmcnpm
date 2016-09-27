Public Class MH_Tra_cuu_Nhan_vien_Theo_Don_vi

    ' Khai bao bien/doi tuong toan cuc
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()

    End Sub

    Sub Khoi_dong()

        ' Khoi dong du lieu
        Du_lieu = Luu_tru.Doc_Du_lieu

        ' Khoi dong the hien
        Xuat_Danh_sach_Don_vi()

    End Sub

    Sub Xuat_Danh_sach_Don_vi()

        Dim Danh_sach_Don_vi As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList

        For Each Don_vi As DataRow In Danh_sach_Don_vi
            ' Tao the hien don vi
            Dim Th_Don_vi As New Button

            ' Xuat tom tat
            Dim Chuoi_Tom_tat As String = Don_vi("Ten")
            Th_Don_vi.Text = Chuoi_Tom_tat

            ' Xuat thong tin dang ghi chu
            Dim Chuoi_Thong_tin As String = ""
            Chuoi_Thong_tin &= "Tên: " & Don_vi("Ten") & vbCrLf
            Chuoi_Thong_tin &= "Số nhân viên: " & Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Don_vi).Count & vbCrLf

            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Don_vi, Chuoi_Thong_tin)

            ' Dinh dang the hien
            Th_Don_vi.Size = New Size(120, 40)
            Th_Don_vi.Font = New Font("Arial", 12)
            Th_Don_vi.ForeColor = Color.Blue
            Th_Don_vi.BackColor = Color.White

            ' Bo sung the hien don vi vao danh sach don vi
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)

            ' Chuan bi bien co chon
            Th_Don_vi.Tag = Don_vi
            AddHandler Th_Don_vi.Click, AddressOf XL_Chon_Don_vi_Click
        Next

    End Sub

    Sub XL_Chon_Don_vi_Click(Th_Don_vi As Control, Bc As EventArgs)

        ' Xac dinh don vi duoc chon
        Dim Don_vi As DataRow = Th_Don_vi.Tag

        ' Xu ly tao danh sach nhan vien thuoc don vi nay
        Dim Danh_sach_Nhan_vien As List(Of DataRow) = Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Don_vi)

        ' Ket xuat danh sach nhan vien
        Th_Danh_sach_Nhan_vien.Controls.Clear()

        For Each Nhan_vien As DataRow In Danh_sach_Nhan_vien
            ' Tao the hien nhan vien
            Dim Th_Nhan_vien As New Button

            ' Xuat tom tat
            Dim Chuoi_Tom_tat As String = Nhan_vien("Ho_ten")
            Th_Nhan_vien.Text = Chuoi_Tom_tat

            ' Xuat thong tin dang ghi chu
            Dim Chuoi_Thong_tin As String = ""
            Chuoi_Thong_tin &= "Họ tên: " & Nhan_vien("Ho_ten") & vbCrLf
            Chuoi_Thong_tin &= "CMND: " & Nhan_vien("CMND") & vbCrLf

            If Nhan_vien("Gioi_tinh") Then
                Chuoi_Thong_tin &= "Giới tính: Nam" & vbCrLf
            Else
                Chuoi_Thong_tin &= "Giới tính: Nữ" & vbCrLf
            End If

            Dim Ngay_sinh As Date = Nhan_vien("Ngay_sinh")
            Chuoi_Thong_tin &= "Ngày sinh: " & Ngay_sinh & vbCrLf
            Dim Tuoi As Integer = Today.Year - Ngay_sinh.Year
            Chuoi_Thong_tin &= "Tuổi: " & Tuoi & vbCrLf

            Chuoi_Thong_tin &= "Mức lương: " & Nhan_vien("Muc_luong") & vbCrLf
            Chuoi_Thong_tin &= "Địa chỉ: " & Nhan_vien("Dia_chi") & vbCrLf
            Chuoi_Thong_tin &= "Đơn vị: " & Don_vi("Ten") & vbCrLf

            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Nhan_vien, Chuoi_Thong_tin)

            ' Dinh dang the hien
            Th_Nhan_vien.Size = New Size(220, 50)
            Th_Nhan_vien.Font = New Font("Arial", 14)
            Th_Nhan_vien.ForeColor = Color.Yellow
            Th_Nhan_vien.BackColor = Color.Black

            ' Bo sung the hien nhan vien vao danh sach the hien nhan vien
            Th_Danh_sach_Nhan_vien.Controls.Add(Th_Nhan_vien)

        Next

    End Sub

End Class