Partial Public Class XL_NGHIEP_VU

#Region "Trích rút Danh sách đối tượng/đối tượng - theo điều kiện liên kết"
    '===== Liên kết thuận ====
    Public Function Khoi_cua_Lop(Lop As DataRow) As DataRow
        Dim Kq As DataRow = Danh_sach_Khoi(Lop.Table.DataSet).FirstOrDefault(
                                                Function(x) x("ID") = Lop("ID_Khoi"))
        Return Kq
    End Function
    '===== Liên kết nghịch ====
    Public Function Danh_sach_Hoc_sinh_cua_Lop(Lop As DataRow) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Hoc_sinh(Lop.Table.DataSet).FindAll(
                                            Function(x) x("ID_LOP") = Lop("ID"))

        Return Kq
    End Function

#End Region

#Region "Tạo chuỗi "
    '======  Tra cứu/Xem thông tin =====
    Public Function Tao_Chuoi_Tom_tat_Lop(Lop As DataRow) As String
        Dim Kq As String = ""
        Kq &= Lop("Ten")
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin_Lop(Lop As DataRow) As String
        Dim Kq As String = ""
        Kq &= "Tên : " & Lop("Ten") & vbCrLf
        Kq &= "Khối : " & Khoi_cua_Lop(Lop)("Ten") & vbCrLf
        Kq &= "Số học sinh : " & Danh_sach_Hoc_sinh_cua_Lop(Lop).Count & vbCrLf
        Return Kq
    End Function
    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi_Lop(Lop As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat_Lop(Lop As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa_Lop(Lop As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi_Lop(Lop As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat_Lop(Lop As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
    Public Function Kiem_tra_Xoa_Lop(Lop As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
#End Region

End Class
