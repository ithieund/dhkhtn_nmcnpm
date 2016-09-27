Partial Public Class XL_THE_HIEN

#Region "Biến đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
#End Region
#Region "Khởi động"
    Public Sub New(Ung_dung As XL_UNG_DUNG)
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
    End Sub
#End Region
#Region "Thực đơn"
    Public Sub Xuat_Thuc_don_tinh(Danh_sach_Chuc_nang As List(Of XL_CHUC_NANG),
                                 Thuc_don As MenuStrip, XL_Chon_Chuc_nang As EventHandler)
        '=== Định dạng thực đơn  
        Thuc_don.BackColor = Color.WhiteSmoke
        Thuc_don.ForeColor = Color.Brown
        Thuc_don.Font = New Font("Arial", 14)
        Thuc_don.ImageScalingSize = New Size(35, 35)

        '==== Xuất  các chức năng con của thực đơn
        For Each Chuc_nang As XL_CHUC_NANG In Danh_sach_Chuc_nang
            Dim Ten_Chuc_nang As String = Chuc_nang.Ten
            Dim Ma_so_Chuc_nang As String = Chuc_nang.Ma_so
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
            Th_Chuc_nang.Tag = Chuc_nang
            AddHandler Th_Chuc_nang.Click, XL_Chon_Chuc_nang
        Next

    End Sub

    Public Function Tao_Thuc_don_dong(Danh_sach_Chuc_nang As List(Of XL_CHUC_NANG),
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
        For Each Chuc_nang As XL_CHUC_NANG In Danh_sach_Chuc_nang
            Dim Ten_Chuc_nang As String = Chuc_nang.Ten
            Dim Ma_so_Chuc_nang As String = Chuc_nang.Ma_so
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
            Th_Chuc_nang.Tag = Chuc_nang
            AddHandler Th_Chuc_nang.Click, XL_Chon_Chuc_nang
        Next
        Return Thuc_don_dong
    End Function
    Public Sub Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Chuc_nang_Con As List(Of XL_CHUC_NANG),
                                 Th_Chuc_nang As ToolStripMenuItem, XL_Chon_Chuc_nang As EventHandler)
        For Each Chuc_nang_Con As XL_CHUC_NANG In Danh_sach_Chuc_nang_Con
            Dim Ten_Chuc_nang As String = Chuc_nang_Con.Ten
            Dim Ma_so_Chuc_nang As String = Chuc_nang_Con.Ma_so
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
            Th_Chuc_nang_Con.Tag = Chuc_nang_Con
            AddHandler Th_Chuc_nang_Con.Click, XL_Chon_Chuc_nang
        Next
    End Sub

#End Region

