Partial Public Class XL_THE_HIEN

#Region "Danh sách - Biểu tượng"

    Sub Xuat_Danh_sach_Chi_nhanh(Danh_sach_Chi_nhanh As List(Of XL_CHI_NHANH),
                                          Th_Danh_sach_Chi_nhanh As ToolStrip, XL_Chon_Chi_nhanh As EventHandler)
        Dim Danh_sach_Chuoi_Tom_tat As List(Of String) = Danh_sach_Chi_nhanh.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin As List(Of String) = Danh_sach_Chi_nhanh.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh As List(Of String) = Danh_sach_Chi_nhanh.Select(
                                                                            Function(x) "Chi_nhanh_" & x.ID).ToList
        Xuat_Danh_sach_Doi_tuong(Danh_sach_Chi_nhanh, Danh_sach_Chuoi_Tom_tat,
                                                            Danh_sach_Chuoi_Thong_tin, Danh_sach_Ma_so_Hinh,
                                                        Th_Danh_sach_Chi_nhanh, XL_Chon_Chi_nhanh)
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Chi_nhanh.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = 8
        For Each Th_Chi_nhanh As ToolStripItem In Th_Danh_sach_Chi_nhanh.Items
            '==Định dạng thể hiện 
            Th_Chi_nhanh.TextImageRelation = TextImageRelation.ImageAboveText
            Th_Chi_nhanh.Size = New Size(160, 70)
            Th_Chi_nhanh.Font = New Font("Arial", 12)
            Th_Chi_nhanh.BackColor = Color.White
            Th_Chi_nhanh.ForeColor = Color.Navy
        Next

    End Sub



#End Region
#Region "Hồ sơ"
    Public Sub Khoi_dong_Ho_so_Chi_nhanh(Chi_nhanh As XL_CHI_NHANH, Th_Ho_so As Control)

        '===== Khởi động hồ sơ   

        '=== Kết xuất hồ sơ 
        If Chi_nhanh IsNot Nothing Then
            Xuat_Ho_so_Chi_nhanh(Chi_nhanh, Th_Ho_so)
        End If

    End Sub

    Public Sub Xuat_Ho_so_Chi_nhanh(Chi_nhanh As XL_CHI_NHANH, Th_Chi_nhanh As Control)
        Dim Th_Ten As Control = Th_Chi_nhanh.Controls("Th_Ten")
        Th_Ten.Text = Chi_nhanh.Ten
        Dim Th_Dien_thoai As Control = Th_Chi_nhanh.Controls("Th_Dien_thoai")
        Th_Dien_thoai.Text = Chi_nhanh.Dien_thoai
        Dim Th_Dia_chi As Control = Th_Chi_nhanh.Controls("Th_Dia_chi")
        Th_Dia_chi.Text = Chi_nhanh.Dia_chi

        Dim Th_Hinh As Control = Th_Chi_nhanh.Controls("Th_Hinh")
        Xuat_hinh("Chi_nhanh_" & Chi_nhanh.ID, Th_Hinh)


    End Sub

    Public Function Nhap_Ho_so_Chi_nhanh(Chi_nhanh As XL_CHI_NHANH, Th_Chi_nhanh As Control) As String
        Dim Kq As String = Kiem_Tra_Nhap_Ho_so_Chi_nhanh(Th_Chi_nhanh)
        If Kq = "" Then
            Dim Th_Ten As Control = Th_Chi_nhanh.Controls("Th_Ten")
            Chi_nhanh.Ten = Th_Ten.Text.Trim
            Dim Th_Dien_thoai As Control = Th_Chi_nhanh.Controls("Th_Dien_thoai")
            Chi_nhanh.Dien_thoai = Th_Dien_thoai.Text.Trim
            Dim Th_Dia_chi As Control = Th_Chi_nhanh.Controls("Th_Dia_chi")
            Chi_nhanh.Dia_chi = Th_Dia_chi.Text.Trim
        End If
        Return Kq
    End Function

    Function Kiem_Tra_Nhap_Ho_so_Chi_nhanh(Th_Chi_nhanh As Control) As String
        Dim Kq As String = ""

        Return Kq
    End Function
#End Region
End Class
