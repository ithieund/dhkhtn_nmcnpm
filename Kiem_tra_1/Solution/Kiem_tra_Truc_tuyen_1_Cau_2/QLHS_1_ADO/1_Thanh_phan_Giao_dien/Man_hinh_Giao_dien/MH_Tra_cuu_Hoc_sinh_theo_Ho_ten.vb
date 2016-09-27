Public Class MH_Tra_cuu_Hoc_sinh_theo_Ho_ten

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
        Dim Tieu_de As String = "Tra cứu học sinh theo họ tên"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :  Hiện nay chưa xem xét 

        '=== Thông báo :  
        Dim Thong_bao As String = "Nhập chuỗi họ tên ( không được chứa ' hay "" ) và kết thúc  với Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Chuỗi Họ tên
        Th_Chuoi_Ho_ten.Text = "Nguyễn"
        AddHandler Th_Chuoi_Ho_ten.KeyDown, AddressOf XL_Nhap_Chuoi_Ho_ten
        '=== Kết quả Tra cứu : Danh sách học sinh
        Th_Danh_sach_Hoc_sinh.Size = New Size(1200, 550)
        Th_Danh_sach_Hoc_sinh.AutoScroll = True
    End Sub

#End Region

#Region "Xử lý Biến cố chính - Nhập Chuỗi Họ tên"
    Sub XL_Nhap_Chuoi_Ho_ten(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Ho_ten()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Hoc_sinh_Ho_ten()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Hoc_sinh_Ho_ten()
        Dim Chuoi_Ho_ten As String = Th_Chuoi_Ho_ten.Text.Trim
        Dim Danh_sach_Hoc_sinh As List(Of DataRow) = Nghiep_vu.Danh_sach_Hoc_sinh_theo_Ho_ten(Du_lieu, Chuoi_Ho_ten)
        The_hien.Xuat_Danh_sach_Hoc_sinh(Danh_sach_Hoc_sinh, Th_Danh_sach_Hoc_sinh, Nothing)
        Th_Danh_sach_Hoc_sinh.AutoScroll = True
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Hoc_sinh.Count & " học sinh có họ tên chứa chuỗi  " & Chuoi_Ho_ten
        Th_Thong_bao.Text = Thong_bao
    End Sub
    Function Kiem_tra_Nhap_Chuoi_Ho_ten() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Chuoi_Ho_ten As String = Th_Chuoi_Ho_ten.Text.Trim
        Hop_le = Not Chuoi_Ho_ten.Contains("'") And Not Chuoi_Ho_ten.Contains("""")
        If Not Hop_le Then
            Kq &= "Chuỗi nhập không được chứa ' hay """
        End If
        Return Kq
    End Function
#End Region



End Class