Public Class MH_Tra_cuu_Nhan_vien
#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN

    Protected Nhan_vien As XL_NHAN_VIEN
    Protected Ma_so_Tra_cuu As String
    Protected Chon As Boolean = False ' Màn hình được dùng để chọn nhân viên
#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New(Ung_dung As XL_UNG_DUNG,
                   Ma_so_Tra_cuu As String, Optional Chon As Boolean = False)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)


        Me.Ma_so_Tra_cuu = Ma_so_Tra_cuu
        Me.Chon = Chon
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        If Ma_so_Tra_cuu = "DON_VI" Then
            Th_Chuoi_Tra_cuu.Visible = False
            Khoi_dong_Tra_cuu_Nhan_vien_Don_vi()
        ElseIf Ma_so_Tra_cuu = "HO_TEN" Then
            Th_Danh_sach_Lien_ket.Visible = False
            Khoi_dong_Tra_cuu_Nhan_vien_Ho_ten()
        ElseIf Ma_so_Tra_cuu = "MUC_LUONG" Then
            Th_Danh_sach_Lien_ket.Visible = False
            Khoi_dong_Tra_cuu_Nhan_vien_Muc_luong()
        End If
        Khoi_dong_chung()
    End Sub

    Sub Khoi_dong_chung()
        '1.==== Khởi động dữ liệu :  

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        Me.FormBorderStyle = FormBorderStyle.None
        '===Tiêu đề : Hiện nay  có nội dung riêng

        Th_Tieu_de.Font = New Font("Arial", 24)
        Th_Tieu_de.ForeColor = Color.Snow
        Th_Tieu_de.TextAlign = ContentAlignment.MiddleLeft

        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Me)

        '=== Thông báo :   Hiện nay là riêng

        '=== Tiêu chí Tra cứu : Danh sách liên kết 
        '=== Tiêu chí Tra cứu : Chuỗi Tra cứu
        Th_Chuoi_Tra_cuu.Font = New Font("Arial", 14)
        '=== Kêt quả Tra cứu : Danh_sách nhân viên

    End Sub
#End Region

#Region "Tra cứu theo đơn vị"
    Sub Khoi_dong_Tra_cuu_Nhan_vien_Don_vi()
        '1.==== Khởi động dữ liệu :  


        '2.===Khởi động thể hiện ===
        ' ==== Màn hình === ***** Khởi động chung     
        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu nhân viên theo đơn vị"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Chuc_nang As New List(Of XL_CHUC_NANG)

        Danh_sach_Chuc_nang.Add(Ung_dung.Chuc_nang_Ket_thuc)
        The_hien.Tao_Thuc_don_dong(Danh_sach_Chuc_nang,
                                   Me, AddressOf XL_Chon_Chuc_nang)

        '=== Thông báo :   
        Dim Thong_bao As String = "Click Đơn vị để xem danh sách nhân viên" & vbCrLf
        Th_Thong_bao.Text = Thong_bao

        '=== Tiêu chí Tra cứu : Danh sách đơn vị 

        'Thông báo PET : Sẽ còn tiếp tục cải tiến trong phiên bản sauL
        Dim Danh_sach_Don_vi As List(Of XL_DON_VI) = Ung_dung.Danh_sach_Don_vi
        Dim Danh_sach_Chuoi_Tom_tat_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) "DON_VI_" & x.ID).ToList
        The_hien.Xuat_Danh_sach_Doi_tuong(Danh_sach_Don_vi,
                                                                                          Danh_sach_Chuoi_Tom_tat_Don_vi,
                                                                                           Danh_sach_Chuoi_Thong_tin_Don_vi,
                                                                                            Danh_sach_Ma_so_Hinh_Don_vi,
                                                                                           Th_Danh_sach_Lien_ket, AddressOf XL_Chon_Don_vi)
        '=== Kêt quả Tra cứu : Danh_sách nhân viên


    End Sub

    Sub XL_Chon_Don_vi(Th_Don_vi As ToolStripItem, Bc As EventArgs)
        The_hien.XL_Thay_doi_Trang_thai_The_hien(Th_Don_vi, Nothing)
        Dim Chuoi_loi As String = Kiem_tra_Chon_Don_vi()
        If Chuoi_loi = "" Then
            Thuc_hien_Tra_cuu_Nhan_vien_Don_vi(Th_Don_vi)
        Else
            Dim Thong_bao As String = Chuoi_loi
            Th_Thong_bao.Text = Chuoi_loi
        End If

    End Sub
    Function Kiem_tra_Chon_Don_vi() As String
        Dim Kq As String = ""
        Return Kq
    End Function
    Sub Thuc_hien_Tra_cuu_Nhan_vien_Don_vi(Th_Don_vi As ToolStripItem)
        '=== Nhập liệu : Xác định Đối tượng được chọn 
        Dim Don_vi_Chon As XL_DON_VI = Th_Don_vi.Tag
        '=== Xử lý : Tạo Kêt quả  dựa  ( Sử dụng đối tượng Nghiep_vu  )
        Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Don_vi_Chon.Danh_sach_Nhan_vien
        '===Kết xuất : Xuất  Kết quả cùng với Thông báo  ( Sử dụng đối tượng The_hien )
        The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien, AddressOf XL_Chon_Nhan_vien)
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Nhan_vien.Count & " nhân viên của " &
                                                                                                     Don_vi_Chon.Tao_Chuoi_Tom_tat
        Th_Thong_bao.Text = Thong_bao
    End Sub


#End Region

