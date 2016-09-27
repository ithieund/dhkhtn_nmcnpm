Imports System.ComponentModel

Public Class MH_Them_moi_Nhan_vien

    ' Khai bao cac bien/doi tuong toan cuc
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
    Dim Nhan_vien As DataRow

    ' Xu ly khoi dong
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()

    End Sub

    Sub Khoi_dong()

        ' Khoi dong du lieu
        Du_lieu = Luu_tru.Doc_Du_lieu
        Nhan_vien = Nghiep_vu.Tao_Nhan_vien_moi(Du_lieu)

        ' Khoi dong the hien
        Xuat_Danh_sach_Don_vi()
        Xuat_Nhan_vien()

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

    Private Sub XL_Dong_y_Click(sender As Object, e As EventArgs) Handles XL_Dong_y.Click

        Nhap_Nhan_vien()

        Dim Chuoi_loi As String = Nghiep_vu.Kiem_tra_Ghi_moi_Nhan_vien(Nhan_vien)

        If Chuoi_loi = "" Then
            Chuoi_loi = Luu_tru.Ghi_moi(Nhan_vien)
        Else
            Th_Thong_bao.Text = Chuoi_loi
            Return
        End If

        If Chuoi_loi = "" Then
            Th_Thong_bao.Text = "Đã ghi hồ sơ mới"
            Nhan_vien = Nghiep_vu.Tao_Nhan_vien_moi(Du_lieu)
            Xuat_Nhan_vien()
        Else
            Th_Thong_bao.Text = Chuoi_loi
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
End Class
