
Partial Public Class XL_UNG_DUNG
#Region "Biến/Đối tượng toàn cục"
    Public ReadOnly Du_lieu As DataSet
#End Region
#Region "Khởi động"
    Public Sub New(x as DataSet)
        Du_lieu = x
    End Sub
#End Region

#Region "Trích rút Danh sách Đối tượng"
    Public Function Danh_sach_Cong_ty() As List(Of XL_CONG_TY)
        Dim Kq As New List(Of XL_CONG_TY)
        For Each Dong As DataRow In Du_lieu.Tables("CONG_TY").Rows
            Dim Cong_ty As New XL_CONG_TY(Me, Dong)
            Kq.Add(Cong_ty)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Chi_nhanh() As List(Of XL_CHI_NHANH)
        Dim Kq As New List(Of XL_CHI_NHANH)
        For Each Dong As DataRow In Du_lieu.Tables("CHI_NHANH").Rows
            Dim Chi_nhanh As New XL_CHI_NHANH(Me, Dong)
            Kq.Add(Chi_nhanh)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Don_vi() As List(Of XL_DON_VI)
        Dim Kq As New List(Of XL_DON_VI)
        For Each Dong As DataRow In Du_lieu.Tables("DON_VI").Rows
            Dim Don_vi As New XL_DON_VI(Me, Dong)
            Kq.Add(Don_vi)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien() As List(Of XL_NHAN_VIEN)
        Dim Kq As New List(Of XL_NHAN_VIEN)
        For Each Dong As DataRow In Du_lieu.Tables("NHAN_VIEN").Rows
            Dim Nhan_vien As New XL_NHAN_VIEN(Me, Dong)
            Kq.Add(Nhan_vien)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Phieu_cong_tac() As List(Of XL_PHIEU_CONG_TAC)
        Dim Kq As New List(Of XL_PHIEU_CONG_TAC)
        For Each Dong As DataRow In Du_lieu.Tables("PHIEU_CONG_TAC").Rows
            Dim Phieu_cong_tac As New XL_PHIEU_CONG_TAC(Me, Dong)
            Kq.Add(Phieu_cong_tac)
        Next
        Return Kq
    End Function


#End Region


#Region "Trích rút Đối tượng"
    Public Function Cong_ty(ID As Integer) As XL_CONG_TY
        Dim Kq As XL_CONG_TY = Danh_sach_Cong_ty.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function

    Public Function Chi_nhanh(ID As Integer) As XL_CHI_NHANH
        Dim Kq As XL_CHI_NHANH = Danh_sach_Chi_nhanh.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function

    Public Function Don_vi(ID As Integer) As XL_DON_VI
        Dim Kq As XL_DON_VI = Danh_sach_Don_vi.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function

    Public Function Nhan_vien(ID As Integer) As XL_NHAN_VIEN
        Dim Kq As XL_NHAN_VIEN = Danh_sach_Nhan_vien.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function


#End Region

