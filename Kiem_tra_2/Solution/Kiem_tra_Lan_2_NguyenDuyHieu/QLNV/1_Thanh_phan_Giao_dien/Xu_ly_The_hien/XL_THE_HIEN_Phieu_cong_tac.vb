Partial Public Class XL_THE_HIEN
#Region "Danh sách - Biểu tượng"

    Sub Xuat_Danh_sach_Phieu_cong_tac(Danh_sach_Phieu_cong_tac As List(Of XL_PHIEU_CONG_TAC),
                                          Th_Danh_sach_Phieu_cong_tac As ToolStrip, XL_Chon_Phieu_cong_tac As EventHandler)
        Dim Danh_sach_Chuoi_Tom_tat As List(Of String) = Danh_sach_Phieu_cong_tac.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin As List(Of String) = Danh_sach_Phieu_cong_tac.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList
        Dim Danh_sach_Ma_so_Hinh As List(Of String) = Danh_sach_Phieu_cong_tac.Select(
                                                                            Function(x) "PHIEU_CONG_TAC" & x.ID).ToList
        Xuat_Danh_sach_Doi_tuong(Danh_sach_Phieu_cong_tac, Danh_sach_Chuoi_Tom_tat,
                                                            Danh_sach_Chuoi_Thong_tin, Danh_sach_Ma_so_Hinh,
                                                        Th_Danh_sach_Phieu_cong_tac, XL_Chon_Phieu_cong_tac)
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Phieu_cong_tac.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = 6
        For Each Th_Phieu_cong_tac As ToolStripItem In Th_Danh_sach_Phieu_cong_tac.Items
            '==Định dạng thể hiện 
            Th_Phieu_cong_tac.TextImageRelation = TextImageRelation.ImageAboveText
            Th_Phieu_cong_tac.Size = New Size(200, 70)
            Th_Phieu_cong_tac.Font = New Font("Arial", 12)
            Th_Phieu_cong_tac.BackColor = Color.White
            Th_Phieu_cong_tac.ForeColor = Color.Navy
        Next

    End Sub

#End Region

#Region "Hồ sơ"

    Public Sub Khoi_dong_Ho_so_Phieu_cong_tac(Phieu_cong_tac As XL_PHIEU_CONG_TAC, Th_Phieu_cong_tac As Control)
        '===== Khởi động hồ sơ
        '=== Kết xuất hồ sơ 
        If Phieu_cong_tac IsNot Nothing Then
            Xuat_Ho_so_Phieu_cong_tac(Phieu_cong_tac, Th_Phieu_cong_tac)
        End If

    End Sub

    Public Sub Xuat_Ho_so_Phieu_cong_tac(Phieu_cong_tac As XL_PHIEU_CONG_TAC, Th_Phieu_cong_tac As Control)
        Dim Th_Nhan_vien As Control = Th_Phieu_cong_tac.Controls("Th_Nhan_vien")
        Th_Nhan_vien.Text = Phieu_cong_tac.Nhan_vien.Ho_ten
        Th_Nhan_vien.Tag = Phieu_cong_tac.ID_NHAN_VIEN
        Dim Th_Tinh_thanh_pho As Control = Th_Phieu_cong_tac.Controls("Th_Tinh_thanh_pho")
        Th_Tinh_thanh_pho.Text = Phieu_cong_tac.Tinh_thanh_pho
        Dim Th_Ngay_Bat_dau As DateTimePicker = Th_Phieu_cong_tac.Controls("Th_Ngay_Bat_dau")
        Th_Ngay_Bat_dau.Value = Phieu_cong_tac.Ngay_bat_dau
        Dim Th_So_ngay As Control = Th_Phieu_cong_tac.Controls("Th_So_ngay")
        Th_So_ngay.Text = Phieu_cong_tac.So_ngay
    End Sub

    Public Function Nhap_Ho_so_Phieu_cong_tac(Phieu_cong_tac As XL_PHIEU_CONG_TAC, Th_Phieu_cong_tac As Control) As String
        Dim Kq As String = Kiem_Tra_Nhap_Ho_so_Phieu_cong_tac(Th_Phieu_cong_tac)
        If Kq = "" Then
            Dim Th_Nhan_vien As Control = Th_Phieu_cong_tac.Controls("Th_Nhan_vien")
            Phieu_cong_tac.ID_NHAN_VIEN = Th_Nhan_vien.Tag
            Dim Th_Tinh_thanh_pho As Control = Th_Phieu_cong_tac.Controls("Th_Tinh_thanh_pho")
            Phieu_cong_tac.Tinh_thanh_pho = Th_Tinh_thanh_pho.Text.Trim
            Dim Th_Ngay_Bat_dau As Control = Th_Phieu_cong_tac.Controls("Th_Ngay_Bat_dau")
            Phieu_cong_tac.Ngay_bat_dau = Th_Ngay_Bat_dau.Text.Trim
            Dim Th_So_ngay As Control = Th_Phieu_cong_tac.Controls("Th_So_ngay")
            Phieu_cong_tac.So_ngay = Th_So_ngay.Text.Trim
        End If
        Return Kq
    End Function

    Function Kiem_Tra_Nhap_Ho_so_Phieu_cong_tac(Th_Phieu_cong_tac As Control) As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim So_nguyen As Integer

        Dim Th_So_ngay As Control = Th_Phieu_cong_tac.Controls("Th_So_ngay")
        Hop_le = Integer.TryParse(Th_So_ngay.Text.Trim, So_nguyen) AndAlso So_nguyen > 0
        If Not Hop_le Then
            Kq &= "Số ngày phải là số nguyên dương" & vbCrLf
        End If
        Return Kq
    End Function
#End Region

End Class
