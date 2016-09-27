Partial Public Class XL_NGHIEP_VU

#Region "Trích rút Danh sách đối tượng/đối tượng - theo điều kiện liên kết"
    '===== Liên kết thuận ====

    '===== Liên kết nghịch ====
    Public Function Danh_sach_Hoc_sinh_cua_Gioi_tinh(Gioi_tinh As DataRow) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Hoc_sinh(Gioi_tinh.Table.DataSet).FindAll(
                                            Function(x) x("ID_GIOI_TINH") = Gioi_tinh("ID"))

        Return Kq
    End Function

#End Region

#Region "Tạo chuỗi "
    '======  Tra cứu/Xem thông tin =====
    Public Function Tao_Chuoi_Tom_tat_Gioi_tinh(Gioi_tinh As DataRow) As String
        Dim Kq As String = ""
        Kq &= Gioi_tinh("Ten")
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin_Gioi_tinh(Gioi_tinh As DataRow) As String
        Dim Kq As String = ""
        Kq &= "Tên : " & Gioi_tinh("Ten") & vbCrLf
        Kq &= "Số học sinh : " & Danh_sach_Hoc_sinh_cua_Gioi_tinh(Gioi_tinh).Count & vbCrLf
        Return Kq
    End Function
    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi_Gioi_tinh(Gioi_tinh As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat_Gioi_tinh(Gioi_tinh As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa_Gioi_tinh(Gioi_tinh As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi_Gioi_tinh(Gioi_tinh As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat_Gioi_tinh(Gioi_tinh As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
    Public Function Kiem_tra_Xoa_Gioi_tinh(Gioi_tinh As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
#End Region

End Class
