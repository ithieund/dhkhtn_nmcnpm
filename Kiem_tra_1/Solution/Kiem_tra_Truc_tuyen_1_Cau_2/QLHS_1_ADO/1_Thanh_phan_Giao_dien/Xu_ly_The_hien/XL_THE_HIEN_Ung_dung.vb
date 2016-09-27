Partial Public Class XL_THE_HIEN


#Region "Thực đơn của ứng dụng"

    Public Sub Xuat_Thuc_don_Ttnh_cua_Ung_dung(
                                               Thuc_don As MenuStrip, XL_Chon_Chuc_nang As EventHandler)
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                     "Trường", "Khối", "Lớp", "Học sinh", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                      "TRUONG", "KHOI", "LOP", "HOC_SINH", "KET_THUC"}.ToList
        Xuat_Thuc_don_tinh(Danh_sach_Ten_Chuc_nang, Danh_sach_Ma_so_Chuc_nang,
                           Thuc_don, XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Truong(Thuc_don.Items("TRUONG"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Khoi(Thuc_don.Items("KHOI"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Lop(Thuc_don.Items("LOP"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Hoc_sinh(Thuc_don.Items("HOC_SINH"), XL_Chon_Chuc_nang)
    End Sub

    Public Function Tao_Thuc_don_dong_cua_Ung_dung(
                                                   Th_Lien_ket As Control,
                                                   XL_Chon_Chuc_nang As EventHandler) As ContextMenuStrip
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                     "Trường", "Khối", "Lớp", "Học sinh", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                      "TRUONG", "KHOI", "LOP", "HOC_SINH", "KET_THUC"}.ToList
        Dim Thuc_don_dong As ContextMenuStrip = Tao_Thuc_don_dong(Danh_sach_Ten_Chuc_nang,
                                                                                    Danh_sach_Ma_so_Chuc_nang,
                                                                                      Th_Lien_ket, XL_Chon_Chuc_nang)

        Xuat_Chuc_nang_Con_cua_Truong(Thuc_don_dong.Items("TRUONG"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Khoi(Thuc_don_dong.Items("KHOI"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Lop(Thuc_don_dong.Items("LOP"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Hoc_sinh(Thuc_don_dong.Items("HOC_SINH"), XL_Chon_Chuc_nang)
        Return Thuc_don_dong
    End Function

#End Region

#Region "Chứng năng con theo từng loại đối tượng "

    Protected Sub Xuat_Chuc_nang_Con_cua_Truong(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "TRUONG" ' Loại đối tượng Tổ chức cấp 0 ( Cấp cao nhất của ứng dụng )
        Dim Danh_sach_Ten As List(Of String) = New String() {"Thống kê  số lượng học sinh của từng lớp", "Cập nhật thông tin"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {"THONG_KE_HOC_SINH_LOP", "CAP_NHAT_" & Loai_doi_tuong}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so, Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
    Protected Sub Xuat_Chuc_nang_Con_cua_Khoi(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "KHOI" 'Loại đối tượng Tổ chức cấp 2
        Dim Danh_sach_Ten As List(Of String) = New String() {"Cập nhật Qui định tuổi học sinh"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                                   "CAP_NHAT_" & Loai_doi_tuong}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)
    End Sub

    Protected Sub Xuat_Chuc_nang_Con_cua_Lop(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "LOP" 'Loại đối tượng Tổ chức cấp 2
        Dim Danh_sach_Ten As List(Of String) = New String() {"Thêm mới", "Cập nhật", "Xóa"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                                      "GHI_MOI_" & Loai_doi_tuong, "CAP_NHAT_" & Loai_doi_tuong, "XOA_" & Loai_doi_tuong}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
    Protected Sub Xuat_Chuc_nang_Con_cua_Hoc_sinh(Chuc_nang As ToolStripMenuItem,
                                                                XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "HOC_SINH" ' Loại đối tượng Con người - Đối tượng Quản lý chính của ứng dụng
        Dim Danh_sach_Ten As List(Of String) = New String() {
                            "Tra cứu theo lớp", "Tra cứu theo họ tên",
                            "Thêm mới", "Cập nhật", "Xóa",
                              "Thống kê  theo lớp"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                          "TRA_CUU_" & Loai_doi_tuong & "_LOP", "TRA_CUU_" & Loai_doi_tuong & "_HO_TEN",
                           "GHI_MOI_" & Loai_doi_tuong, "CAP_NHAT_" & Loai_doi_tuong, "XOA_" & Loai_doi_tuong,
                           "THONG_KE_" & Loai_doi_tuong & "_LOP"}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)

    End Sub
#End Region



End Class
