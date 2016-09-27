Public Class MH_Tra_cuu_Phieu_cong_tac
#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN

    Protected Phieu_cong_tac As XL_PHIEU_CONG_TAC
    Protected Ma_so_Tra_cuu As String
    Protected Chon As Boolean = False ' Màn hình được dùng để chọn phiếu công tác
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
        If Ma_so_Tra_cuu = "THEO_CMND_NHAN_VIEN" Then
            Khoi_dong_Tra_cuu_Theo_CMND_nhan_vien()
        ElseIf Ma_so_Tra_cuu = "THEO_SO_NGAY_CONG_TAC" Then
            Khoi_dong_Tra_cuu_Theo_so_ngay_Cong_tac()
        ElseIf Ma_so_Tra_cuu = "THEO_THANG_CONG_TAC" Then
            Khoi_dong_Tra_cuu_Theo_Thang_cong_tac()
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
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Me, AddressOf XL_Chon_Chuc_nang)

        '=== Thông báo :   Hiện nay là riêng

        '=== Tiêu chí Tra cứu : Danh sách liên kết 
        '=== Tiêu chí Tra cứu : Chuỗi Tra cứu
        Th_Chuoi_Tra_cuu.Font = New Font("Arial", 14)
        '=== Kêt quả Tra cứu : Danh_sách phiếu công tác

    End Sub
#End Region

