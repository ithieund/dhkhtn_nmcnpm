
Partial Public Class XL_THE_HIEN


#Region "Thực đơn của ứng dụng"

    Public Sub Xuat_Thuc_don_tinh_cua_Ung_dung(
                                               Thuc_don As MenuStrip, Optional XL_Chon_Chuc_nang As EventHandler = Nothing)
        If XL_Chon_Chuc_nang Is Nothing Then
            XL_Chon_Chuc_nang = AddressOf XL_Kich_hoat_Chuc_nang
        End If
        Xuat_Thuc_don_tinh(Ung_dung.Danh_sach_Chuc_nang_cua_Ung_dung,
                           Thuc_don, XL_Chon_Chuc_nang)

        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Cong_ty,
                                                        Thuc_don.Items("CONG_TY"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Chi_nhanh,
                                                        Thuc_don.Items("CHI_NHANH"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Don_vi,
                                                        Thuc_don.Items("DON_VI"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Nhan_vien,
                                                        Thuc_don.Items("NHAN_VIEN"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Phieu_cong_tac,
                                                        Thuc_don.Items("PHIEU_CONG_TAC"), XL_Chon_Chuc_nang)


    End Sub

    Public Function Tao_Thuc_don_dong_cua_Ung_dung(
                                                   Th_Lien_ket As Control,
                                                 Optional XL_Chon_Chuc_nang As EventHandler = Nothing)
        If XL_Chon_Chuc_nang Is Nothing Then
            XL_Chon_Chuc_nang = AddressOf XL_Kich_hoat_Chuc_nang
        End If
        Dim Thuc_don As ContextMenuStrip = Tao_Thuc_don_dong(Ung_dung.Danh_sach_Chuc_nang_cua_Ung_dung,
                                                                                      Th_Lien_ket, XL_Chon_Chuc_nang)

        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Cong_ty,
                                                        Thuc_don.Items("CONG_TY"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Chi_nhanh,
                                                        Thuc_don.Items("CHI_NHANH"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Don_vi,
                                                        Thuc_don.Items("DON_VI"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Nhan_vien,
                                                        Thuc_don.Items("NHAN_VIEN"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_con_cua_Chuc_nang(Ung_dung.Danh_sach_Chuc_nang_cua_Phieu_cong_tac,
                                                        Thuc_don.Items("PHIEU_CONG_TAC"), XL_Chon_Chuc_nang)
        Return Thuc_don
    End Function

#End Region



#Region "Xử lý Biến cố - Chọn Chức năng "
    Public Sub XL_Kich_hoat_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        XL_Thay_doi_Trang_thai_The_hien(Th_Chuc_nang, Bc)
        Dim Chuc_nang As XL_CHUC_NANG = Th_Chuc_nang.Tag
        Dim Ma_so_Chon As String = Chuc_nang.Ma_so
        If Ma_so_Chon.StartsWith("TRA_CUU_PHIEU_CONG_TAC_") Then
            Dim Ma_so_Tra_cuu As String = Ma_so_Chon.Replace("TRA_CUU_PHIEU_CONG_TAC_", "")
            Dim Mh As New MH_Tra_cuu_Phieu_cong_tac(Ung_dung, Ma_so_Tra_cuu)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "GHI_MOI_PHIEU_CONG_TAC" Then
            Dim Mh As New MH_Nhap_lieu_Phieu_cong_tac(Ung_dung, "GHI_MOI")
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "CAP_NHAT_PHIEU_CONG_TAC" Then
            If Ung_dung.Danh_sach_Phieu_cong_tac.Count = 0 Then
                MsgBox("Danh sách phiếu công tác đang trống. Bạn không thể sử dụng chức năng này.")
                Return
            End If

            Dim Mh As New MH_Nhap_lieu_Phieu_cong_tac(Ung_dung, "CAP_NHAT")
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "XOA_PHIEU_CONG_TAC" Then
            If Ung_dung.Danh_sach_Phieu_cong_tac.Count = 0 Then
                MsgBox("Danh sách phiếu công tác đang trống. Bạn không thể sử dụng chức năng này.")
                Return
            End If

            Dim Mh As New MH_Nhap_lieu_Phieu_cong_tac(Ung_dung, "XOA")
            Mh.ShowDialog()
        End If

    End Sub
#End Region

End Class
