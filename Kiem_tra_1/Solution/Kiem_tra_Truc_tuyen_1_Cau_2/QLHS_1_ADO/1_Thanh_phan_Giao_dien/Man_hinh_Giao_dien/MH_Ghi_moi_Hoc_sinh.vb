Public Class MH_Ghi_moi_Hoc_sinh

#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Nghiep_vu As XL_NGHIEP_VU
    Protected The_hien As XL_THE_HIEN

    Protected Du_lieu As DataSet
    Protected Hoc_sinh_Chon As DataRow

#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New(Du_lieu As DataSet)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Nghiep_vu = New XL_NGHIEP_VU
        The_hien = New XL_THE_HIEN
        Me.Du_lieu = Du_lieu
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '1.==== Khởi động dữ liệu 
        Hoc_sinh_Chon = Nghiep_vu.Tao_Hoc_sinh_moi(Du_lieu)

        '2.===Khởi động thể hiện ===
        '===Tiêu đề 
        Dim Tieu_de As String = "Thêm mới học sinh"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                                         "Chọn hình", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                                           "CHON_HINH", "KET_THUC"}.ToList
        The_hien.Tao_Thuc_don_dong(Danh_sach_Ten_Chuc_nang, Danh_sach_Ma_so_Chuc_nang, Th_Hoc_sinh, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo :   
        Dim Thong_bao As String = "Hướng dẩn nhập liệu " & vbCrLf
        Thong_bao &= " - Sử dụng thực đơn động để chọn hình" & vbCrLf
        Thong_bao &= Nghiep_vu.Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi_Hoc_sinh(Hoc_sinh_Chon)
        Th_Thong_bao.Text = Thong_bao

        '===== Đối tượng liên kết : Danh sách giới tính 
        Th_Danh_sach_Gioi_tinh.AutoSize = True

        Dim Danh_sach_Gioi_tinh As List(Of DataRow) = Nghiep_vu.Danh_sach_Gioi_tinh(Du_lieu)
        Dim Danh_sach_Chuoi_Tom_tat_Gioi_tinh As List(Of String) = Danh_sach_Gioi_tinh.Select(Function(x) x("Ten").ToString).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Gioi_tinh As List(Of String) = Danh_sach_Gioi_tinh.Select(Function(x) x("Ten").ToString).ToList
        The_hien.Xuat_Danh_sach_Chon_Doi_tuong(
            Danh_sach_Gioi_tinh,
            Danh_sach_Chuoi_Tom_tat_Gioi_tinh,
            Danh_sach_Chuoi_Thong_tin_Gioi_tinh,
            Th_Danh_sach_Gioi_tinh, Nothing)
        '===== Đối tượng liên kết : Danh sách lớp
        Th_Danh_sach_Lop.Size = New Size(500, 150)

        Dim Danh_sach_Lop As List(Of DataRow) = Nghiep_vu.Danh_sach_Lop(Du_lieu)
        Dim Danh_sach_Chuoi_Tom_tat_Lop As List(Of String) = Danh_sach_Lop.Select(Function(x) x("Ten").ToString).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Lop As List(Of String) = Danh_sach_Lop.Select(Function(x) x("Ten").ToString).ToList

        The_hien.Xuat_Danh_sach_Chon_Doi_tuong(
            Danh_sach_Lop,
            Danh_sach_Chuoi_Tom_tat_Lop,
            Danh_sach_Chuoi_Thong_tin_Lop,
            Th_Danh_sach_Lop, Nothing)

        '=== Hồ sơ nhập liệu : Học sinh
        Th_Hoc_sinh.BorderStyle = BorderStyle.FixedSingle
        The_hien.Xuat_Ho_so_Hoc_sinh(Hoc_sinh_Chon, Th_Hoc_sinh)
        '=== Yêu cầu xử lý : Đồng ý 
        AddHandler Th_Dong_y.Click, AddressOf XL_Dong_y
    End Sub

#End Region

#Region "Xử lý Biến cố Chính - Click Đồng ý  "
    Sub XL_Dong_y(Th_Dong_y As Control, Bc As EventArgs)
        Dim Chuoi_loi As String = The_hien.Nhap_Ho_so_Hoc_sinh(Hoc_sinh_Chon, Th_Hoc_sinh)
        If Chuoi_loi = "" Then
            Thuc_hien_Ghi_moi_Hoc_sinh()
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu " & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
    Sub Thuc_hien_Ghi_moi_Hoc_sinh()
        Dim Chuoi_loi As String = Nghiep_vu.Kiem_tra_Ghi_moi_Hoc_sinh(Hoc_sinh_Chon)
        If Chuoi_loi = "" Then
            Chuoi_loi = Luu_tru.Ghi(Hoc_sinh_Chon, LOAI_GHI.Ghi_moi)
            If Chuoi_loi = "" Then
                Chuoi_loi = Luu_tru.Ghi_Media(Hoc_sinh_Chon, LOAI_MEDIA.Hinh, Th_Hinh.Tag)
            End If
        End If
        If Chuoi_loi = "" Then
            Dim Thong_bao As String = "Đã ghi hồ sơ học sinh" & vbCrLf
            Thong_bao &= Nghiep_vu.Tao_Chuoi_Thong_tin_Hoc_sinh(Hoc_sinh_Chon, True)
            Thong_bao &= "======" & vbCrLf
            Thong_bao &= "Có thể tiếp tục nhập liệu hồ sơ học sinh mới"
            Th_Thong_bao.Text = Thong_bao

            ' Thay đổi trạng thái màn hình với học sinh mới 
            Hoc_sinh_Chon = Nghiep_vu.Tao_Hoc_sinh_moi(Du_lieu)
            The_hien.Xuat_Ho_so_Hoc_sinh(Hoc_sinh_Chon, Th_Hoc_sinh)
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
#End Region

#Region "Xử lý Biến cố Phụ - Chọn chức năng"
    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Ma_so_Chon As String = Th_Chuc_nang.Tag
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
        ElseIf Ma_so_Chon = "CHON_HINH" Then
            Dim Chuoi_loi As String = The_hien.Chon_Hinh(Th_Hinh)
            Dim Thong_bao As String = Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
#End Region

End Class