#Region "Tạo Đối tượng mới"
    Public Function Tao_Cong_ty_moi() As XL_CONG_TY ' Dự trù cho tương lai
        Dim Cong_ty As XL_CONG_TY
        Dim Dong As DataRow = Du_lieu.Tables("CONG_TY").NewRow
        Cong_ty = New XL_CONG_TY(Me, Dong)
        Cong_ty.Ten = "Tên " & Cong_ty.ID
        Cong_ty.Dien_thoai = "Điện thoại " & Cong_ty.ID
        Cong_ty.Dia_chi = "Địa chỉ " & Cong_ty.ID
        Cong_ty.Tuoi_toi_thieu = 20
        Cong_ty.Tuoi_toi_da = 50
        Cong_ty.Muc_luong_toi_thieu = 3500000
        Return Cong_ty
    End Function

    Public Function Tao_Chi_nhanh_moi() As XL_CHI_NHANH
        Dim Chi_nhanh As XL_CHI_NHANH
        Dim Dong As DataRow = Du_lieu.Tables("CHI_NHANH").NewRow
        Chi_nhanh = New XL_CHI_NHANH(Me, Dong)
        Chi_nhanh.Ten = "Tên " & Chi_nhanh.ID
        Chi_nhanh.Dien_thoai = "Điện thoại " & Chi_nhanh.ID
        Chi_nhanh.Dia_chi = "Địa chỉ " & Chi_nhanh.ID
        Return Chi_nhanh
    End Function

    Public Function Tao_Don_vi_moi() As XL_DON_VI
        Dim Don_vi As XL_DON_VI
        Dim Dong As DataRow = Du_lieu.Tables("DON_VI").NewRow
        Don_vi = New XL_DON_VI(Me, Dong)
        Don_vi.Ten = "Tên " & Don_vi.ID
        Don_vi.ID_CHI_NHANH = Danh_sach_Chi_nhanh(0).ID
        Return Don_vi
    End Function
    Public Function Tao_Nhan_vien_moi() As XL_NHAN_VIEN
        Dim Nhan_vien As XL_NHAN_VIEN
        Dim Dong As DataRow = Du_lieu.Tables("NHAN_VIEN").NewRow
        Nhan_vien = New XL_NHAN_VIEN(Me, Dong)

        Nhan_vien.Ho_ten = "Họ tên " & Nhan_vien.ID
        Nhan_vien.Gioi_tinh = True
        Nhan_vien.CMND = "CMND " & Nhan_vien.ID
        Nhan_vien.Ngay_sinh = New DateTime(Today.Year - 30, 1, 1)
        Nhan_vien.Muc_luong = 4000000
        Nhan_vien.Dia_chi = "Địa chỉ " & Nhan_vien.ID
        Nhan_vien.ID_DON_VI = Danh_sach_Don_vi(0).ID

        Return Nhan_vien
    End Function

    Public Function Tao_Phieu_cong_tac_moi() As XL_PHIEU_CONG_TAC
        Dim Phieu_cong_tac As XL_PHIEU_CONG_TAC
        Dim Dong As DataRow = Du_lieu.Tables("PHIEU_CONG_TAC").NewRow
        Phieu_cong_tac = New XL_PHIEU_CONG_TAC(Me, Dong)

        Phieu_cong_tac.Tinh_thanh_pho = "Hồ Chí Minh"
        Phieu_cong_tac.Ngay_bat_dau = Date.Today
        Phieu_cong_tac.So_ngay = 1
        Phieu_cong_tac.ID_NHAN_VIEN = Danh_sach_Nhan_vien(0).ID

        Return Phieu_cong_tac
    End Function

#End Region

#Region "Trích rút Danh sách theo thuộc tính"

    '==== Trích rút Danh sách Nhân viên theo các thuộc tính====
    Public Function Danh_sach_Nhan_vien_theo_Ho_ten(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Ho_ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_CMND(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.CMND.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Ngay_sinh(Can_duoi As DateTime, Can_tren As DateTime) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Ngay_sinh >= Can_duoi And x.Ngay_sinh <= Can_tren)
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Muc_luong(Can_duoi As Double, Can_tren As Double) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Muc_luong >= Can_duoi And x.Muc_luong <= Can_tren)
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Dia_chi(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Dia_chi.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Do_tuoi(Can_duoi As Integer, Can_tren As Integer) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Tuoi >= Can_duoi And x.Tuoi <= Can_tren)
        Return Kq
    End Function

    '==== Trích rút Danh sách Phiếu tra cứu theo các thuộc tính====
    Public Function Danh_sach_Phieu_cong_tac_Theo_CMND_nhan_vien(CMND As String) As List(Of XL_PHIEU_CONG_TAC)
        Dim Kq As List(Of XL_PHIEU_CONG_TAC) = Danh_sach_Phieu_cong_tac()
        Kq = Kq.FindAll(Function(x) x.Nhan_vien.CMND = CMND)
        Return Kq
    End Function

    Public Function Danh_sach_Phieu_cong_tac_Theo_So_ngay_cong_tac(So_ngay As Integer) As List(Of XL_PHIEU_CONG_TAC)
        Dim Kq As List(Of XL_PHIEU_CONG_TAC) = Danh_sach_Phieu_cong_tac()
        Kq = Kq.FindAll(Function(x) x.So_ngay = So_ngay)
        Return Kq
    End Function

    Public Function Danh_sach_Phieu_cong_tac_Theo_Thang_cong_tac(Thang As Integer, Nam As Integer) As List(Of XL_PHIEU_CONG_TAC)
        Dim Kq As List(Of XL_PHIEU_CONG_TAC) = Danh_sach_Phieu_cong_tac()
        Kq = Kq.FindAll(Function(x) x.Ngay_bat_dau.Month = Thang And x.Ngay_bat_dau.Year = Nam)
        Return Kq
    End Function
#End Region


