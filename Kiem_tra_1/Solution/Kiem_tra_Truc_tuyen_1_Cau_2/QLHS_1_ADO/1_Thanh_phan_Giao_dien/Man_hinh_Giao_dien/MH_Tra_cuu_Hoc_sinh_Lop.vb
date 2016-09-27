Public Class MH_Tra_cuu_Hoc_sinh_Lop

#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Nghiep_vu As XL_NGHIEP_VU
    Protected The_hien As XL_THE_HIEN

    Protected Du_lieu As DataSet


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
        '1.==== Khởi động dữ liệu :  


        '2.===Khởi động thể hiện ===
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu học sinh theo lớp"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :  Hiện nay chưa xem xét 

        '=== Thông báo :   
        Dim Thong_bao As String = "Click Lớp để xem danh sách học sinh" & vbCrLf
        Th_Thong_bao.Text = Thong_bao

        '=== Tiêu chí Tra cứu : Danh sách đơn vị 
        Th_Danh_sach_Lop.AutoSize = True
        Dim Danh_sach_Lop As List(Of DataRow) = Nghiep_vu.Danh_sach_Lop(Du_lieu)
        'Thông báo PET : Sẽ cải tiến trong khi học BL
        Dim Danh_sach_Chuoi_Tom_tat_Lop As List(Of String) = Danh_sach_Lop.Select(Function(x) x("Ten").ToString).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Lop As List(Of String) = Danh_sach_Lop.Select(
            Function(x) "Lớp: " & x("Ten").ToString & vbCrLf & "Khối: " & Nghiep_vu.Khoi(Du_lieu, x("ID_KHOI"))("Ten").ToString
        ).ToList

        The_hien.Xuat_Danh_sach_Doi_tuong(
            Danh_sach_Lop,
            Danh_sach_Chuoi_Tom_tat_Lop,
            Danh_sach_Chuoi_Thong_tin_Lop,
            Th_Danh_sach_Lop, AddressOf XL_Chon_Lop)

        '=== Kêt quả Tra cứu : Danh_sách học sinh
        Th_Danh_sach_Lop.Size = New Size(1200, 550)
        Th_Danh_sach_Lop.AutoScroll = True

    End Sub

#End Region

#Region "Xử lý Biến cố Chính - Chọn lớp  "
    Sub XL_Chon_Lop(Th_Lop As Control, Bc As EventArgs)
        Dim Chuoi_loi As String = Kiem_tra_Chon_Lop()
        If Chuoi_loi = "" Then
            Thuc_hien_Tra_cuu_Hoc_sinh_theo_Lop(Th_Lop)
        Else
            Dim Thong_bao As String = Chuoi_loi
            Th_Thong_bao.Text = Chuoi_loi
        End If

    End Sub
    Function Kiem_tra_Chon_Lop() As String
        Dim Kq As String = ""
        Return Kq
    End Function
    Sub Thuc_hien_Tra_cuu_Hoc_sinh_theo_Lop(Th_Lop As Control)
        '=== Nhập liệu : Xác định Đối tượng được chọn 
        Dim Lop_chon As DataRow = Th_Lop.Tag
        '=== Xử lý : Tạo Kêt quả  dựa  ( Sử dụng đối tượng Nghiep_vu  )
        Dim Danh_sach_Hoc_sinh As List(Of DataRow) = Nghiep_vu.Danh_sach_Hoc_sinh_cua_Lop(Lop_chon)
        '===Kết xuất : Xuất  Kết quả cùng với Thông báo  ( Sử dụng đối tượng The_hien )
        The_hien.Xuat_Danh_sach_Hoc_sinh(Danh_sach_Hoc_sinh, Th_Danh_sach_Hoc_sinh, Nothing)
        Th_Danh_sach_Hoc_sinh.AutoScroll = True
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Hoc_sinh.Count & " nhân viên của " & Nghiep_vu.Tao_Chuoi_Tom_tat_Lop(Lop_chon)
        Th_Thong_bao.Text = Thong_bao
    End Sub

#End Region


End Class