Partial Public Class XL_THE_HIEN
    ' Hàm xử lý có thể tái sử dụng trên tất cả ứng dụng cùng công nghệ giao diện  
    ' Câu hỏi PET : Sẽ có câu hỏi trong trong ứng dụng minh họa khác 
#Region "Biến đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Nghiep_vu As XL_NGHIEP_VU
#End Region
#Region "Khởi động"
    Public Sub New()
        Luu_tru = New XL_LUU_TRU
        Nghiep_vu = New XL_NGHIEP_VU
    End Sub
#End Region
#Region "Thực đơn"
    Public Sub Xuat_Thuc_don_tinh(Danh_sach_Ten_Chuc_nang As List(Of String),
                                  Danh_sach_Ma_so_Chuc_nang As List(Of String),
                                 Thuc_don As MenuStrip, XL_Chon_Chuc_nang As EventHandler)
        '=== Định dạng thực đơn  
        Thuc_don.BackColor = Color.WhiteSmoke
        Thuc_don.ForeColor = Color.Brown
        Thuc_don.Font = New Font("Arial", 14)
        Thuc_don.ImageScalingSize = New Size(35, 35)
        '==== Xuất t các chức năng con của thực đơn
        For i As Integer = 0 To Danh_sach_Ten_Chuc_nang.Count - 1
            Dim Ten_Chuc_nang As String = Danh_sach_Ten_Chuc_nang(i)
            Dim Ma_so_Chuc_nang As String = Danh_sach_Ma_so_Chuc_nang(i)
            '== Khởi tạo thể hiện chức năng
            Dim Th_Chuc_nang As New ToolStripMenuItem
            Thuc_don.Items.Add(Th_Chuc_nang)
            Th_Chuc_nang.Name = Ma_so_Chuc_nang
            '=== Xuất thông tin thể hiện chức năng
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Ma_so_Chuc_nang, LOAI_MEDIA.Hinh)
            Dim Luong_Hinh As IO.MemoryStream = New IO.MemoryStream(Du_lieu_Hinh)
            Th_Chuc_nang.Image = Bitmap.FromStream(Luong_Hinh)
            Th_Chuc_nang.Text = Ten_Chuc_nang
            '===Chuẩn bị biến cố chọn chức năng  
            Th_Chuc_nang.Tag = Ma_so_Chuc_nang
            AddHandler Th_Chuc_nang.Click, XL_Chon_Chuc_nang
        Next

    End Sub
    Public Function Tao_Thuc_don_dong(Danh_sach_Ten_Chuc_nang As List(Of String),
                                                Danh_sach_Ma_so_Chuc_nang As List(Of String),
                                                  Th_Lien_ket As Control,
                                                   XL_Chon_Chuc_nang As EventHandler) As ContextMenuStrip
        Dim Thuc_don_dong As New ContextMenuStrip
        Th_Lien_ket.ContextMenuStrip = Thuc_don_dong
        '=== Định dạng thực đơn động
        Thuc_don_dong.BackColor = Color.White
        Thuc_don_dong.ForeColor = Color.Blue
        Thuc_don_dong.Font = New Font("Arial", 14)
        Thuc_don_dong.ImageScalingSize = New Size(35, 35)
        '==== Xuất các chức năng con của thực đơn động
        For i As Integer = 0 To Danh_sach_Ten_Chuc_nang.Count - 1
            Dim Ten_Chuc_nang As String = Danh_sach_Ten_Chuc_nang(i)
            Dim Ma_so_Chuc_nang As String = Danh_sach_Ma_so_Chuc_nang(i)
            '== Khởi tạo thể hiện chức năng
            Dim Th_Chuc_nang As New ToolStripMenuItem
            Thuc_don_dong.Items.Add(Th_Chuc_nang)
            Th_Chuc_nang.Name = Ma_so_Chuc_nang
            '=== Xuất thông tin thể hiện chức năng
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Ma_so_Chuc_nang, LOAI_MEDIA.Hinh)
            Dim Luong_Hinh As IO.MemoryStream = New IO.MemoryStream(Du_lieu_Hinh)
            Th_Chuc_nang.Image = Bitmap.FromStream(Luong_Hinh)
            Th_Chuc_nang.Text = Ten_Chuc_nang
            '===Chuẩn bị biến cố chọn chức năng  
            Th_Chuc_nang.Tag = Ma_so_Chuc_nang
            AddHandler Th_Chuc_nang.Click, XL_Chon_Chuc_nang
        Next
        Return Thuc_don_dong
    End Function
    Public Sub Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten_Chuc_nang_Con As List(Of String),
                                  Danh_sach_Ma_so_Chuc_nang_Con As List(Of String),
                                 Th_Chuc_nang As ToolStripMenuItem, XL_Chon_Chuc_nang As EventHandler)
        For i As Integer = 0 To Danh_sach_Ten_Chuc_nang_Con.Count - 1
            Dim Ten_Chuc_nang As String = Danh_sach_Ten_Chuc_nang_Con(i)
            Dim Ma_so_Chuc_nang As String = Danh_sach_Ma_so_Chuc_nang_Con(i)
            '== Khởi tạo thể hiện chức năng con
            Dim Th_Chuc_nang_Con As New ToolStripMenuItem
            Th_Chuc_nang.DropDownItems.Add(Th_Chuc_nang_Con)
            Th_Chuc_nang_Con.Name = Ma_so_Chuc_nang
            '=== Xuất thông tin thể hiện chức năng
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Ma_so_Chuc_nang, LOAI_MEDIA.Hinh)
            Dim Luong_Hinh As IO.MemoryStream = New IO.MemoryStream(Du_lieu_Hinh)
            Th_Chuc_nang_Con.Image = Bitmap.FromStream(Luong_Hinh)
            Th_Chuc_nang_Con.Text = Ten_Chuc_nang
            '===Chuẩn bị biến cố chọn chức năng  
            Th_Chuc_nang_Con.Tag = Ma_so_Chuc_nang
            AddHandler Th_Chuc_nang_Con.Click, XL_Chon_Chuc_nang
        Next
    End Sub
