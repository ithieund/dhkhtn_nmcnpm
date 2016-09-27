Public Class MH_Them_moi_Nhan_vien
#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU(LOAI_CSDL.Acesss)
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN

    Dim Du_lieu As DataSet
    Dim Nhan_vien As DataRow
    Dim Du_lieu_Hinh As Byte()
#End Region

#Region "Xử lý Khởi động"
    Public Sub New(Du_lieu As DataSet)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Du_lieu = Du_lieu
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '==== Khởi động dữ liệu :  
        Nhan_vien = Nghiep_vu.Tao_Nhan_vien_moi(Du_lieu)
        Du_lieu_Hinh = Luu_tru.Doc_Du_lieu_Hinh(Nhan_vien)
        '===Khởi động thể hiện ===
        Me.WindowState = FormWindowState.Maximized
        Xuat_Danh_sach_Don_vi()
        Xuat_Nhan_vien()
        AddHandler Th_Dong_y.Click, AddressOf XL_Chon_Dong_y
        AddHandler Th_Hinh.Click, AddressOf XL_Chon_Hinh
    End Sub



#End Region

#Region "Xử lý Biến cố"
    Sub XL_Chon_Dong_y(Th_Dong_y As Control, Bc As EventArgs)
        Dim Chuoi_loi As String = Nhap_Nhan_vien()
        If Chuoi_loi = "" Then
            Chuoi_loi = Nghiep_vu.Kiem_tra_Ghi_moi_Nhan_vien(Nhan_vien)
            If Chuoi_loi = "" Then
                Chuoi_loi = Luu_tru.Ghi_moi(Nhan_vien)
                If Chuoi_loi = "" Then
                    Chuoi_loi = Luu_tru.Ghi_Du_lieu_Hinh(Nhan_vien, Du_lieu_Hinh)
                End If
            End If
        End If


        If Chuoi_loi = "" Then
            Th_Thong_bao.Text = "Đã ghi hồ sơ mới"

            Nhan_vien = Nghiep_vu.Tao_Nhan_vien_moi(Du_lieu)
            Du_lieu_Hinh = Luu_tru.Doc_Du_lieu_Hinh(Nhan_vien)
            Xuat_Nhan_vien()
        Else
            Th_Thong_bao.Text = Chuoi_loi
        End If
    End Sub

    Sub XL_Chon_Hinh(Th_Hinh As Control, Bc As EventArgs)
        Dim Chon_Tap_tin As New OpenFileDialog
        Chon_Tap_tin.InitialDirectory = Luu_tru.Thu_muc_Hinh
        '===== Chọn hình 
        If Chon_Tap_tin.ShowDialog() = DialogResult.OK Then
            Dim Duong_dan As String = Chon_Tap_tin.FileName
            Try
                '==== Đọc hình chọn
                Dim Du_lieu_Hinh_Chon As Byte() = IO.File.ReadAllBytes(Duong_dan)
                '=== Xuất hình chọn 
                Dim Luong As New IO.MemoryStream(Du_lieu_Hinh_Chon)
                Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
                Th_Hinh.BackgroundImage = Hinh
                Th_Hinh.BackgroundImageLayout = ImageLayout.Stretch
                Du_lieu_Hinh = Du_lieu_Hinh_Chon
            Catch ex As Exception
                Th_Thong_bao.Text = "Hình chọn không hợp lệ"
            End Try

        End If
    End Sub


#End Region

#Region "Xử lý Thê hiện (Nhập/Xuất) "
    Sub Xuat_Danh_sach_Don_vi()
        Dim Danh_sach_Don_vi As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList
        For Each Don_vi As DataRow In Danh_sach_Don_vi
            '=== Tạo thể hiện : Don_vi ---> Th_Don_vi
            Dim Th_Don_vi As New RadioButton
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Don_vi("Ten")
            Th_Don_vi.Text = Chuoi_Tom_tat
            '==Định dạng thể hiện 
            Th_Don_vi.Size = New Size(100, 40)
            Th_Don_vi.Font = New Font("Arial", 12)

            Th_Don_vi.ForeColor = Color.White

            Th_Don_vi.Tag = Don_vi
        Next
    End Sub
    Sub Xuat_Nhan_vien()
        Th_Ho_ten.Text = Nhan_vien("Ho_ten")
        Th_Gioi_tinh.Checked = Nhan_vien("Gioi_tinh")
        Th_CMND.Text = Nhan_vien("CMND")
        Th_Ngay_sinh.Text = Nhan_vien("Ngay_sinh")
        Th_Muc_luong.Text = Nhan_vien("Muc_luong")
        Th_Dia_chi.Text = Nhan_vien("Dia_chi")
        For Each Th_Don_vi As RadioButton In Th_Danh_sach_Don_vi.Controls
            Dim Don_vi As DataRow = Th_Don_vi.Tag
            If Nhan_vien("ID_DON_VI") = Don_vi("ID") Then
                Th_Don_vi.Checked = True
            End If
        Next
        Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
        Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
        Th_Hinh.BackgroundImage = Hinh
        Th_Hinh.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    Function Nhap_Nhan_vien() As String
        Dim Kq As String = Kiem_tra_Nhap_Nhap_Nhan_vien()
        If Kq = "" Then
            Nhan_vien("Ho_ten") = Th_Ho_ten.Text.Trim
            Nhan_vien("Gioi_tinh") = Th_Gioi_tinh.Checked
            Nhan_vien("CMND") = Th_CMND.Text.Trim
            Nhan_vien("Ngay_sinh") = Th_Ngay_sinh.Text.Trim
            Nhan_vien("Muc_luong") = Th_Muc_luong.Text.Trim
            Nhan_vien("Dia_chi") = Th_Dia_chi.Text.Trim
            For Each Th_Don_vi As RadioButton In Th_Danh_sach_Don_vi.Controls
                Dim Don_vi As DataRow = Th_Don_vi.Tag
                If Th_Don_vi.Checked Then
                    Nhan_vien("ID_DON_VI") = Don_vi("ID")
                End If
            Next
        End If

        Return Kq
    End Function
    Function Kiem_tra_Nhap_Nhap_Nhan_vien() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Hop_le = IsNumeric(Th_Muc_luong.Text.Trim)
        If Not Hop_le Then
            Kq &= "Mức lương không hợp lệ" & vbCrLf
        End If
        Hop_le = IsDate(Th_Ngay_sinh.Text.Trim)
        If Not Hop_le Then
            Kq &= "Ngày sinh không hợp lệ" & vbCrLf
        End If

        Return Kq
    End Function
#End Region
End Class