#Region "Danh sách - Biểu tượng"
    ' Lưu ý PET : Đây là hàm tạm thời và sẽ cải tiến trong phiên bản khác 
    ' Câu hỏi PET : Tại sao là hàm tạm thời ? 

    Sub Xuat_Danh_sach_Doi_tuong(Danh_sach_Doi_tuong As IList,
                                 Danh_sach_Chuoi_Tom_tat As List(Of String),
                                 Danh_sach_Chuoi_Thong_tin As List(Of String),
                                 Danh_sach_Ma_so_Hinh As List(Of String),
                                Th_Danh_sach_Doi_tuong As ToolStrip, XL_Chon_Doi_tuong As EventHandler)
        If XL_Chon_Doi_tuong Is Nothing Then
            XL_Chon_Doi_tuong = AddressOf XL_Thay_doi_Trang_thai_The_hien
        End If
        '==== Dịnh dạng thể hiện danh sách
        Th_Danh_sach_Doi_tuong.Items.Clear()
        Th_Danh_sach_Doi_tuong.Font = New Font("Arial", 14)
        Th_Danh_sach_Doi_tuong.BackColor = Color.White
        Th_Danh_sach_Doi_tuong.ForeColor = Color.Blue
        Th_Danh_sach_Doi_tuong.ShowItemToolTips = True

        Th_Danh_sach_Doi_tuong.ImageScalingSize = New Size(30, 30)
        Dim So_cot As Integer = Danh_sach_Doi_tuong.Count
        If Danh_sach_Doi_tuong.Count > 8 Then
            So_cot = 8
        End If
        Th_Danh_sach_Doi_tuong.LayoutStyle = ToolStripLayoutStyle.Table
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Doi_tuong.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = So_cot
        For i As Integer = 0 To Danh_sach_Doi_tuong.Count - 1
            Dim Doi_tuong As Object = Danh_sach_Doi_tuong(i)
            Dim Chuoi_Tom_tat As String = Danh_sach_Chuoi_Tom_tat(i)
            Dim Chuoi_Thong_tin As String = Danh_sach_Chuoi_Thong_tin(i)
            Dim Ma_so_Hinh As String = Danh_sach_Ma_so_Hinh(i)
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New ToolStripMenuItem
            Th_Danh_sach_Doi_tuong.Items.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Th_Doi_tuong.ToolTipText = Chuoi_Thong_tin
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Ma_so_Hinh, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Doi_tuong.Image = Hinh
            Th_Doi_tuong.TextImageRelation = TextImageRelation.ImageBeforeText

            '=== Định dạng thể hiện
            Th_Doi_tuong.AutoSize = False
            Th_Doi_tuong.Size = New Size(140, 40)


            '=== Chuẩn bị biến cố chọn
            Th_Doi_tuong.Tag = Doi_tuong
            If XL_Chon_Doi_tuong IsNot Nothing Then
                AddHandler Th_Doi_tuong.Click, XL_Chon_Doi_tuong
            End If

        Next
    End Sub

    Sub Xuat_Danh_sach_Chon_Doi_tuong(Danh_sach_Doi_tuong As IList,
                                                               Danh_sach_Chuoi_Tom_tat As List(Of String),
                                                                Danh_sach_Chuoi_Thong_tin As List(Of String),
                                                                Danh_sach_Ma_so_Hinh As List(Of String),
                              Th_Danh_sach_Doi_tuong As ToolStrip, XL_Chon_Doi_tuong As EventHandler)
        If XL_Chon_Doi_tuong Is Nothing Then
            XL_Chon_Doi_tuong = AddressOf XL_Thay_doi_Trang_thai_The_hien
        End If
        '==== Dịnh dạng thể hiện danh sách
        Th_Danh_sach_Doi_tuong.Items.Clear()
        Th_Danh_sach_Doi_tuong.Font = New Font("Arial", 12)
        Th_Danh_sach_Doi_tuong.BackColor = Color.White
        Th_Danh_sach_Doi_tuong.ForeColor = Color.Blue
        Th_Danh_sach_Doi_tuong.ShowItemToolTips = True
        Th_Danh_sach_Doi_tuong.ImageScalingSize = New Size(25, 25)
        Dim So_cot As Integer = Danh_sach_Doi_tuong.Count
        If Danh_sach_Doi_tuong.Count > 4 Then
            So_cot = 4
        End If
        Th_Danh_sach_Doi_tuong.LayoutStyle = ToolStripLayoutStyle.Table
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Doi_tuong.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = So_cot
        For i As Integer = 0 To Danh_sach_Doi_tuong.Count - 1
            Dim Doi_tuong As Object = Danh_sach_Doi_tuong(i)
            Dim Chuoi_Tom_tat As String = Danh_sach_Chuoi_Tom_tat(i)
            Dim Chuoi_Thong_tin As String = Danh_sach_Chuoi_Thong_tin(i)
            Dim Ma_so_Hinh As String = Danh_sach_Ma_so_Hinh(i)
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New ToolStripMenuItem
            Th_Danh_sach_Doi_tuong.Items.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Th_Doi_tuong.ToolTipText = Chuoi_Thong_tin
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Ma_so_Hinh, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Doi_tuong.Image = Hinh
            Th_Doi_tuong.TextImageRelation = TextImageRelation.ImageBeforeText

            '=== Định dạng thể hiện
            Th_Doi_tuong.AutoSize = False
            Th_Doi_tuong.Size = New Size(130, 35)
            Th_Doi_tuong.CheckOnClick = True
            Th_Doi_tuong.TextImageRelation = TextImageRelation.ImageBeforeText
            Th_Doi_tuong.ImageAlign = ContentAlignment.MiddleLeft
            Th_Doi_tuong.TextAlign = ContentAlignment.MiddleCenter
            '=== Chuẩn bị biến cố chọn
            Th_Doi_tuong.Tag = Doi_tuong
            If XL_Chon_Doi_tuong IsNot Nothing Then
                AddHandler Th_Doi_tuong.Click, XL_Chon_Doi_tuong
            End If

        Next
    End Sub

    Sub Xuat_Danh_sach_Thong_ke(Danh_sach_Doi_tuong As IList,
                                 Danh_sach_Chuoi_Tom_tat As List(Of String),
                                 Danh_sach_Chuoi_Thong_tin As List(Of String),
                                 Danh_sach_Ma_so_Hinh As List(Of String),
                                Th_Danh_sach_Doi_tuong As ToolStrip, XL_Chon_Doi_tuong As EventHandler)
        If XL_Chon_Doi_tuong Is Nothing Then
            XL_Chon_Doi_tuong = AddressOf XL_Thay_doi_Trang_thai_The_hien
        End If
        '==== Dịnh dạng thể hiện danh sách
        Th_Danh_sach_Doi_tuong.Items.Clear()
        Th_Danh_sach_Doi_tuong.Font = New Font("Arial", 14)
        Th_Danh_sach_Doi_tuong.BackColor = Color.White
        Th_Danh_sach_Doi_tuong.ForeColor = Color.Blue
        Th_Danh_sach_Doi_tuong.ShowItemToolTips = True
        Th_Danh_sach_Doi_tuong.ImageScalingSize = New Size(30, 30)
        Dim So_cot As Integer = Danh_sach_Doi_tuong.Count
        If Danh_sach_Doi_tuong.Count > 8 Then
            So_cot = 8
        End If
        Th_Danh_sach_Doi_tuong.LayoutStyle = ToolStripLayoutStyle.Table
        Dim Bo_cuc_Ma_tran As TableLayoutSettings = Th_Danh_sach_Doi_tuong.LayoutSettings
        Bo_cuc_Ma_tran.ColumnCount = So_cot

        For i As Integer = 0 To Danh_sach_Doi_tuong.Count - 1
            Dim Doi_tuong As Object = Danh_sach_Doi_tuong(i)
            Dim Chuoi_Tom_tat As String = Danh_sach_Chuoi_Tom_tat(i)
            Dim Chuoi_Thong_tin As String = Danh_sach_Chuoi_Thong_tin(i)
            Dim Ma_so_Hinh As String = Danh_sach_Ma_so_Hinh(i)
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New ToolStripLabel
            Th_Danh_sach_Doi_tuong.Items.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Th_Doi_tuong.ToolTipText = Chuoi_Thong_tin
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Ma_so_Hinh, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Doi_tuong.Image = New Bitmap(Hinh, 30, 30)


            '=== Định dạng thể hiện
            Th_Doi_tuong.AutoSize = False
            Th_Doi_tuong.Size = New Size(320, 40)

            '=== Chuẩn bị biến cố chọn
            Th_Doi_tuong.Tag = Doi_tuong
            If XL_Chon_Doi_tuong IsNot Nothing Then
                AddHandler Th_Doi_tuong.Click, XL_Chon_Doi_tuong
            End If

        Next
    End Sub

