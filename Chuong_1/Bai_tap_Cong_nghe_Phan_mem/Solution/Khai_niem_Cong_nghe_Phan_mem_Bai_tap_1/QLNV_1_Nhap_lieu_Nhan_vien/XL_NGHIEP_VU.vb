Public Class XL_NGHIEP_VU

#Region "Khai thac thong tin"
    Public Function Danh_sach_Nhan_vien_theo_Don_vi(Don_vi As DataRow) As List(Of DataRow)

        Dim Kq As List(Of DataRow)
        Dim Du_lieu As DataSet = Don_vi.Table.DataSet
        Dim Bang_Nhan_vien As DataTable = Du_lieu.Tables("NHAN_VIEN")
        Dim Dieu_kien As String = "ID_DON_VI = " & Don_vi("ID")
        Kq = Bang_Nhan_vien.Select(Dieu_kien).ToList
        Return Kq

    End Function

    Public Function Danh_sach_Nhan_vien_Theo_Muc_luong(Du_lieu As DataSet, Can_duoi As Double, Can_tren As Double) As List(Of DataRow)

        Dim Kq As List(Of DataRow)
        Dim Danh_sach_Nhan_vien As List(Of DataRow) = Du_lieu.Tables("NHAN_VIEN").Select.ToList
        Kq = Danh_sach_Nhan_vien.FindAll(Function(x) x("Muc_luong") >= Can_duoi And x("Muc_luong") <= Can_tren)
        Return Kq

    End Function

    Public Function Don_vi(Nhan_vien As DataRow) As DataRow

        Dim Kq As DataRow
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Dim Bang_Don_vi As DataTable = Du_lieu.Tables("DON_VI")
        Dim Dieu_kien As String = "ID = " & Nhan_vien("ID_DON_VI")
        Kq = Bang_Don_vi.Select(Dieu_kien)(0)
        Return Kq

    End Function
#End Region

#Region "Tiep nhan thong tin"
    Public Function Tao_Nhan_vien_Moi(Du_lieu As DataSet) As DataRow

        Dim Nhan_vien As DataRow = Du_lieu.Tables("NHAN_VIEN").NewRow
        Nhan_vien("Ho_ten") = ""
        Nhan_vien("Gioi_tinh") = True
        Nhan_vien("CMND") = ""
        Nhan_vien("Ngay_sinh") = New DateTime(Today.Year - 30, 1, 1)
        Nhan_vien("Muc_luong") = 4000000
        Nhan_vien("Dia_chi") = ""
        Nhan_vien("ID_DON_VI") = Du_lieu.Tables("DON_VI").Rows(0)("ID")
        Return Nhan_vien

    End Function

    Public Function Kiem_tra_Ghi_moi_Nhan_vien(Nhan_vien As DataRow) As String

        ' Lay ra cac thong tin tham chieu
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Dim Cong_ty As DataRow = Du_lieu.Tables("CONG_TY").Rows(0)

        ' Khoi tao cac bien kiem tra
        Dim Hop_le As Boolean
        Dim Kq As String = ""

        ' Kiem tra ho ten phai khac rong
        Hop_le = Nhan_vien("Ho_ten").ToString.Trim <> ""

        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If

        ' Kiem tra cmnd phai khac rong va la duy nhat
        Dim CMND As String = Nhan_vien("CMND")
        Hop_le = CMND <> "" And Du_lieu.Tables("NHAN_VIEN").Select("CMND='" & CMND & "'").Count = 0

        If Not Hop_le Then
            Kq &= "CMND phải khác trống và là duy nhất" & vbCrLf
        End If

        ' Kiem tra muc luong phai la so nguyen duong
        Hop_le = Nhan_vien("Muc_luong") > 0

        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên > 0 " & vbCrLf
        End If

        ' Kiem tra ngay sinh hop le
        Dim Tuoi_Toi_thieu = Cong_ty("Tuoi_Toi_thieu")
        Dim Tuoi_Toi_da = Cong_ty("Tuoi_Toi_da")
        Dim Tuoi As Integer = Today.Year - Nhan_vien("Ngay_sinh").Year

        Hop_le = Tuoi >= Tuoi_Toi_thieu And Tuoi <= Tuoi_Toi_da

        If Not Hop_le Then
            Kq &= "Tuổi nhân viên phải từ " & Tuoi_Toi_thieu & " đến " & Tuoi_Toi_da & vbCrLf
        End If

        ' Kiem tra dia chi phai khac rong
        Hop_le = Nhan_vien("Dia_chi").ToString.Trim <> ""

        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If

        Return Kq

    End Function

    Public Function Kiem_tra_Cap_nhat_Nhan_vien(Nhan_vien As DataRow) As String

        ' Lay ra cac thong tin tham chieu
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Dim Cong_ty As DataRow = Du_lieu.Tables("CONG_TY").Rows(0)

        ' Khoi tao cac bien kiem tra
        Dim Hop_le As Boolean
        Dim Kq As String = ""

        ' Kiem tra ho ten phai khac rong
        Hop_le = Nhan_vien("Ho_ten").ToString.Trim <> ""

        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If

        ' Kiem tra cmnd phai khac rong va la duy nhat
        Dim CMND As String = Nhan_vien("CMND")
        Hop_le = CMND <> "" And Du_lieu.Tables("NHAN_VIEN").Select("ID <> " & Nhan_vien("ID") & " AND CMND='" & CMND & "'").Count = 0

        If Not Hop_le Then
            Kq &= "CMND phải khác trống và là duy nhất" & vbCrLf
        End If

        ' Kiem tra muc luong phai la so nguyen duong
        Hop_le = Nhan_vien("Muc_luong") > 0

        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên > 0 " & vbCrLf
        End If

        ' Kiem tra ngay sinh hop le
        Dim Tuoi_Toi_thieu = Cong_ty("Tuoi_Toi_thieu")
        Dim Tuoi_Toi_da = Cong_ty("Tuoi_Toi_da")
        Dim Tuoi As Integer = Today.Year - Nhan_vien("Ngay_sinh").Year

        Hop_le = Tuoi >= Tuoi_Toi_thieu And Tuoi <= Tuoi_Toi_da

        If Not Hop_le Then
            Kq &= "Tuổi nhân viên phải từ " & Tuoi_Toi_thieu & " đến " & Tuoi_Toi_da & vbCrLf
        End If

        ' Kiem tra dia chi phai khac rong
        Hop_le = Nhan_vien("Dia_chi").ToString.Trim <> ""

        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If

        Return Kq

    End Function
#End Region

End Class
