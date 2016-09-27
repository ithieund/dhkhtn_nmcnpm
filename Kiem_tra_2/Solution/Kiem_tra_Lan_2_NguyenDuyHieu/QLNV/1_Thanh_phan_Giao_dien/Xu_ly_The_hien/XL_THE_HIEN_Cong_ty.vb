Partial Public Class XL_THE_HIEN

#Region "Danh sách - Biểu tượng"

    Sub Xuat_Danh_sach_Cong_ty(Danh_sach_Cong_ty As List(Of XL_CONG_TY),
                                          Th_Danh_sach_Cong_ty As ToolStrip, XL_Chon_Cong_ty As EventHandler)
        Dim Danh_sach_Chuoi_Tom_tat As List(Of String) = Danh_sach_Cong_ty.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin As List(Of String) = Danh_sach_Cong_ty.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh As List(Of String) = Danh_sach_Cong_ty.Select(
                                                                            Function(x) "Cong_ty_" & x.ID).ToList
        Xuat_Danh_sach_Doi_tuong(Danh_sach_Cong_ty, Danh_sach_Chuoi_Tom_tat,
                                                            Danh_sach_Chuoi_Thong_tin, Danh_sach_Ma_so_Hinh,
                                                        Th_Danh_sach_Cong_ty, XL_Chon_Cong_ty)
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Cong_ty.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = 8
        For Each Th_Cong_ty As ToolStripItem In Th_Danh_sach_Cong_ty.Items
            '==Định dạng thể hiện 
            Th_Cong_ty.TextImageRelation = TextImageRelation.ImageAboveText
            Th_Cong_ty.Size = New Size(160, 70)
            Th_Cong_ty.Font = New Font("Arial", 12)
            Th_Cong_ty.BackColor = Color.White
            Th_Cong_ty.ForeColor = Color.Navy
        Next

    End Sub



#End Region
#Region "Hồ sơ"
    Public Sub Khoi_dong_Ho_so_Cong_ty(Cong_ty As XL_CONG_TY, Th_Ho_so As Control)

        '===== Khởi động hồ sơ   

        '=== Kết xuất hồ sơ 
        If Cong_ty IsNot Nothing Then
            Xuat_Ho_so_Cong_ty(Cong_ty, Th_Ho_so)
        End If

    End Sub

    Public Sub Xuat_Ho_so_Cong_ty(Cong_ty As XL_CONG_TY, Th_Cong_ty As Control)
        Dim Th_Ten As Control = Th_Cong_ty.Controls("Th_Ten")
        Th_Ten.Text = Cong_ty.Ten
        Dim Th_Dien_thoai As Control = Th_Cong_ty.Controls("Th_Dien_thoai")
        Th_Dien_thoai.Text = Cong_ty.Dien_thoai
        Dim Th_Dia_chi As Control = Th_Cong_ty.Controls("Th_Dia_chi")
        Th_Dia_chi.Text = Cong_ty.Dia_chi
        Dim Th_Tuoi_toi_thieu As Control = Th_Cong_ty.Controls("Th_Tuoi_toi_thieu")
        Th_Tuoi_toi_thieu.Text = Cong_ty.Tuoi_toi_thieu
        Dim Th_Tuoi_toi_da As Control = Th_Cong_ty.Controls("Th_Tuoi_toi_da")
        Th_Tuoi_toi_da.Text = Cong_ty.Tuoi_toi_da
        Dim Th_Muc_luong_toi_thieu As Control = Th_Cong_ty.Controls("Th_Muc_luong_toi_thieu")
        Th_Muc_luong_toi_thieu.Text = Cong_ty.Muc_luong_toi_thieu

        Dim Th_Hinh As Control = Th_Cong_ty.Controls("Th_Hinh")
        Xuat_hinh("Cong_ty_" & Cong_ty.ID, Th_Hinh)


    End Sub

    Public Function Nhap_Ho_so_Cong_ty(Cong_ty As XL_CONG_TY, Th_Cong_ty As Control) As String
        Dim Kq As String = Kiem_Tra_Nhap_Ho_so_Cong_ty(Th_Cong_ty)
        If Kq = "" Then
            Dim Th_Ten As Control = Th_Cong_ty.Controls("Th_Ten")
            Cong_ty.Ten = Th_Ten.Text.Trim
            Dim Th_Dien_thoai As Control = Th_Cong_ty.Controls("Th_Dien_thoai")
            Cong_ty.Dien_thoai = Th_Dien_thoai.Text.Trim
            Dim Th_Dia_chi As Control = Th_Cong_ty.Controls("Th_Dia_chi")
            Cong_ty.Dia_chi = Th_Dia_chi.Text.Trim
            Dim Th_Tuoi_toi_thieu As Control = Th_Cong_ty.Controls("Th_Tuoi_toi_thieu")
            Cong_ty.Tuoi_toi_thieu = Th_Tuoi_toi_thieu.Text.Trim
            Dim Th_Tuoi_toi_da As Control = Th_Cong_ty.Controls("Th_Tuoi_toi_da")
            Cong_ty.Tuoi_toi_da = Th_Tuoi_toi_da.Text.Trim
            Dim Th_Muc_luong_toi_thieu As Control = Th_Cong_ty.Controls("Th_Muc_luong_toi_thieu")
            Cong_ty.Muc_luong_toi_thieu = Th_Muc_luong_toi_thieu.Text.Trim
        End If
        Return Kq
    End Function

    Function Kiem_Tra_Nhap_Ho_so_Cong_ty(Th_Cong_ty As Control) As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim So_nguyen As Integer
        Dim Th_Tuoi_Toi_thieu As Control = Th_Cong_ty.Controls("Th_Tuoi_Toi_thieu")
        Hop_le = Integer.TryParse(Th_Tuoi_Toi_thieu.Text.Trim, So_nguyen)
        If Not Hop_le Then
            Kq &= "Tuổi  tối thiểu phải là số nguyên " & vbCrLf
        End If
        Dim Th_Tuoi_Toi_da As Control = Th_Cong_ty.Controls("Th_Tuoi_Toi_da")
        Hop_le = Integer.TryParse(Th_Tuoi_Toi_da.Text.Trim, So_nguyen)
        If Not Hop_le Then
            Kq &= "Tuổi  tối đa phải là số nguyên " & vbCrLf
        End If

        Dim Th_Muc_luong_Toi_thieu As Control = Th_Cong_ty.Controls("Th_Muc_luong_Toi_thieu")
        Hop_le = Integer.TryParse(Th_Muc_luong_Toi_thieu.Text.Trim, So_nguyen)
        If Not Hop_le Then
            Kq &= "Mức lương tối thiểu phải là số nguyên " & vbCrLf
        End If
        Return Kq
    End Function
#End Region
End Class
