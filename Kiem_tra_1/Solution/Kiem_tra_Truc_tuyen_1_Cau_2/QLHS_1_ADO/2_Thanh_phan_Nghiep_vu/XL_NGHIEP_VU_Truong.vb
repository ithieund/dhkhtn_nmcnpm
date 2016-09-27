Partial Public Class XL_NGHIEP_VU

#Region "Trích rút Danh sách đối tượng/đối tượng - theo điều kiện liên kết"
    '===== Liên kết thuận ====

    '===== Liên kết nghịch ====


#End Region

#Region "Tạo chuỗi "
    '======  Tra cứu/Xem thông tin =====
    Public Function Tao_Chuoi_Tom_tat_Truong(Truong As DataRow) As String
        Dim Kq As String = ""
        Kq &= Truong("Ten")
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin_Truong(Truong As DataRow) As String
        Dim Kq As String = ""
        Kq &= "Tên : " & Truong("Ten") & vbCrLf
        Kq &= "Điện thoại : " & Truong("Dien_thoai") & vbCrLf
        Kq &= "Địa chỉ : " & Truong("Dia_chi") & vbCrLf


        Return Kq
    End Function
    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi_Truong(Truong As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat_Truong(Truong As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa_Truong(Truong As DataRow)
        Dim Kq As String = ""
        '=== Sinh viên tự thực hiện ====
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi_Truong(Truong As DataRow) As String
        Dim Kq As String = "Hàm này dành cho việc phát triển trong tương lai"
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat_Truong(Truong As DataRow) As String
        Dim Kq As String = "Sinh viên tự thực hiện"
        Return Kq
    End Function
    Public Function Kiem_tra_Xoa_Truong(Truong As DataRow) As String
        Dim Kq As String = "Hàm này dành cho việc phát triển trong tương lai"
        Return Kq
    End Function
#End Region

End Class
