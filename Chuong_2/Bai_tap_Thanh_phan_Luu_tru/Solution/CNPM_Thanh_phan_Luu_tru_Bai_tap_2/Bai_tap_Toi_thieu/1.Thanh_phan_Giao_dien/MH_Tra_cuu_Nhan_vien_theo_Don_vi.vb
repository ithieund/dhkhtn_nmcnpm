Public Class MH_Tra_cuu_Nhan_vien_theo_Don_vi

#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU(LOAI_CSDL.Acesss)
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN

    Dim Du_lieu As DataSet
    Dim Danh_sach_Don_vi As List(Of DataRow)
    Dim Danh_sach_Nhan_vien As List(Of DataRow)

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
        Danh_sach_Don_vi = Nghiep_vu.Danh_sach_Don_vi(Du_lieu)
        If Danh_sach_Don_vi.Count > 0 Then
            Danh_sach_Nhan_vien = Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Danh_sach_Don_vi(0))
        End If
        '===Khởi động thể hiện ===
        Me.WindowState = FormWindowState.Maximized

        Xuat_Danh_sach_Don_vi()
        If Danh_sach_Nhan_vien IsNot Nothing Then
            Xuat_Danh_sach_Nhan_vien()
        End If

    End Sub

#End Region

#Region "Xử lý Biến cố"
    Sub XL_Chon_Don_vi(Th_Don_vi As Control, Bc As EventArgs)
        '=== Nhập liệu : Xác định Đơn vị được chọn 
        Dim Don_vi As DataRow = Th_Don_vi.Tag
        '=== Xử lý : Tạo Danh sách nhân viên tương ứng 
        Danh_sach_Nhan_vien = Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Don_vi)
        '===Kết xuất : Xuất danh sách nhân viên 
        Xuat_Danh_sach_Nhan_vien()
    End Sub
#End Region

#Region "Xử lý Thể hiện ( Nhập/xuất ) "
    Sub Xuat_Danh_sach_Don_vi()

        For Each Don_vi As DataRow In Danh_sach_Don_vi
            Dim Th_Don_vi As New Button
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Don_vi("Ten")
            Th_Don_vi.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Thong_tin As String = Nghiep_vu.Tao_Chuoi_Thong_tin_Don_vi(Don_vi)
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Don_vi, Thong_tin)
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Du_lieu_Hinh(Don_vi)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Don_vi.Image = New Bitmap(Hinh, 30, 30)
            Th_Don_vi.TextImageRelation = TextImageRelation.ImageBeforeText

            '=== Định dạng thể hiện
            Th_Don_vi.Size = New Size(140, 40)
            Th_Don_vi.Font = New Font("Arial", 14)
            Th_Don_vi.BackColor = Color.White
            Th_Don_vi.ForeColor = Color.Blue
            '=== Chuẩn bị biến cố chọn
            Th_Don_vi.Tag = Don_vi
            AddHandler Th_Don_vi.Click, AddressOf XL_Chon_Don_vi
        Next
    End Sub

    Sub Xuat_Danh_sach_Nhan_vien()
        Th_Danh_sach_Nhan_vien.Controls.Clear()
        For Each Nhan_vien As DataRow In Danh_sach_Nhan_vien
            '=== Tạo thể hiện : Nhan_vien --> Th_Nhan_vien
            Dim Th_Nhan_vien As New Button
            Th_Danh_sach_Nhan_vien.Controls.Add(Th_Nhan_vien)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Nhan_vien("Ho_ten")
            Th_Nhan_vien.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Chuoi_Thong_tin As String = Nghiep_vu.Tao_Chuoi_Thong_tin_Nhan_vien(Nhan_vien)
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Nhan_vien, Chuoi_Thong_tin)
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Du_lieu_Hinh(Nhan_vien)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Nhan_vien.Image = New Bitmap(Hinh, 30, 30)
            Th_Nhan_vien.TextImageRelation = TextImageRelation.ImageAboveText
            '==Định dạng thể hiện 
            Th_Nhan_vien.Size = New Size(220, 85)
            Th_Nhan_vien.Font = New Font("Arial", 14)
            Th_Nhan_vien.BackColor = Color.White
            Th_Nhan_vien.ForeColor = Color.Navy
            '===Chuẩn bị biến cố chọn 

        Next
    End Sub
#End Region
End Class