Public Class XL_NGHIEP_VU


#Region "Trích rút Danh sách đối tượng/đối tượng - theo điều kiện liên kết"
    '===== Liên kết thuận ====
    Public Function Lop_cua_Hoc_sinh(Hoc_sinh As DataRow) As DataRow
        Dim Kq As DataRow = Danh_sach_Lop(Hoc_sinh.Table.DataSet).FirstOrDefault(
                                                Function(x) x("ID") = Hoc_sinh("ID_Lop"))
        Return Kq
    End Function
    Public Function Gioi_tinh_cua_Hoc_sinh(Hoc_sinh As DataRow) As DataRow
        Dim Kq As DataRow = Danh_sach_Gioi_tinh(Hoc_sinh.Table.DataSet).FirstOrDefault(
                                                Function(x) x("ID") = Hoc_sinh("ID_GIOI_TINH"))
        Return Kq
    End Function
    '==== Liên kết nghịch ======
#End Region

#Region "Tạo chuỗi "
    '======  Tra cứu/Xem thông tin =====
    Public Function Tao_Chuoi_Tom_tat_Hoc_sinh(Hoc_sinh As DataRow) As String
        Dim Kq As String = ""
        Kq &= Hoc_sinh("Ho_ten")
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin_Hoc_sinh(Hoc_sinh As DataRow, Optional Co_ID As Boolean = False) As String
        Dim Lop As DataRow = Lop_cua_Hoc_sinh(Hoc_sinh)

        Dim Kq As String = ""
        If Co_ID Then
            Kq &= "ID :" & Hoc_sinh("ID") & vbCrLf
        End If
        Kq &= "Họ tên : " & Hoc_sinh("Ho_ten") & vbCrLf
        Kq &= "CMND : " & Hoc_sinh("CMND") & vbCrLf
        Kq &= "Giới tính : " & Gioi_tinh_cua_Hoc_sinh(Hoc_sinh)("Ten") & vbCrLf
        Kq &= "Ngày sinh : " & Hoc_sinh("Ngay_sinh") & vbCrLf
        Kq &= "Tuổi : " & DateTime.Today.Year - Hoc_sinh("Ngay_sinh").Year & vbCrLf
        Kq &= "Điện thoại : " & Hoc_sinh("Dien_thoai") & vbCrLf
        Kq &= "Mail : " & Hoc_sinh("Mail") & vbCrLf
        Kq &= "Địa chỉ : " & Hoc_sinh("Dia_chi") & vbCrLf
        Kq &= "Lớp : " & Lop_cua_Hoc_sinh(Hoc_sinh)("Ten") & vbCrLf
        Kq &= "Khối : " & Khoi_cua_Lop(Lop)("Ten") & vbCrLf

        Return Kq
    End Function
    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi_Hoc_sinh(Hoc_sinh As DataRow)
        Dim Kq As String = "Lưu ý khi nhập liệu" & vbCrLf
        Dim Du_lieu As DataSet = Hoc_sinh.Table.DataSet
        Kq &= "- Họ tên phải khác trống" & vbCrLf
        Kq &= "- CMND phải khác trống và duy nhất" & vbCrLf
        Kq &= "- Ngày sinh tương ứng tuổi được qui định theo từng khối  " & vbCrLf
        Kq &= "- Điện thoại  phải khác trống" & vbCrLf
        Kq &= "- Mail   phải khác trống" & vbCrLf
        Kq &= "- Địa chỉ  phải khác trống" & vbCrLf
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat_Hoc_sinh(Hoc_sinh As DataRow)
        Dim Kq As String = Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi_Hoc_sinh(Hoc_sinh)
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa_Hoc_sinh(Hoc_sinh As DataRow)
        Dim Kq As String = "Lưu ý khi  xóa " & vbCrLf
        Kq &= "- Cần kiểm tra lại :Thật sự muốn xóa  học sinh ?" & vbCrLf
        Kq &= "- Hiện nay phần mềm chưa có chức năng phục hồi dữ liệu sau khi xóa !!!" & vbCrLf
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "

    Public Function Kiem_tra_Ghi_moi_Hoc_sinh(Hoc_sinh As DataRow) As String
        Dim Kq As String = ""
        Dim Du_lieu As DataSet = Hoc_sinh.Table.DataSet
        Dim Lop As DataRow = Lop_cua_Hoc_sinh(Hoc_sinh)
        Dim Khoi As DataRow = Khoi_cua_Lop(Lop)
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Hoc_sinh("Ho_ten").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ====  
        Hop_le = Hoc_sinh("CMND").ToString.Trim <> "" And Danh_sach_Hoc_sinh(Du_lieu).FirstOrDefault(
                                        Function(x) x("CMND") = Hoc_sinh("CMND").ToString.Trim And
                                                x("ID") <> Hoc_sinh("ID")) Is Nothing
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If


        '=== Kiểm tra Ngày sinh ====
        Dim Tuoi As Integer = Today.Year - Hoc_sinh("Ngay_sinh").Year
        Hop_le = Tuoi >= Khoi("Tuoi_Toi_thieu") And Tuoi <= Khoi("Tuoi_Toi_da")
        If Not Hop_le Then
            Kq &= "Tuổi học sinh từ " & Khoi("Tuoi_Toi_thieu") & " đến " & Khoi("Tuoi_Toi_da") & vbCrLf
        End If
        '=== Kiểm tra điện thoại====
        Hop_le = Hoc_sinh("Dien_thoai").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Điện thoại phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra Mail ====
        Hop_le = Hoc_sinh("Mail").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Mail phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Hoc_sinh("Dia_chi").ToString.Trim <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function

    Public Function Kiem_tra_Cap_nhat_Hoc_sinh(Hoc_sinh As DataRow) As String
        Dim Kq As String = Kiem_tra_Ghi_moi_Hoc_sinh(Hoc_sinh)
        Return Kq
    End Function

    Public Function Kiem_tra_Xoa_Hoc_sinh(Hoc_sinh As DataRow) As String
        Dim Kq As String = ""
        Return Kq
    End Function
#End Region



End Class
