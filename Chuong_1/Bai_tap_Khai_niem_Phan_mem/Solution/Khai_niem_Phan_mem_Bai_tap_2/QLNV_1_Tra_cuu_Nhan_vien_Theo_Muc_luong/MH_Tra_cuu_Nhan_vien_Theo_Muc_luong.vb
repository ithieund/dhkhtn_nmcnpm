Public Class MH_Tra_cuu_Nhan_vien_Theo_Muc_luong

    ' Khai bao bien/doi tuong toan cuc
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()

    End Sub

    Sub Khoi_dong()

        ' Khoi dong du lieu
        Du_lieu = Luu_tru.Doc_Du_lieu

    End Sub

    Private Sub Th_Muc_luong_Min_KeyDown(sender As Object, e As KeyEventArgs) Handles Th_Muc_luong_Min.KeyDown

        If e.KeyCode = Keys.Enter Then
            Xuat_Danh_sach_Nhan_vien()
        End If

    End Sub

    Private Sub Th_Muc_luong_Max_KeyDown(sender As Object, e As KeyEventArgs) Handles Th_Muc_luong_Max.KeyDown

        If e.KeyCode = Keys.Enter Then
            Xuat_Danh_sach_Nhan_vien()
        End If

    End Sub

    Sub Xuat_Danh_sach_Nhan_vien()

        ' Kiem tra muc luong nguoi dung nhap
        Dim Chuoi_loi As String = Nghiep_vu.Kiem_tra_Bo_loc(Th_Muc_luong_Min.Text.Trim, Th_Muc_luong_Max.Text.Trim)

        If Chuoi_loi <> "" Then
            MsgBox(Chuoi_loi)
            Return
        End If

        ' Nhap muc luong tren man hinh vao cac bien
        Dim Muc_luong_Min As Integer = Th_Muc_luong_Min.Text.Trim
        Dim Muc_luong_Max As Integer = Th_Muc_luong_Max.Text.Trim

        ' Xu ly tao danh sach nhan vien co muc luong thoa man
        Dim Danh_sach_Nhan_vien As List(Of DataRow) = Nghiep_vu.Danh_sach_Nhan_vien_theo_Muc_luong(Du_lieu, Muc_luong_Min, Muc_luong_Max)

        ' Ket xuat chuoi ket qua
        Dim Chuoi_Ket_qua As String = ""
        Chuoi_Ket_qua &= "Có " & Danh_sach_Nhan_vien.Count & " nhân viên có mức lương từ " & Muc_luong_Min & " đến " & Muc_luong_Max
        Th_Ket_qua.Text = Chuoi_Ket_qua

        ' Ket xuat danh sach nhan vien
        Th_Danh_sach_Nhan_vien.Controls.Clear()

        For Each Nhan_vien As DataRow In Danh_sach_Nhan_vien
            ' Tao the hien nhan vien
            Dim Th_Nhan_vien As New Button

            ' Xuat tom tat
            Dim Chuoi_Tom_tat As String = Nhan_vien("Ho_ten")
            Th_Nhan_vien.Text = Chuoi_Tom_tat

            ' Xuat thong tin dang ghi chu
            Dim Chuoi_Thong_tin As String = ""
            Chuoi_Thong_tin &= "Họ tên: " & Nhan_vien("Ho_ten") & vbCrLf
            Chuoi_Thong_tin &= "CMND: " & Nhan_vien("CMND") & vbCrLf

            If Nhan_vien("Gioi_tinh") Then
                Chuoi_Thong_tin &= "Giới tính: Nam" & vbCrLf
            Else
                Chuoi_Thong_tin &= "Giới tính: Nữ" & vbCrLf
            End If

            Dim Ngay_sinh As Date = Nhan_vien("Ngay_sinh")
            Chuoi_Thong_tin &= "Ngày sinh: " & Ngay_sinh & vbCrLf
            Dim Tuoi As Integer = Today.Year - Ngay_sinh.Year
            Chuoi_Thong_tin &= "Tuổi: " & Tuoi & vbCrLf

            Chuoi_Thong_tin &= "Mức lương: " & Nhan_vien("Muc_luong") & vbCrLf
            Chuoi_Thong_tin &= "Địa chỉ: " & Nhan_vien("Dia_chi") & vbCrLf
            Chuoi_Thong_tin &= "Đơn vị: " & Nghiep_vu.Don_vi(Nhan_vien)("Ten") & vbCrLf

            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Nhan_vien, Chuoi_Thong_tin)

            ' Dinh dang the hien
            Th_Nhan_vien.Size = New Size(220, 50)
            Th_Nhan_vien.Font = New Font("Arial", 14)
            Th_Nhan_vien.ForeColor = Color.Yellow
            Th_Nhan_vien.BackColor = Color.Black

            ' Bo sung the hien nhan vien vao danh sach the hien nhan vien
            Th_Danh_sach_Nhan_vien.Controls.Add(Th_Nhan_vien)

        Next

    End Sub

End Class