#Region "Chức năng"
    Public Function Danh_sach_Chuc_nang_cua_Ung_dung() As List(Of XL_CHUC_NANG)
        Dim Kq As New List(Of XL_CHUC_NANG)
        Kq.Add(New XL_CHUC_NANG(Me, "Công ty", "CONG_TY"))
        Kq.Add(New XL_CHUC_NANG(Me, "Chi nhánh", "CHI_NHANH"))
        Kq.Add(New XL_CHUC_NANG(Me, "Đơn vị", "DON_VI"))
        Kq.Add(New XL_CHUC_NANG(Me, "Nhân viên", "NHAN_VIEN"))
        Kq.Add(New XL_CHUC_NANG(Me, "Phiếu công tác", "PHIEU_CONG_TAC"))
        Kq.Add(Chuc_nang_Ket_thuc)
        Return Kq
    End Function
    Public Function Danh_sach_Chuc_nang_cua_Cong_ty() As List(Of XL_CHUC_NANG)
        Dim Kq As New List(Of XL_CHUC_NANG)
        Dim Loai_doi_tuong As String = "CONG_TY"  'Loại đối tượng Tổ chức cấp 0 ( Cấp cao nhất của ứng dụng )
        Kq.Add(New XL_CHUC_NANG(Me, "Cập nhật thông tin", "CAP_NHAT_" & Loai_doi_tuong))
        Return Kq
    End Function
    Public Function Danh_sach_Chuc_nang_cua_Chi_nhanh() As List(Of XL_CHUC_NANG)
        Dim Kq As New List(Of XL_CHUC_NANG)
        Dim Loai_doi_tuong As String = "CHI_NHANH"  'Loại đối tượng Tổ chức   - Cấp 1
        Kq.Add(New XL_CHUC_NANG(Me, "Thêm mới", "GHI_MOI_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Cập nhật", "CAP_NHAT_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Xóa", "XOA_" & Loai_doi_tuong))
        Return Kq
    End Function
    Public Function Danh_sach_Chuc_nang_cua_Don_vi() As List(Of XL_CHUC_NANG)
        Dim Kq As New List(Of XL_CHUC_NANG)
        Dim Loai_doi_tuong As String = "DON_VI"  'Loại đối tượng Tổ chức   - Cấp 2
        Kq.Add(New XL_CHUC_NANG(Me, "Thêm mới", "GHI_MOI_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Cập nhật", "CAP_NHAT_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Xóa", "XOA_" & Loai_doi_tuong))
        Return Kq
    End Function
    Public Function Danh_sach_Chuc_nang_cua_Nhan_vien() As List(Of XL_CHUC_NANG)
        Dim Kq As New List(Of XL_CHUC_NANG)
        Dim Loai_doi_tuong As String = "NHAN_VIEN" ' Loại đối tượng Con người
        Kq.Add(New XL_CHUC_NANG(Me, "Thêm mới", "GHI_MOI_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Cập nhật", "CAP_NHAT_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Xóa", "XOA_" & Loai_doi_tuong))
        Return Kq
    End Function
    Public Function Danh_sach_Chuc_nang_cua_Phieu_cong_tac() As List(Of XL_CHUC_NANG)
        Dim Kq As New List(Of XL_CHUC_NANG)
        Dim Loai_doi_tuong As String = "PHIEU_CONG_TAC" ' Loại đối tượng Hoạt động - Đối tượng Quản lý chính của ứng dụng
        Kq.Add(New XL_CHUC_NANG(Me, "Lập phiếu", "GHI_MOI_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Cập nhật", "CAP_NHAT_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Hủy phiếu", "XOA_" & Loai_doi_tuong))
        Kq.Add(New XL_CHUC_NANG(Me, "Tra cứu theo CMND nhân viên", "TRA_CUU_" & Loai_doi_tuong & "_THEO_CMND_NHAN_VIEN"))
        Kq.Add(New XL_CHUC_NANG(Me, "Tra cứu theo Số ngày công tác", "TRA_CUU_" & Loai_doi_tuong & "_THEO_SO_NGAY_CONG_TAC"))
        Kq.Add(New XL_CHUC_NANG(Me, "Tra cứu theo Tháng công tác", "TRA_CUU_" & Loai_doi_tuong & "_THEO_THANG_CONG_TAC"))
        Return Kq
    End Function

    Public Function Chuc_nang_Ket_thuc() As XL_CHUC_NANG
        Dim Kq As New XL_CHUC_NANG(Me, "Kêt thúc", "KET_THUC")
        Return Kq
    End Function

#End Region

End Class
