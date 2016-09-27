Public Class MH_Nhap_lieu_Don_vi

    ' Khai bao cac bien/doi tuong toan cuc
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
    Dim Don_vi As DataRow

    ' Xu ly khoi dong
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()

    End Sub

    Sub Khoi_dong()

        ' Khoi dong du lieu
        Du_lieu = Luu_tru.Doc_Du_Lieu

        ' Tao dong nhan vien moi
        Don_vi = Nghiep_vu.Tao_Don_vi_moi(Du_lieu)

        ' Khoi dong the hien
        Xuat_Don_vi()

    End Sub

    Sub Xuat_Don_vi()

        Th_ten.Text = Don_vi("Ten")

    End Sub

    Private Sub XL_Dong_y_Click(sender As Object, e As EventArgs) Handles XL_Dong_y.Click

        Nhap_Don_vi()

        ' Kiem tra tinh hop le
        Dim Chuoi_loi As String = Nghiep_vu.Kiem_tra_Ghi_moi_Don_vi(Don_vi)

        ' Xu ly ghi du lieu neu khong co loi
        If Chuoi_loi = "" Then
            Chuoi_loi = Luu_tru.Ghi_moi(Don_vi)
        Else
            Th_Thong_bao.Text = Chuoi_loi
            Return
        End If

        ' Hien thi thong bao luu thanh cong neu khong co loi
        If Chuoi_loi = "" Then
            Th_Thong_bao.Text = "Đã lưu đơn vị mới"
            Don_vi = Nghiep_vu.Tao_Don_vi_Moi(Du_lieu)
            Xuat_Don_vi()
        Else
            Th_Thong_bao.Text = Chuoi_loi
        End If

    End Sub

    Sub Nhap_Don_vi()

        Don_vi("Ten") = Th_ten.Text.Trim

    End Sub

End Class
