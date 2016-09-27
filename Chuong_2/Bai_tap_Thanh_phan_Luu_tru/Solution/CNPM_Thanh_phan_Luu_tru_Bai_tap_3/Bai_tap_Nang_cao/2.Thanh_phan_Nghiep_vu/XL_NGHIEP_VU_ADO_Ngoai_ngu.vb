Partial Public Class XL_NGHIEP_VU
    ' Các hàm xử lý  nghiệp vụ dùng chung  liên quan ngoại ngữ
#Region "Trích rút thông tin"

    Public Function Danh_sach_Nhan_vien_Theo_1_Ngoai_ngu(Ngoai_ngu As DataRow) As List(Of DataRow)
        Dim Kq As List(Of DataRow)
        Dim Du_lieu As DataSet = Ngoai_ngu.Table.DataSet
        Kq = Danh_sach_Nhan_vien(Du_lieu).FindAll(
                                    Function(x) Du_lieu.Tables("KHA_NANG").Select("ID_NHAN_VIEN =  " & x("ID") & " AND ID_NGOAI_NGU = " & Ngoai_ngu("ID")).Count > 0)
        Return Kq
    End Function

#End Region

#Region "Tạo chuỗi thông tin"

    Public Function Tao_Chuoi_Thong_tin_Ngoai_ngu(Ngoai_ngu As DataRow) As String
        Dim Kq As String = ""
        Kq &= "Tên ngoại ngữ: " & Ngoai_ngu("Ten") & vbCrLf
        Kq &= "Số nhân viên biết ngoại ngữ này: " & Danh_sach_Nhan_vien_theo_Don_vi(Ngoai_ngu).Count & vbCrLf
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "


#End Region

End Class
