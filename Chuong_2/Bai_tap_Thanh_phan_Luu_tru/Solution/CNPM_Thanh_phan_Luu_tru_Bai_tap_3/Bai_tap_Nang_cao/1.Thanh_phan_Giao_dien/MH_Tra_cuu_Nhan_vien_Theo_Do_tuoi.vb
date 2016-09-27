Public Class MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi
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
        '==== Khởi động dữ liệu ===
        Dim Can_duoi As Integer = 18
        Dim Can_tren As Integer = 25
        TH_Do_tuoi.Text = Can_duoi & "-" & Can_tren
        Danh_sach_Nhan_vien = Nghiep_vu.Danh_sach_Nhan_vien_theo_Do_tuoi(Du_lieu, Can_duoi, Can_tren)

        '===Khởi động thể hiện ===
        Me.WindowState = FormWindowState.Maximized

        Xuat_Danh_sach_Nhan_vien()

    End Sub

#End Region

#Region "Xử lý Biến cố"
    Private Sub TH_Muc_luong_KeyDown(sender As Object, e As KeyEventArgs) Handles TH_Do_tuoi.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Du_lieu_Nhap()

            If Chuoi_loi <> "" Then
                MsgBox(Chuoi_loi)
            End If

            If Chuoi_loi = "" Then

                ' Nhap lieu tieu chi tra cuu
                Dim Do_tuoi As String = TH_Do_tuoi.Text.Trim
                Dim T As String() = Split(Do_tuoi, "-")
                Dim Can_duoi As Double = T(0)
                Dim Can_tren As Double = T(1)

                ' Xu ly tao danh sach nhan vien tuong ung
                Danh_sach_Nhan_vien = Nghiep_vu.Danh_sach_Nhan_vien_theo_Do_tuoi(Du_lieu, Can_duoi, Can_tren)

                ' Xuat danh sach nhan vien
                Xuat_Danh_sach_Nhan_vien()

            End If
        End If

    End Sub

    Function Kiem_tra_Du_lieu_Nhap() As String

        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Do_tuoi As String = TH_Do_tuoi.Text.Trim

        Hop_le = Do_tuoi.Contains("-")

        If Hop_le Then
            Dim T As String() = Split(Do_tuoi, "-")
            Hop_le = T.Count = 2 AndAlso IsNumeric(T(0)) AndAlso IsNumeric(T(1))
        End If

        If Not Hop_le Then
            Kq &= "Độ tuổi phải có dạng Can_duoi - Can_tren với Can_duoi, Can_tren là 2 số"
        End If

        Return Kq

    End Function
#End Region

#Region "Xử lý Thể hiện ( Nhập/xuất ) "
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