#Region "Tra cứu theo Họ tên"

    Sub Khoi_dong_Tra_cuu_Nhan_vien_Ho_ten()
        '1.==== Khởi động dữ liệu :  

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình  **** Khởi động chung 

        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu nhân viên theo họ tên"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Chuc_nang As New List(Of XL_CHUC_NANG)
        Danh_sach_Chuc_nang.Add(Ung_dung.Chuc_nang_Ket_thuc)
        The_hien.Tao_Thuc_don_dong(Danh_sach_Chuc_nang,
                                   Me, AddressOf XL_Chon_Chuc_nang)

        '=== Thông báo :  
        Dim Thong_bao As String = "Nhập chuỗi họ tên ( không được chứa ' hay "" ) và kết thúc  với Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Chuỗi Họ tên
        Th_Chuoi_Tra_cuu.Text = "Nguyễn"
        AddHandler Th_Chuoi_Tra_cuu.KeyDown, AddressOf XL_Nhap_Chuoi_Ho_ten
        '=== Kết quả Tra cứu : Danh sách nhân viên

    End Sub


    Sub XL_Nhap_Chuoi_Ho_ten(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Ho_ten()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
        Dim Chuoi_Ho_ten As String = Th_Chuoi_Tra_cuu.Text.Trim
        Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Ung_dung.Danh_sach_Nhan_vien_theo_Ho_ten(Chuoi_Ho_ten)
        The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien, AddressOf XL_Chon_Nhan_vien)
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Nhan_vien.Count & " nhân viên có họ tên chứa chuỗi  " & Chuoi_Ho_ten
        Th_Thong_bao.Text = Thong_bao
    End Sub
    Function Kiem_tra_Nhap_Chuoi_Ho_ten() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Chuoi_Ho_ten As String = Th_Chuoi_Tra_cuu.Text.Trim
        Hop_le = Not Chuoi_Ho_ten.Contains("'") And Not Chuoi_Ho_ten.Contains("""")
        If Not Hop_le Then
            Kq &= "Chuỗi nhập không được chứa ' hay """
        End If
        Return Kq
    End Function

#End Region

#Region "Tra cứu theo Mức lương"

    Sub Khoi_dong_Tra_cuu_Nhan_vien_Muc_luong()
        '1.==== Khởi động dữ liệu :  

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình **** Khởi động chung

        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu nhân viên theo mức lương"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Chuc_nang As New List(Of XL_CHUC_NANG)
        Danh_sach_Chuc_nang.Add(Ung_dung.Chuc_nang_Ket_thuc)
        The_hien.Tao_Thuc_don_dong(Danh_sach_Chuc_nang,
                                                         Me, AddressOf XL_Chon_Chuc_nang)

        '=== Thông báo :  
        Dim Thong_bao As String = "Nhập mức lương có dạng Cận dưới - Cận trên và kết thúc với Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Chuỗi Mức lương 
        Th_Chuoi_Tra_cuu.Text = "4000000-7000000"
        AddHandler Th_Chuoi_Tra_cuu.KeyDown, AddressOf XL_Nhap_Chuoi_Muc_luong
        '=== Kêt quả Tra cứu : Danh_sách nhân viên

    End Sub

    Sub XL_Nhap_Chuoi_Muc_luong(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Muc_luong()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Nhan_vien_Muc_luong()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Nhan_vien_Muc_luong()
        Dim Chuoi_Muc_luong As String = Th_Chuoi_Tra_cuu.Text.Trim
        Dim M As String() = Split(Chuoi_Muc_luong, "-")
        Dim Can_duoi As Double = M(0)
        Dim Can_tren As Double = M(1)

        Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Ung_dung.Danh_sach_Nhan_vien_theo_Muc_luong(Can_duoi, Can_tren)
        The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien, AddressOf XL_Chon_Nhan_vien)
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Nhan_vien.Count & " nhân viên có mức lương thuộc đoạn  " & Chuoi_Muc_luong
        Th_Thong_bao.Text = Thong_bao
    End Sub
    Function Kiem_tra_Nhap_Chuoi_Muc_luong() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Chuoi_Muc_luong As String = Th_Chuoi_Tra_cuu.Text.Trim
        Hop_le = Chuoi_Muc_luong.Contains("-")
        If Hop_le Then
            Dim M As String() = Split(Chuoi_Muc_luong, "-")
            Hop_le = M.Count = 2 AndAlso IsNumeric(M(0)) AndAlso IsNumeric(M(1))
        End If
        If Not Hop_le Then
            Kq &= "Mức lương nhập có dạng Can_duoi - Can_tren với Can_duoi,Can_tren là 2 số nguyên"
        End If
        Return Kq
    End Function
#End Region

#Region "Xử lý Biến cố Phụ - Chọn chức năng"

    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Chuc_nang As XL_CHUC_NANG = Th_Chuc_nang.Tag
        Dim Ma_so_Chon As String = Chuc_nang.Ma_so
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
        Else
            The_hien.XL_Kich_hoat_Chuc_nang(Th_Chuc_nang, Bc)
        End If
    End Sub

#End Region
#Region "Xử lý Biến cố phụ - Chọn nhân viên "
    Sub XL_Chon_Nhan_vien(Th_Nhan_vien As ToolStripItem, Bc As EventArgs)
        The_hien.XL_Thay_doi_Trang_thai_The_hien(Th_Nhan_vien, Nothing)
        Nhan_vien = Th_Nhan_vien.Tag
        If Chon Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Xử lý Trả kết quả - Nhân viên được chọn "
    Public Function Nhan_vien_Chon() As XL_NHAN_VIEN
        Dim Kq As XL_NHAN_VIEN = Nhan_vien
        Return Kq
    End Function

#End Region
End Class