#Region "Tra cứu theo CMND nhân viên"
    Sub Khoi_dong_Tra_cuu_Theo_CMND_nhan_vien()
        '1.==== Khởi động dữ liệu :  


        '2.===Khởi động thể hiện ===
        ' ==== Màn hình === ***** Khởi động chung     
        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu phiếu công tác theo CMND nhân viên"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Chuc_nang As New List(Of XL_CHUC_NANG)

        Danh_sach_Chuc_nang.Add(Ung_dung.Chuc_nang_Ket_thuc)
        The_hien.Tao_Thuc_don_dong(Danh_sach_Chuc_nang,
                                   Me, AddressOf XL_Chon_Chuc_nang)

        '=== Thông báo :   
        Dim Thong_bao As String = "Hướng dẫn: Nhập CMND rồi kết thúc bằng Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao

        '=== Kêt quả Tra cứu : Danh_sách phiếu công tác

        AddHandler Th_Chuoi_Tra_cuu.KeyDown, AddressOf XL_Nhap_Chuoi_CMND
    End Sub
    Sub XL_Nhap_Chuoi_CMND(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_CMND()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Theo_CMND()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Theo_CMND()
        Dim Chuoi_CMND As String = Th_Chuoi_Tra_cuu.Text.Trim
        Dim Danh_sach_Phieu_cong_tac As List(Of XL_PHIEU_CONG_TAC) = Ung_dung.Danh_sach_Phieu_cong_tac_Theo_CMND_nhan_vien(Chuoi_CMND)
        The_hien.Xuat_Danh_sach_Phieu_cong_tac(Danh_sach_Phieu_cong_tac, Th_Danh_sach_Phieu_cong_tac, AddressOf XL_Chon_Phieu_cong_tac)
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Phieu_cong_tac.Count & " Phiếu công tác ứng với số CMND là:  " & Chuoi_CMND
        Th_Thong_bao.Text = Thong_bao
    End Sub
    Function Kiem_tra_Nhap_Chuoi_CMND() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Chuoi_CMND As String = Th_Chuoi_Tra_cuu.Text.Trim
        Hop_le = Chuoi_CMND <> ""
        If Not Hop_le Then
            Kq &= "CMND không được rỗng"
        End If
        Return Kq
    End Function



#End Region

#Region "Tra cứu theo Số ngày công tác"

    Sub Khoi_dong_Tra_cuu_Theo_so_ngay_Cong_tac()
        '1.==== Khởi động dữ liệu :  

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình  **** Khởi động chung 

        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu phiếu công tác theo số ngày đi công tác"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Chuc_nang As New List(Of XL_CHUC_NANG)
        Danh_sach_Chuc_nang.Add(Ung_dung.Chuc_nang_Ket_thuc)
        The_hien.Tao_Thuc_don_dong(Danh_sach_Chuc_nang,
                                   Me, AddressOf XL_Chon_Chuc_nang)

        '=== Thông báo :  
        Dim Thong_bao As String = "Nhập số ngày rồi kết thúc bằng Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Chuỗi Họ tên
        AddHandler Th_Chuoi_Tra_cuu.KeyDown, AddressOf XL_Nhap_Chuoi_So_ngay

    End Sub
    Sub XL_Nhap_Chuoi_So_ngay(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_So_ngay()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Theo_So_ngay()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Theo_So_ngay()
        Dim Chuoi_So_ngay As String = Th_Chuoi_Tra_cuu.Text.Trim
        Dim So_ngay As Integer = Integer.Parse(Chuoi_So_ngay)

        Dim Danh_sach_Phieu_cong_tac As List(Of XL_PHIEU_CONG_TAC) = Ung_dung.Danh_sach_Phieu_cong_tac_Theo_So_ngay_cong_tac(So_ngay)
        The_hien.Xuat_Danh_sach_Phieu_cong_tac(Danh_sach_Phieu_cong_tac, Th_Danh_sach_Phieu_cong_tac, AddressOf XL_Chon_Phieu_cong_tac)
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Phieu_cong_tac.Count & " Phiếu công tác ứng với số ngày công tác là:  " & Chuoi_So_ngay
        Th_Thong_bao.Text = Thong_bao
    End Sub
    Function Kiem_tra_Nhap_Chuoi_So_ngay() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim So_nguyen As Integer

        Dim Chuoi_So_ngay As String = Th_Chuoi_Tra_cuu.Text.Trim
        Hop_le = Integer.TryParse(Chuoi_So_ngay, So_nguyen) AndAlso So_nguyen > 0
        If Not Hop_le Then
            Kq &= "Số ngày phải là số nguyên dương"
        End If
        Return Kq
    End Function

#End Region

#Region "Tra cứu theo Tháng công tác"

    Sub Khoi_dong_Tra_cuu_Theo_Thang_cong_tac()
        '1.==== Khởi động dữ liệu :  

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình **** Khởi động chung

        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu phiếu công tác theo tháng đi công tác"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Chuc_nang As New List(Of XL_CHUC_NANG)
        Danh_sach_Chuc_nang.Add(Ung_dung.Chuc_nang_Ket_thuc)
        The_hien.Tao_Thuc_don_dong(Danh_sach_Chuc_nang,
                                                         Me, AddressOf XL_Chon_Chuc_nang)

        '=== Thông báo :  
        Dim Thong_bao As String = "Nhập tháng công tác dạng Tháng/Năm rồi kết thúc bằng Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Chuỗi Mức lương
        AddHandler Th_Chuoi_Tra_cuu.KeyDown, AddressOf XL_Nhap_Chuoi_Thang
        '=== Kêt quả Tra cứu : Danh_sách nhân viên

    End Sub

    Sub XL_Nhap_Chuoi_Thang(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Thang()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Theo_Thang()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Theo_Thang()
        Dim Chuoi_Thang_nam As String = Th_Chuoi_Tra_cuu.Text.Trim
        Dim Thang_nam As String() = Chuoi_Thang_nam.Split("/")
        Dim Thang As Integer = Integer.Parse(Thang_nam(0))
        Dim Nam As Integer = Integer.Parse(Thang_nam(1))

        Dim Danh_sach_Phieu_cong_tac As List(Of XL_PHIEU_CONG_TAC) = Ung_dung.Danh_sach_Phieu_cong_tac_Theo_Thang_cong_tac(Thang, Nam)
        The_hien.Xuat_Danh_sach_Phieu_cong_tac(Danh_sach_Phieu_cong_tac, Th_Danh_sach_Phieu_cong_tac, AddressOf XL_Chon_Phieu_cong_tac)
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Phieu_cong_tac.Count & " Phiếu công tác ứng với tháng công tác là:  " & Chuoi_Thang_nam
        Th_Thong_bao.Text = Thong_bao
    End Sub
    Function Kiem_tra_Nhap_Chuoi_Thang() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean

        Dim Chuoi_Thang_nam As String = Th_Chuoi_Tra_cuu.Text.Trim
        Hop_le = Chuoi_Thang_nam.Contains("/")
        If Not Hop_le Then
            Kq &= "Tháng công tác phải có dạng Tháng/Năm"
            Return Kq
        End If

        Dim Thang_nam As String() = Chuoi_Thang_nam.Split("/")
        Dim Thang As Integer
        Dim Nam As Integer

        Hop_le = Integer.TryParse(Thang_nam(0), Thang) AndAlso Thang > 0 And Thang <= 12
        If Not Hop_le Then
            Kq &= "Tháng phải nằm trong khoảng từ 1 đến 12"
        End If

        Hop_le = Integer.TryParse(Thang_nam(1), Nam) AndAlso Nam > 0
        If Not Hop_le Then
            Kq &= "Năm phải là số ngyên dương"
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
#Region "Xử lý Biến cố phụ - Chọn phiếu công tác "
    Sub XL_Chon_Phieu_cong_tac(Th_Phieu_cong_tac As ToolStripItem, Bc As EventArgs)
        The_hien.XL_Thay_doi_Trang_thai_The_hien(Th_Phieu_cong_tac, Nothing)
        Phieu_cong_tac = Th_Phieu_cong_tac.Tag
        If Chon Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Xử lý Trả kết quả - Phiếu công tác được chọn "
    Public Function Phieu_cong_tac_Chon() As XL_PHIEU_CONG_TAC
        Dim Kq As XL_PHIEU_CONG_TAC = Phieu_cong_tac
        Return Kq
    End Function

#End Region
End Class