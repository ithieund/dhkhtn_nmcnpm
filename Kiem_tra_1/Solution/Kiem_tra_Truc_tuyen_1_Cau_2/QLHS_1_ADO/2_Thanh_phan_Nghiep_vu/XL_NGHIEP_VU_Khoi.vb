Partial Public Class XL_NGHIEP_VU

#Region "Trích rút Danh sách đối tượng/đối tượng - theo điều kiện liên kết"
    '===== Liên kết thuận ====

    '===== Liên kết nghịch ====
    Public Function Danh_sach_Lop_cua_Khoi(Khoi As DataRow) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Lop(Khoi.Table.DataSet).FindAll(
                                            Function(x) x("ID_Khoi") = Khoi("ID"))

        Return Kq
    End Function

#End Region

#Region "Tạo chuỗi "
    '======  Tra cứu/Xem thông tin =====
    Public Function Tao_Chuoi_Tom_tat_Khoi(Khoi As DataRow) As String
        Dim Kq As String = ""
        Kq &= Khoi("Ten")
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin_Khoi(Khoi As DataRow) As String
        Dim Kq As String = ""
        Kq &= "Tên : " & Khoi("Ten") & vbCrLf
        Kq &= "Điện thoại : " & Khoi("Dien_thoai") & vbCrLf
        Kq &= "Tuổi tối thiểu : " & Khoi("Tuoi_toi_thieu") & vbCrLf
        Kq &= "Tuổi tối đa : " & Khoi("Tuoi_toi_da") & vbCrLf
        Kq &= "Số lớp : " & Danh_sach_Lop_cua_Khoi(Khoi).Count & vbCrLf
        Return Kq
    End Function
    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi_Khoi(Khoi As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat_Khoi(Khoi As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa_Khoi(Khoi As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi_Khoi(Khoi As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat_Khoi(Khoi As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
    Public Function Kiem_tra_Xoa_Khoi(Khoi As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
#End Region

End Class
