Partial Public Class XL_THE_HIEN

#Region "Danh sách - Biểu tượng"

    Sub Xuat_Danh_sach_Don_vi(Danh_sach_Don_vi As List(Of XL_DON_VI),
                                          Th_Danh_sach_Don_vi As ToolStrip, XL_Chon_Don_vi As EventHandler)
        Dim Danh_sach_Chuoi_Tom_tat As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) "Don_vi_" & x.ID).ToList
        Xuat_Danh_sach_Doi_tuong(Danh_sach_Don_vi, Danh_sach_Chuoi_Tom_tat,
                                                            Danh_sach_Chuoi_Thong_tin, Danh_sach_Ma_so_Hinh,
                                                        Th_Danh_sach_Don_vi, XL_Chon_Don_vi)
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Don_vi.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = 8
        For Each Th_Don_vi As ToolStripItem In Th_Danh_sach_Don_vi.Items
            '==Định dạng thể hiện 
            Th_Don_vi.TextImageRelation = TextImageRelation.ImageAboveText
            Th_Don_vi.Size = New Size(160, 70)
            Th_Don_vi.Font = New Font("Arial", 12)
            Th_Don_vi.BackColor = Color.White
            Th_Don_vi.ForeColor = Color.Navy
        Next

    End Sub



#End Region
#Region "Hồ sơ"
    Public Sub Khoi_dong_Ho_so_Don_vi(Don_vi As XL_DON_VI, Th_Ho_so As Control)

        '===== Khởi động hồ sơ   
        Dim Th_Danh_sach_Chi_nhanh As ToolStrip = Th_Ho_so.Controls("Th_Danh_sach_Chi_nhanh")
        Dim Danh_sach_Chi_nhanh As List(Of XL_CHI_NHANH) = Ung_dung.Danh_sach_Chi_nhanh
        Dim Danh_sach_Chuoi_Tom_tat_Chi_nhanh As List(Of String) = Danh_sach_Chi_nhanh.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Chi_nhanh As List(Of String) = Danh_sach_Chi_nhanh.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh_Chi_nhanh As List(Of String) = Danh_sach_Chi_nhanh.Select(
                                                                            Function(x) "CHI_NHANH_" & x.ID).ToList
        Xuat_Danh_sach_Chon_Doi_tuong(Danh_sach_Chi_nhanh,
                                                                                            Danh_sach_Chuoi_Tom_tat_Chi_nhanh,
                                                                                            Danh_sach_Chuoi_Thong_tin_Chi_nhanh,
                                                                                              Danh_sach_Ma_so_Hinh_Chi_nhanh,
                                                                                            Th_Danh_sach_Chi_nhanh, Nothing)
        '=== Kết xuất hồ sơ 
        If Don_vi IsNot Nothing Then
            Xuat_Ho_so_Don_vi(Don_vi, Th_Ho_so)
        End If

    End Sub

    Public Sub Xuat_Ho_so_Don_vi(Don_vi As XL_DON_VI, Th_Don_vi As Control)
        Dim Th_Ten As Control = Th_Don_vi.Controls("Th_Ten")
        Th_Ten.Text = Don_vi.Ten

        Dim Th_Hinh As Control = Th_Don_vi.Controls("Th_Hinh")
        Xuat_hinh("DON_VI_" & Don_vi.ID, Th_Hinh)
        Dim Th_Danh_sach_Chi_nhanh As ToolStrip = Th_Don_vi.Controls("Th_Danh_sach_Chi_nhanh")
        For Each Th_Chi_nhanh As ToolStripMenuItem In Th_Danh_sach_Chi_nhanh.Items
            Dim Chi_nhanh As XL_CHI_NHANH = Th_Chi_nhanh.Tag
            If Chi_nhanh.ID = Don_vi.ID_CHI_NHANH Then
                Th_Chi_nhanh.Checked = True
                XL_Thay_doi_Trang_thai_The_hien(Th_Chi_nhanh, Nothing)
            End If

        Next

    End Sub

    Public Function Nhap_Ho_so_Don_vi(Don_vi As XL_DON_VI, Th_Don_vi As Control) As String
        Dim Kq As String = Kiem_Tra_Nhap_Ho_so_Don_vi(Th_Don_vi)
        If Kq = "" Then
            Dim Th_Ten As Control = Th_Don_vi.Controls("Th_Ten")
            Don_vi.Ten = Th_Ten.Text.Trim
            Dim Th_Danh_sach_Chi_nhanh As ToolStrip = Th_Don_vi.Controls("Th_Danh_sach_Chi_nhanh")
            For Each Th_Chi_nhanh As ToolStripMenuItem In Th_Danh_sach_Chi_nhanh.Items
                Dim Chi_nhanh As XL_CHI_NHANH = Th_Chi_nhanh.Tag
                If Th_Chi_nhanh.Checked Then
                    Don_vi.ID_CHI_NHANH = Chi_nhanh.ID
                End If
            Next
        End If
        Return Kq
    End Function

    Function Kiem_Tra_Nhap_Ho_so_Don_vi(Th_Don_vi As Control) As String
        Dim Kq As String = ""

        Return Kq
    End Function
#End Region
End Class
