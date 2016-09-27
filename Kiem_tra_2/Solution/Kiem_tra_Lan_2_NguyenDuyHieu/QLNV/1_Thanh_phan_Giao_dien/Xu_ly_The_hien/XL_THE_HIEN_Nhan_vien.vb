Partial Public Class XL_THE_HIEN
#Region "Danh sách - Biểu tượng"

    Sub Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN),
                                          Th_Danh_sach_Nhan_vien As ToolStrip, XL_Chon_Nhan_vien As EventHandler)
        Dim Danh_sach_Chuoi_Tom_tat As List(Of String) = Danh_sach_Nhan_vien.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin As List(Of String) = Danh_sach_Nhan_vien.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh As List(Of String) = Danh_sach_Nhan_vien.Select(
                                                                            Function(x) "NHAN_VIEN_" & x.ID).ToList
        Xuat_Danh_sach_Doi_tuong(Danh_sach_Nhan_vien, Danh_sach_Chuoi_Tom_tat,
                                                            Danh_sach_Chuoi_Thong_tin, Danh_sach_Ma_so_Hinh,
                                                        Th_Danh_sach_Nhan_vien, XL_Chon_Nhan_vien)
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Nhan_vien.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = 6
        For Each Th_Nhan_vien As ToolStripItem In Th_Danh_sach_Nhan_vien.Items
            '==Định dạng thể hiện 
            Th_Nhan_vien.TextImageRelation = TextImageRelation.ImageAboveText
            Th_Nhan_vien.Size = New Size(200, 70)
            Th_Nhan_vien.Font = New Font("Arial", 12)
            Th_Nhan_vien.BackColor = Color.White
            Th_Nhan_vien.ForeColor = Color.Navy
        Next

    End Sub
    Sub Xuat_Danh_sach_Thong_ke_Nhan_vien_theo_Don_vi(Th_Danh_sach_Thong_ke As ToolStrip, XL_Chon_Don_vi As EventHandler)


        Dim Danh_sach_Don_vi As List(Of XL_DON_VI) = Ung_dung.Danh_sach_Don_vi
        Dim Danh_sach_Chuoi_Tom_tat_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) "DON_VI_" & x.ID).ToList
        Xuat_Danh_sach_Thong_ke(Danh_sach_Don_vi,
                                                                                          Danh_sach_Chuoi_Tom_tat_Don_vi,
                                                                                           Danh_sach_Chuoi_Thong_tin_Don_vi,
                                                                                          Danh_sach_Ma_so_Hinh_Don_vi,
                                                                                           Th_Danh_sach_Thong_ke, Nothing)

        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Thong_ke.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = 1
        Th_Danh_sach_Thong_ke.BackColor = Color.Black
        Th_Danh_sach_Thong_ke.ForeColor = Color.White

        For Each Th_Don_vi As ToolStripItem In Th_Danh_sach_Thong_ke.Items
            Dim Don_vi As XL_DON_VI = Th_Don_vi.Tag
            '=== Xuất lại Tóm tắt
            Dim Ten As String = Don_vi.Tao_Chuoi_Tom_tat()
            Dim So_luong As Integer = Don_vi.Danh_sach_Nhan_vien.Count
            Dim Tong_so As Integer = Ung_dung.Danh_sach_Nhan_vien().Count
            Dim Ty_le As Double = So_luong * 100 / Tong_so
            Dim Chuoi_Thong_ke As String = String.Format("{0,-25} {1,-15} {2,-5} %", Ten, So_luong.ToString, Math.Round(Ty_le, 2).ToString)
            Th_Don_vi.Text = Chuoi_Thong_ke

            '=== Định dạng thể hiện lại
            Th_Don_vi.Size = New Size(400, 40)
            Th_Don_vi.ImageAlign = ContentAlignment.MiddleLeft
            Th_Don_vi.TextAlign = ContentAlignment.MiddleRight
        Next

    End Sub


#End Region