#End Region

#Region "Xử lý Biến cố - Thay đổi trạng thái"
    Public Sub XL_Thay_doi_Trang_thai_The_hien(Th_Doi_tuong As ToolStripMenuItem, Bc As EventArgs)
        Dim Mau_nen As Color = Th_Doi_tuong.Owner.BackColor
        Dim Mau_ky_tu As Color = Th_Doi_tuong.Owner.ForeColor

        Dim Mau_nen_Chon As Color = Th_Doi_tuong.Owner.ForeColor
        Dim Mau_ky_tu_Chon As Color = Th_Doi_tuong.Owner.BackColor
        For Each Th As ToolStripItem In Th_Doi_tuong.Owner.Items
            If Th Is Th_Doi_tuong Then
                Th.BackColor = Mau_nen_Chon
                Th.ForeColor = Mau_ky_tu_Chon
            Else
                Th.BackColor = Mau_nen
                Th.ForeColor = Mau_ky_tu
            End If
        Next

    End Sub
#End Region

#Region "Media"
    Public Sub Xuat_hinh(Ma_so_Hinh As String, Th_Hinh As Control)
        Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Ma_so_Hinh, LOAI_MEDIA.Hinh)
        Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
        Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
        Th_Hinh.BackgroundImage = Hinh
        Th_Hinh.BackgroundImageLayout = ImageLayout.Stretch
        Th_Hinh.Tag = Du_lieu_Hinh
    End Sub
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
                Kq &= "Hình phải kích thước tối đa là 100 KB"
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
