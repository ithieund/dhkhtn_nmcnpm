Public Class MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi

#Region "Bien/Doi tuong toan cuc"
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
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
        Th_Do_tuoi.Text = "20-30"

    End Sub
#End Region

#Region "Xu ly bien co"
    Private Sub Th_Do_tuoi_KeyDown(sender As Object, e As KeyEventArgs) Handles Th_Do_tuoi.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Du_lieu_Nhap()

            If Chuoi_loi <> "" Then
                MsgBox(Chuoi_loi)
            End If

            If Chuoi_loi = "" Then

                ' Nhap lieu tieu chi tra cuu
                Dim Do_tuoi As String = Th_Do_tuoi.Text.Trim
                Dim M As String() = Split(Do_tuoi, "-")
                Dim Can_duoi As Double = M(0)
                Dim Can_tren As Double = M(1)

                ' Xu ly tao danh sach nhan vien tuong ung
                Dim Danh_sach_Nhan_vien As List(Of DataRow) = Nghiep_vu.Danh_sach_Nhan_vien_Theo_Do_Tuoi(Du_lieu, Can_duoi, Can_tren)

                ' Ket xuat danh sach nhan vien
                Th_Danh_sach_Nhan_vien.Controls.Clear()
                Th_Danh_sach_Nhan_vien.AutoScroll = True

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

            End If
        End If
    End Sub

    Function Kiem_tra_Du_lieu_Nhap() As String

        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Do_tuoi As String = Th_Do_tuoi.Text.Trim

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
End Class
