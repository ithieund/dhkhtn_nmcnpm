Partial Public Class XL_NGHIEP_VU
    ' Các hàm xử lý  nghiệp vụ dùng chung  liên quan đơn vị
#Region "Trích rút thông tin"

    Public Function Danh_sach_Nhan_vien_theo_Don_vi(Don_vi As DataRow) As List(Of DataRow)
        Dim Kq As List(Of DataRow)
        Dim Du_lieu As DataSet = Don_vi.Table.DataSet
        Kq = Danh_sach_Nhan_vien(Du_lieu).FindAll(
                                    Function(x) x("ID_DON_VI") = Don_vi("ID"))
        Return Kq
    End Function

#End Region

#Region "Tạo chuỗi thông tin"

    Public Function Tao_Chuoi_Thong_tin_Don_vi(Don_vi As DataRow) As String
        Dim Kq As String = ""
        Kq &= "Tên : " & Don_vi("Ten") & vbCrLf
        Kq &= "Số nhân viên : " & Danh_sach_Nhan_vien_theo_Don_vi(Don_vi).Count & vbCrLf
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "


#End Region

End Class
