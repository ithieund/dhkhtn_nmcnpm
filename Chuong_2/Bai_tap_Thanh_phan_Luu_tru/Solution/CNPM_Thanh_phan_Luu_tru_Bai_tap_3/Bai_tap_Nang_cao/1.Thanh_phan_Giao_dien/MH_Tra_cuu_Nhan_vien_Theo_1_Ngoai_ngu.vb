﻿Public Class MH_Tra_cuu_Nhan_vien_Theo_1_Ngoai_ngu

#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU(LOAI_CSDL.Acesss)
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN

    Dim Du_lieu As DataSet
    Dim Danh_sach_Ngoai_ngu As List(Of DataRow)
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
        Danh_sach_Ngoai_ngu = Nghiep_vu.Danh_sach_Ngoai_ngu(Du_lieu)
        If Danh_sach_Ngoai_ngu.Count > 0 Then
            Danh_sach_Nhan_vien = Nghiep_vu.Danh_sach_Nhan_vien_Theo_1_Ngoai_ngu(Danh_sach_Ngoai_ngu(0))
        End If
        '===Khởi động thể hiện ===
        Me.WindowState = FormWindowState.Maximized

        Xuat_Danh_sach_Ngoai_ngu()
        If Danh_sach_Nhan_vien IsNot Nothing Then
            Xuat_Danh_sach_Nhan_vien()
        End If

    End Sub

#End Region

#Region "Xử lý Biến cố"
    Sub XL_Chon_Ngoai_ngu(Th_Ngoai_ngu As Control, Bc As EventArgs)
        '=== Nhập liệu : Xác định Đơn vị được chọn 
        Dim Ngoai_ngu As DataRow = Th_Ngoai_ngu.Tag
        '=== Xử lý : Tạo Danh sách nhân viên tương ứng 
        Danh_sach_Nhan_vien = Nghiep_vu.Danh_sach_Nhan_vien_Theo_1_Ngoai_ngu(Ngoai_ngu)
        '===Kết xuất : Xuất danh sách nhân viên 
        Xuat_Danh_sach_Nhan_vien()
    End Sub
#End Region

#Region "Xử lý Thể hiện ( Nhập/xuất ) "
    Sub Xuat_Danh_sach_Ngoai_ngu()

        For Each Ngoai_ngu As DataRow In Danh_sach_Ngoai_ngu
            Dim Th_Ngoai_ngu As New RadioButton
            Th_Danh_sach_Ngoai_ngu.Controls.Add(Th_Ngoai_ngu)
            '=== Xuất Tóm tắt
            Dim Chuoi_Tom_tat As String = Ngoai_ngu("Ten")
            Th_Ngoai_ngu.Text = Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Thong_tin As String = Nghiep_vu.Tao_Chuoi_Thong_tin_Ngoai_ngu(Ngoai_ngu)
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Ngoai_ngu, Thong_tin)

            '=== Định dạng thể hiện
            Th_Ngoai_ngu.Size = New Size(100, 40)
            Th_Ngoai_ngu.Font = New Font("Arial", 14)
            Th_Ngoai_ngu.BackColor = Color.White
            Th_Ngoai_ngu.ForeColor = Color.Blue
            '=== Chuẩn bị biến cố chọn
            Th_Ngoai_ngu.Tag = Ngoai_ngu
            AddHandler Th_Ngoai_ngu.Click, AddressOf XL_Chon_Ngoai_ngu
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