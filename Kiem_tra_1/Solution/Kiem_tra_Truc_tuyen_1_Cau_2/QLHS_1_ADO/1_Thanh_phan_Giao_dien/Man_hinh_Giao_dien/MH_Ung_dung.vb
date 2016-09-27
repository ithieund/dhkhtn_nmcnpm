


Public Class MH_Ung_dung

#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Nghiep_vu As XL_NGHIEP_VU
    Protected The_hien As XL_THE_HIEN
    Protected Du_lieu As DataSet
#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Luu_tru = New XL_LUU_TRU
        Nghiep_vu = New XL_NGHIEP_VU
        The_hien = New XL_THE_HIEN
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '1 ==== Khởi động dữ liệu
        Du_lieu = Luu_tru.Doc_Du_lieu
        '2 ===== Khởi động thể hiện
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Quản lý học sinh 1 - ADO - Bài kiểm tra thực hành trực tuyến  "
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh
        The_hien.Xuat_Thuc_don_Ttnh_cua_Ung_dung(Thuc_don, AddressOf XL_Chon_Chuc_nang)
        '===Thực đơn động 
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Me, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo 
        Th_Thong_bao.Padding = New Padding(10)
        Dim Thong_bao As String = ""
        Th_Thong_bao.Text = Thong_bao
    End Sub
#End Region

#Region "Xử lý Biến cố Chính - Chọn chức năng "
    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Ma_so_Chon As String = Th_Chuc_nang.Tag
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
        ElseIf Ma_so_Chon = "TRA_CUU_HOC_SINH_LOP" Then
            Dim Mh As New MH_Tra_cuu_Hoc_sinh_Lop(Du_lieu)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "TRA_CUU_HOC_SINH_HO_TEN" Then
            Dim Mh As New MH_Tra_cuu_Hoc_sinh_theo_Ho_ten(Du_lieu)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "GHI_MOI_HOC_SINH" Then
            Dim Mh As New MH_Ghi_moi_Hoc_sinh(Du_lieu)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "CAP_NHAT_HOC_SINH" Then
            'Dim Mh As New MH_Cap_nhat_Hoc_sinh(Du_lieu)
            'Mh.ShowDialog()
        ElseIf Ma_so_Chon = "XOA_HOC_SINH" Then
            'Dim Mh As New MH_Xoa_Hoc_sinh(Du_lieu)
            'Mh.ShowDialog()
        ElseIf Ma_so_Chon = "THONG_KE_HOC_SINH_LOP" Then
            'Dim Mh As New MH_Thong_ke_Hoc_sinh_Lop(Du_lieu)
            'Mh.ShowDialog()


            '=== Chức năng của Loại đối tượng Trường
        ElseIf Ma_so_Chon = "CAP_NHAT_TRUONG" Then
            '=== Chức năng của Loại đối tượng Khối
        ElseIf Ma_so_Chon = "CAP_NHAT_KHOI" Then


            '=== Chức năng của Loại đối tượng lớp
        ElseIf Ma_so_Chon = "GHI_MOI_LOP" Then

        ElseIf Ma_so_Chon = "CAP_NHAT_LOP" Then

        ElseIf Ma_so_Chon = "XOA_LOP" Then

        End If

    End Sub

#End Region




End Class