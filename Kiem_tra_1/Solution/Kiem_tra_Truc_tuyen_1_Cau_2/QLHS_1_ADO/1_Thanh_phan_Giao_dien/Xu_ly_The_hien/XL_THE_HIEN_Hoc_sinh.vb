Partial Public Class XL_THE_HIEN

#Region "Danh sách - Biểu tượng"
    Sub Xuat_Danh_sach_Hoc_sinh(Danh_sach_Hoc_sinh As List(Of DataRow),
                                          Th_Danh_sach_Hoc_sinh As FlowLayoutPanel, XL_Chon_Hoc_sinh As EventHandler)
        Th_Danh_sach_Hoc_sinh.Controls.Clear()
        For Each Hoc_sinh As DataRow In Danh_sach_Hoc_sinh
            '=== Tạo thể hiện : Hoc_sinh --> Th_Hoc_sinh
            Dim Th_Hoc_sinh As New Button
            Th_Danh_sach_Hoc_sinh.Controls.Add(Th_Hoc_sinh)
            '=== Xuất Tóm tắt

            Th_Hoc_sinh.Text = Nghiep_vu.Tao_Chuoi_Tom_tat_Hoc_sinh(Hoc_sinh)
            '=== Xuất Thông tin dạng ghi chú 
            Dim Chuoi_Thong_tin As String = Nghiep_vu.Tao_Chuoi_Thong_tin_Hoc_sinh(Hoc_sinh)
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Hoc_sinh, Chuoi_Thong_tin)
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Hoc_sinh, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Hoc_sinh.Image = New Bitmap(Hinh, 30, 30)

            '==Định dạng thể hiện 
            Th_Hoc_sinh.TextImageRelation = TextImageRelation.ImageAboveText
            Th_Hoc_sinh.Size = New Size(220, 85)
            Th_Hoc_sinh.Font = New Font("Arial", 14)
            Th_Hoc_sinh.BackColor = Color.White
            Th_Hoc_sinh.ForeColor = Color.Navy
            '===Chuẩn bị biến cố chọn 
            Th_Hoc_sinh.Tag = Hoc_sinh
            If XL_Chon_Hoc_sinh IsNot Nothing Then
                AddHandler Th_Hoc_sinh.Click, XL_Chon_Hoc_sinh
            End If
        Next

    End Sub
#End Region

#Region "Hồ sơ"
    Public Sub Xuat_Ho_so_Hoc_sinh(Hoc_sinh As DataRow, Th_Hoc_sinh As Control)
        Dim Th_Ho_ten As Control = Th_Hoc_sinh.Controls("Th_Ho_ten")
        Th_Ho_ten.Text = Hoc_sinh("Ho_ten")
        Dim Th_Ngay_sinh As Control = Th_Hoc_sinh.Controls("Th_Ngay_sinh")
        Th_Ngay_sinh.Text = Hoc_sinh("Ngay_sinh")
        Dim Th_CMND As Control = Th_Hoc_sinh.Controls("Th_CMND")
        Th_CMND.Text = Hoc_sinh("CMND")
        Dim Th_Dien_thoai As Control = Th_Hoc_sinh.Controls("Th_Dien_thoai")
        Th_Dien_thoai.Text = Hoc_sinh("Dien_thoai")
        Dim Th_Mail As Control = Th_Hoc_sinh.Controls("Th_Mail")
        Th_Mail.Text = Hoc_sinh("Mail")
        Dim Th_Dia_chi As Control = Th_Hoc_sinh.Controls("Th_Dia_chi")
        Th_Dia_chi.Text = Hoc_sinh("Dia_chi")
        Dim Th_Hinh As Control = Th_Hoc_sinh.Controls("Th_Hinh")
        Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Hoc_sinh, LOAI_MEDIA.Hinh)
        Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
        Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
        Th_Hinh.BackgroundImage = Hinh
        Th_Hinh.BackgroundImageLayout = ImageLayout.Stretch
        Th_Hinh.Tag = Du_lieu_Hinh
        For Each Th_Gioi_tinh As RadioButton In Th_Hoc_sinh.Controls("Th_Danh_sach_Gioi_tinh").Controls
            Dim Gioi_tinh As DataRow = Th_Gioi_tinh.Tag
            If Gioi_tinh("ID") = Hoc_sinh("ID_GIOI_TINH") Then
                Th_Gioi_tinh.Checked = True
            End If
        Next
        For Each Th_Lop As RadioButton In Th_Hoc_sinh.Controls("Th_Danh_sach_Lop").Controls
            Dim Lop As DataRow = Th_Lop.Tag
            If Lop("ID") = Hoc_sinh("ID_LOP") Then
                Th_Lop.Checked = True
            End If
        Next
    End Sub
    Public Function Nhap_Ho_so_Hoc_sinh(Hoc_sinh As DataRow, Th_Hoc_sinh As Control) As String
        ' Câu hỏi PET : Vì sao phải kiểm tra khi nhập hồ sơ
        Dim Kq As String = Kiem_Tra_Nhap_Ho_so_Hoc_sinh(Th_Hoc_sinh)
        If Kq = "" Then
            Dim Th_Ho_ten As Control = Th_Hoc_sinh.Controls("Th_Ho_ten")
            Hoc_sinh("Ho_ten") = Th_Ho_ten.Text.Trim
            Dim Th_Ngay_sinh As Control = Th_Hoc_sinh.Controls("Th_Ngay_sinh")
            Hoc_sinh("Ngay_sinh") = Th_Ngay_sinh.Text.Trim
            Dim Th_CMND As Control = Th_Hoc_sinh.Controls("Th_CMND")
            Hoc_sinh("CMND") = Th_CMND.Text.Trim
            Dim Th_Dien_thoai As Control = Th_Hoc_sinh.Controls("Th_Dien_thoai")
            Hoc_sinh("Dien_thoai") = Th_Dien_thoai.Text
            Dim Th_Mail As Control = Th_Hoc_sinh.Controls("Th_Mail")
            Hoc_sinh("Mail") = Th_Mail.Text.Trim
            Dim Th_Dia_chi As Control = Th_Hoc_sinh.Controls("Th_Dia_chi")
            Hoc_sinh("Dia_chi") = Th_Dia_chi.Text.Trim
            For Each Th_Gioi_tinh As RadioButton In Th_Hoc_sinh.Controls("Th_Danh_sach_Gioi_tinh").Controls
                Dim Gioi_tinh As DataRow = Th_Gioi_tinh.Tag
                If Th_Gioi_tinh.Checked Then
                    Hoc_sinh("ID_GIOI_TINH") = Gioi_tinh("ID")
                End If
            Next
            For Each Th_Lop As RadioButton In Th_Hoc_sinh.Controls("Th_Danh_sach_Lop").Controls
                Dim Lop As DataRow = Th_Lop.Tag
                If Th_Lop.Checked Then
                    Hoc_sinh("ID_LOP") = Lop("ID")
                End If
            Next
        End If
        Return Kq
    End Function

    Public Function Kiem_Tra_Nhap_Ho_so_Hoc_sinh(Th_Hoc_sinh As Control) As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Ngay As Date
        Dim Th_Ngay_sinh As Control = Th_Hoc_sinh.Controls("Th_Ngay_sinh")
        Hop_le = DateTime.TryParse(Th_Ngay_sinh.Text.Trim, Ngay)
        If Not Hop_le Then
            Kq &= "Ngày sinh phải có dạng dd/mm/yy " & vbCrLf
        End If
        Return Kq
    End Function
#End Region


End Class
