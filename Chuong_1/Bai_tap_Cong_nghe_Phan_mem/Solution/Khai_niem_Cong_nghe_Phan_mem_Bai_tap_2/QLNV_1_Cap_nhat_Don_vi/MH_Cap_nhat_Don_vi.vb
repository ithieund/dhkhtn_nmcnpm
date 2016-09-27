Public Class MH_Cap_nhat_Don_vi

#Region "Bien/Doi tuong toan cuc"
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
    Dim Don_vi As DataRow
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

    End Sub

    Sub Xuat_Don_vi()

        Th_Ten_Don_vi.Text = Don_vi("Ten")

    End Sub
#End Region

#Region "Xu ly bien co"
    Private Sub XL_Dong_y_Click(sender As Object, e As EventArgs) Handles XL_Dong_y.Click

        If Don_vi IsNot Nothing Then
            Nhap_Don_vi()

            Dim Chuoi_loi As String = Nghiep_vu.Kiem_tra_Cap_nhat_Don_vi(Don_vi)

            If Chuoi_loi = "" Then
                Chuoi_loi = Luu_tru.Cap_nhat(Don_vi)
            Else
                Th_Thong_bao.Text = Chuoi_loi
                Return
            End If

            If Chuoi_loi = "" Then
                Th_Thong_bao.Text = "Đã cập nhật đơn vị " & Don_vi("Ten")
            Else
                Th_Thong_bao.Text = Chuoi_loi
            End If
        Else
            Th_Thong_bao.Text = "Chưa chọn đơn vị"
        End If

    End Sub

    Sub Nhap_Don_vi()

        Don_vi("Ten") = Th_Ten_Don_vi.Text.Trim

    End Sub

    Private Sub XL_Chon_Don_vi_Click(sender As Object, e As EventArgs) Handles XL_Chon_Don_vi.Click

        Dim Mh As New MH_Chon_Don_vi
        Mh.ShowDialog()
        Don_vi = Mh.Don_vi_Chon

        If Don_vi IsNot Nothing Then
            Xuat_Don_vi()
        End If

    End Sub
#End Region

End Class