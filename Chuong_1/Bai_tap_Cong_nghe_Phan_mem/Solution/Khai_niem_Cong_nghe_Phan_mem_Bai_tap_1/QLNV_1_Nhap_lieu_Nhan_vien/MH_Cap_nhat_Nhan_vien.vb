Public Class MH_Cap_nhat_Nhan_vien

#Region "Bien/Doi tuong toan cuc"
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
    Dim Nhan_vien As DataRow
#End Region

#Region "Xu ly khoi dong"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()
    End Sub

    Sub Khoi_dong()

        ' Doc du lieu tu file xml
        Du_lieu = Luu_tru.Doc_Du_Lieu()

        ' Khoi dong the hien
        Xuat_Danh_sach_Don_vi()

    End Sub

    Sub Xuat_Danh_sach_Don_vi()

        Dim Danh_sach_Don_vi As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList

        For Each Don_vi As DataRow In Danh_sach_Don_vi
            ' Tao the hien don vi
            Dim Th_Don_vi As New RadioButton

            ' Xuat tom tat
            Dim Chuoi_Tom_tat As String = Don_vi("Ten")
            Th_Don_vi.Text = Chuoi_Tom_tat

            ' Dinh dang the hien
            Th_Don_vi.Size = New Size(100, 40)
            Th_Don_vi.Font = New Font("Arial", 12)
            Th_Don_vi.ForeColor = Color.White
            Th_Don_vi.Tag = Don_vi

            ' Bo sung the hien don vi vao danh sach don vi
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)
        Next

    End Sub

    Sub Xuat_Nhan_vien()

        Th_Ho_ten.Text = Nhan_vien("Ho_ten")
        Th_Gioi_tinh.Checked = Nhan_vien("Gioi_tinh")
        Th_Cmnd.Text = Nhan_vien("CMND")
        Th_Ngay_sinh.Value = Nhan_vien("Ngay_sinh")
        Th_Muc_luong.Text = Nhan_vien("Muc_luong")
        Th_Dia_chi.Text = Nhan_vien("Dia_chi")

        ' Duyet qua danh sach don vi
        For Each Th_don_vi As RadioButton In Th_Danh_sach_Don_vi.Controls
            Dim Don_vi As DataRow = Th_don_vi.Tag

            ' Kiem tra xem don vi nao trung voi don vi cua nhan vien thi the hien la checked
            If Nhan_vien("ID_DON_VI") = Don_vi("ID") Then
                Th_don_vi.Checked = True
            End If
        Next

    End Sub
#End Region

#Region "Xu ly bien co"
    Private Sub XL_Dong_y_Click(sender As Object, e As EventArgs) Handles XL_Dong_y.Click

        If Nhan_vien IsNot Nothing Then
            Nhap_Nhan_vien()

            Dim Chuoi_loi As String = Nghiep_vu.Kiem_tra_Cap_nhat_Nhan_vien(Nhan_vien)

            If Chuoi_loi = "" Then
                Chuoi_loi = Luu_tru.Cap_nhat(Nhan_vien)
            Else
                Th_Thong_bao.Text = Chuoi_loi
                Return
            End If

            If Chuoi_loi = "" Then
                Th_Thong_bao.Text = "Đã cập nhật hồ sơ " & Nhan_vien("Ho_ten")
            Else
                Th_Thong_bao.Text = Chuoi_loi
            End If
        Else
            Th_Thong_bao.Text = "Chưa chọn nhân viên"
        End If

    End Sub

    Sub Nhap_Nhan_vien()

        Nhan_vien("Ho_ten") = Th_Ho_ten.Text.Trim
        Nhan_vien("Gioi_tinh") = Th_Gioi_tinh.Checked
        Nhan_vien("CMND") = Th_Cmnd.Text.Trim
        Nhan_vien("Ngay_sinh") = Th_Ngay_sinh.Value

        If Th_Muc_luong.Text.Trim = "" Then
            Nhan_vien("Muc_luong") = 0
        Else
            Nhan_vien("Muc_luong") = Th_Muc_luong.Text.Trim
        End If

        Nhan_vien("Dia_chi") = Th_Dia_chi.Text

        ' Duyet qua danh sach chon don vi
        For Each Th_don_vi As RadioButton In Th_Danh_sach_Don_vi.Controls
            Dim Don_vi As DataRow = Th_don_vi.Tag

            ' Kiem tra xem don vi nao dang duoc chon thi lay don vi do lam don vi cua nhan vien
            If Th_don_vi.Checked Then
                Nhan_vien("ID_DON_VI") = Don_vi("ID")
                Return
            End If
        Next

    End Sub

    Private Sub XL_Chon_Nhan_vien_Click(sender As Object, e As EventArgs) Handles XL_Chon_Nhan_vien.Click

        Dim Mh As New MH_Chon_Nhan_vien
        Mh.ShowDialog()
        Nhan_vien = Mh.Nhan_vien_Chon

        If Nhan_vien IsNot Nothing Then
            Xuat_Nhan_vien()
        End If

    End Sub
#End Region

End Class