#End Region

#Region "Danh sách - Biểu tượng"
    ' Lưu ý PET : Đây là hàm tạm thời và sẽ cải tiến trong phiên bản khác 
    ' Câu hỏi PET : Tại sao là hàm tạm thời ? 

    Sub Xuat_Danh_sach_Doi_tuong(Danh_sach_Doi_tuong As List(Of DataRow),
                                 Danh_sach_Chuoi_Tom_tat As List(Of String),
                                 Danh_sach_Chuoi_Thong_tin As List(Of String),
                              Th_Danh_sach_Doi_tuong As FlowLayoutPanel, XL_Chon_Doi_tuong As EventHandler)
        Th_Danh_sach_Doi_tuong.Controls.Clear()
        For i As Integer = 0 To Danh_sach_Doi_tuong.Count - 1
            Dim Doi_tuong As DataRow = Danh_sach_Doi_tuong(i)
            Dim Chuoi_Tom_tat As String = Danh_sach_Chuoi_Tom_tat(i)
            Dim Chuoi_Thong_tin As String = Danh_sach_Chuoi_Thong_tin(i)
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New Button
            Th_Danh_sach_Doi_tuong.Controls.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Doi_tuong, Chuoi_Thong_tin)
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Doi_tuong, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Doi_tuong.Image = New Bitmap(Hinh, 30, 30)
            Th_Doi_tuong.TextImageRelation = TextImageRelation.ImageBeforeText

            '=== Định dạng thể hiện
            Th_Doi_tuong.Size = New Size(140, 40)
            Th_Doi_tuong.Font = New Font("Arial", 14)
            Th_Doi_tuong.BackColor = Color.White
            Th_Doi_tuong.ForeColor = Color.Blue
            '=== Chuẩn bị biến cố chọn
            Th_Doi_tuong.Tag = Doi_tuong
            If XL_Chon_Doi_tuong IsNot Nothing Then
                AddHandler Th_Doi_tuong.Click, XL_Chon_Doi_tuong
            End If

        Next
    End Sub

    Sub Xuat_Danh_sach_Chon_Doi_tuong(Danh_sach_Doi_tuong As List(Of DataRow),
                                                               Danh_sach_Chuoi_Tom_tat As List(Of String),
                                 Danh_sach_Chuoi_Thong_tin As List(Of String),
                              Th_Danh_sach_Doi_tuong As FlowLayoutPanel, XL_Chon_Doi_tuong As EventHandler)
        Th_Danh_sach_Doi_tuong.Controls.Clear()
        For i As Integer = 0 To Danh_sach_Doi_tuong.Count - 1
            Dim Doi_tuong As DataRow = Danh_sach_Doi_tuong(i)
            Dim Chuoi_Tom_tat As String = Danh_sach_Chuoi_Tom_tat(i)
            Dim Chuoi_Thong_tin As String = Danh_sach_Chuoi_Thong_tin(i)
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New RadioButton
            Th_Danh_sach_Doi_tuong.Controls.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Doi_tuong, Chuoi_Thong_tin)
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Doi_tuong, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Doi_tuong.Image = New Bitmap(Hinh, 30, 30)
            Th_Doi_tuong.TextImageRelation = TextImageRelation.ImageBeforeText

            '=== Định dạng thể hiện
            Th_Doi_tuong.Size = New Size(150, 40)
            Th_Doi_tuong.Font = New Font("Arial", 14)
            Th_Doi_tuong.BackColor = Color.White
            Th_Doi_tuong.ForeColor = Color.Blue
            '=== Chuẩn bị biến cố chọn
            Th_Doi_tuong.Tag = Doi_tuong
            If XL_Chon_Doi_tuong IsNot Nothing Then
                AddHandler Th_Doi_tuong.Click, XL_Chon_Doi_tuong
            End If

        Next
    End Sub

#End Region

#Region "Media"
    Public Function Chon_Hinh(Th_Hinh As Control) As String
        Dim Kq As String = ""
        Dim Chon_Tap_tin As New OpenFileDialog
        Chon_Tap_tin.DefaultExt = "png"
        '===== Chọn hình 
        If Chon_Tap_tin.ShowDialog() = DialogResult.OK Then
            Dim Duong_dan As String = Chon_Tap_tin.FileName
            '==== Đọc hình chọn
            Dim Du_lieu_Hinh_Chon As Byte() = IO.File.ReadAllBytes(Duong_dan)
            '==== Kiểm tra và xuất  hình chọn nếu hợp lệ 
            Dim Kich_thuoc_Hinh_Toi_da As Double = 10 * Math.Pow(2, 10) ' 100KB
            If Du_lieu_Hinh_Chon.Count > Kich_thuoc_Hinh_Toi_da Then
                Kq &= "Hình phải có kích thước tối đa là 100 KB và phải có cấu trúc bên trong hợp lệ"
            Else
                '=== Xuất hình chọn 
                Dim Luong As New IO.MemoryStream(Du_lieu_Hinh_Chon)
                Try
                    Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
                    Th_Hinh.BackgroundImage = Hinh
                    Th_Hinh.BackgroundImageLayout = ImageLayout.Stretch
                    Th_Hinh.Tag = Du_lieu_Hinh_Chon
                Catch ex As Exception
                    Kq = "Hình chọn không hợp lệ"
                End Try

            End If

            Return Kq
        End If
        Return Kq
    End Function

#End Region




End Class