#Region "Hồ sơ"

    Public Sub Khoi_dong_Ho_so_Nhan_vien(Nhan_vien As XL_NHAN_VIEN, Th_Nhan_vien As Control)
        '===== Khởi động hồ sơ 

        '===== Đối tượng liên kết : Danh sách đơn vị
        Dim Th_Danh_sach_Don_vi As ToolStrip = Th_Nhan_vien.Controls("Th_Danh_sach_Don_vi")

        'Thông báo PET : Sẽ còn tiếp tục cải tiến trong  phiên bản sau
        Dim Danh_sach_Don_vi As List(Of XL_DON_VI) = Ung_dung.Danh_sach_Don_vi
        Dim Danh_sach_Chuoi_Tom_tat_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) "DON_VI_" & x.ID).ToList
        Xuat_Danh_sach_Chon_Doi_tuong(Danh_sach_Don_vi,
                                                                                          Danh_sach_Chuoi_Tom_tat_Don_vi,
                                                                                           Danh_sach_Chuoi_Thong_tin_Don_vi,
                                                                                          Danh_sach_Ma_so_Hinh_Don_vi,
                                                                                           Th_Danh_sach_Don_vi, Nothing)

        '=== Kết xuất hồ sơ 
        If Nhan_vien IsNot Nothing Then
            Xuat_Ho_so_Nhan_vien(Nhan_vien, Th_Nhan_vien)
        End If

    End Sub

    Public Sub Xuat_Ho_so_Nhan_vien(Nhan_vien As XL_NHAN_VIEN, Th_Nhan_vien As Control)
        Dim Th_Ho_ten As Control = Th_Nhan_vien.Controls("Th_Ho_ten")
        Th_Ho_ten.Text = Nhan_vien.Ho_ten
        Dim Th_Ngay_sinh As Control = Th_Nhan_vien.Controls("Th_Ngay_sinh")
        Th_Ngay_sinh.Text = Nhan_vien.Ngay_sinh
        Dim Th_CMND As Control = Th_Nhan_vien.Controls("Th_CMND")
        Th_CMND.Text = Nhan_vien.CMND
        Dim Th_Muc_luong As Control = Th_Nhan_vien.Controls("Th_Muc_luong")
        Th_Muc_luong.Text = Nhan_vien.Muc_luong
        Dim Th_Dia_chi As Control = Th_Nhan_vien.Controls("Th_Dia_chi")
        Th_Dia_chi.Text = Nhan_vien.Dia_chi
        Dim Th_Hinh As Control = Th_Nhan_vien.Controls("Th_Hinh")
        Xuat_hinh("NHAN_VIEN_" & Nhan_vien.ID, Th_Hinh)

        Dim Th_Danh_sach_Don_vi As ToolStrip = Th_Nhan_vien.Controls("Th_Danh_sach_Don_vi")
        For Each Th_Don_vi As ToolStripMenuItem In Th_Danh_sach_Don_vi.Items
            Dim Don_vi As XL_DON_VI = Th_Don_vi.Tag
            If Don_vi.ID = Nhan_vien.ID_DON_VI Then
                Th_Don_vi.Checked = True
                XL_Thay_doi_Trang_thai_The_hien(Th_Don_vi, Nothing)
            End If
        Next
    End Sub

    Public Function Nhap_Ho_so_Nhan_vien(Nhan_vien As XL_NHAN_VIEN, Th_Nhan_vien As Control) As String
        Dim Kq As String = Kiem_Tra_Nhap_Ho_so_Nhan_vien(Th_Nhan_vien)
        If Kq = "" Then
            Dim Th_Ho_ten As Control = Th_Nhan_vien.Controls("Th_Ho_ten")
            Nhan_vien.Ho_ten = Th_Ho_ten.Text.Trim
            Dim Th_Ngay_sinh As Control = Th_Nhan_vien.Controls("Th_Ngay_sinh")
            Nhan_vien.Ngay_sinh = Th_Ngay_sinh.Text.Trim
            Dim Th_CMND As Control = Th_Nhan_vien.Controls("Th_CMND")
            Nhan_vien.CMND = Th_CMND.Text.Trim
            Dim Th_Muc_luong As Control = Th_Nhan_vien.Controls("Th_Muc_luong")
            Nhan_vien.Muc_luong = Th_Muc_luong.Text.Trim
            Dim Th_Dia_chi As Control = Th_Nhan_vien.Controls("Th_Dia_chi")
            Nhan_vien.Dia_chi = Th_Dia_chi.Text.Trim

            Dim Th_Danh_sach_Don_vi As ToolStrip = Th_Nhan_vien.Controls("Th_Danh_sach_Don_vi")
            For Each Th_Don_vi As ToolStripMenuItem In Th_Danh_sach_Don_vi.Items
                Dim Don_vi As XL_DON_VI = Th_Don_vi.Tag
                If Th_Don_vi.Checked Then
                    Nhan_vien.ID_DON_VI = Don_vi.ID
                End If
            Next
        End If
        Return Kq
    End Function

    Function Kiem_Tra_Nhap_Ho_so_Nhan_vien(Th_Nhan_vien As Control) As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Ngay As Date
        Dim So_nguyen As Integer
        Dim Th_Ngay_sinh As Control = Th_Nhan_vien.Controls("Th_Ngay_sinh")
        Hop_le = DateTime.TryParse(Th_Ngay_sinh.Text.Trim, Ngay)
        If Not Hop_le Then
            Kq &= "Ngày sinh phải có dạng dd/mm/yy " & vbCrLf
        End If
        Dim Th_Muc_luong As Control = Th_Nhan_vien.Controls("Th_Muc_luong")
        Hop_le = Integer.TryParse(Th_Muc_luong.Text.Trim, So_nguyen)
        If Not Hop_le Then
            Kq &= "Mức lương phải là số nguyên " & vbCrLf
        End If
        Return Kq
    End Function
#End Region

End Class
