Public Class XL_NGHIEP_VU
    ' Các hàm xử lý  nghiệp vụ dùng chung  liên quan nhân viên
#Region "Trích rút thông tin"
    Public Function Don_vi(Nhan_vien As DataRow) As DataRow
        Dim Kq As DataRow
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Kq = Danh_sach_Don_vi(Du_lieu).FirstOrDefault(
                            Function(x) x("ID") = Nhan_vien("ID_DON_VI"))
        Return Kq
    End Function

#End Region

#Region "Tạo chuỗi thông tin"
    Public Function Tao_Chuoi_Thong_tin_Nhan_vien(Nhan_vien As DataRow) As String
        Dim Kq As String = ""
        Kq &= "Họ tên : " & Nhan_vien("Ho_ten") & vbCrLf
        Kq &= "CMND : " & Nhan_vien("CMND") & vbCrLf
        If Nhan_vien("Gioi_tinh") Then
            Kq &= "Giới tính : Nam" & vbCrLf
        Else
            Kq &= "Giới tính : Nữ" & vbCrLf
        End If
        Dim Ngay_sinh As Date = Nhan_vien("Ngay_sinh")
        Kq &= "Ngày sinh : " & Ngay_sinh & "  "
        Dim Tuoi As Integer = Date.Today.Year - Ngay_sinh.Year
        Kq &= "Tuổi : " & Tuoi & vbCrLf
        Kq &= "Mức lương: " & Nhan_vien("Muc_luong") & vbCrLf
        Kq &= "Địa chỉ : " & Nhan_vien("Dia_chi") & vbCrLf
        Kq &= "Đơn vị : " & Don_vi(Nhan_vien)("Ten") & vbCrLf
        Return Kq
    End Function

#End Region

#Region "Kiểm tra "

    Public Function Kiem_tra_Ghi_moi_Nhan_vien(Nhan_vien As DataRow) As String
        Dim Kq As String = ""
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Dim Cong_ty As DataRow = Danh_sach_Cong_ty(Du_lieu)(0)
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Nhan_vien("Ho_ten").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ====
        Dim CMND As String = Nhan_vien("CMND")
        Hop_le = CMND <> "" And Danh_sach_Nhan_vien(Du_lieu).FirstOrDefault(
                                                    Function(x) x("CMND") = CMND) Is Nothing
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If
        '=== Kiểm tra Mức lương ====
        Hop_le = Nhan_vien("Muc_luong") > 0
        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên > 0 " & vbCrLf
        End If
        '=== Kiểm tra Ngày sinh ====
        Dim Tuoi_Toi_thieu = Cong_ty("Tuoi_Toi_thieu")
        Dim Tuoi_Toi_da = Cong_ty("Tuoi_Toi_da")
        Dim Tuoi As Integer = Today.Year - Nhan_vien("Ngay_sinh").Year
        Hop_le = Tuoi >= Tuoi_Toi_thieu And Tuoi <= Tuoi_Toi_da
        If Not Hop_le Then
            Kq &= "Tuổi nhân viên từ " & Tuoi_Toi_thieu & " đến " & Tuoi_Toi_da & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Nhan_vien("Dia_chi").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function

    Public Function Kiem_tra_Cap_nhat_Nhan_vien(Nhan_vien As DataRow) As String
        Dim Kq As String = ""
        Dim Du_lieu As DataSet = Nhan_vien.Table.DataSet
        Dim Cong_ty As DataRow = Danh_sach_Cong_ty(Du_lieu)(0)
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Nhan_vien("Ho_ten").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ====
        Dim CMND As String = Nhan_vien("CMND")
        Dim ID As Integer = Nhan_vien("ID")
        Hop_le = CMND <> "" And Danh_sach_Nhan_vien(Du_lieu).FirstOrDefault(
                                                    Function(x) x("ID") <> ID And x("CMND") = CMND) Is Nothing
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If
        '=== Kiểm tra Mức lương ====
        Hop_le = Nhan_vien("Muc_luong") > 0
        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên > 0 " & vbCrLf
        End If
        '=== Kiểm tra Ngày sinh ====
        Dim Tuoi_Toi_thieu = Cong_ty("Tuoi_Toi_thieu")
        Dim Tuoi_Toi_da = Cong_ty("Tuoi_Toi_da")
        Dim Tuoi As Integer = Today.Year - Nhan_vien("Ngay_sinh").Year
        Hop_le = Tuoi >= Tuoi_Toi_thieu And Tuoi <= Tuoi_Toi_da
        If Not Hop_le Then
            Kq &= "Tuổi nhân viên từ " & Tuoi_Toi_thieu & " đến " & Tuoi_Toi_da & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Nhan_vien("Dia_chi").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function


#End Region

End Class
