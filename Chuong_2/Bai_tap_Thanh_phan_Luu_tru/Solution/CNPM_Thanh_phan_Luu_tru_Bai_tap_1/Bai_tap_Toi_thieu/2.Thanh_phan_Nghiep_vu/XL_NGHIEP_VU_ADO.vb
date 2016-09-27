Partial Public Class XL_NGHIEP_VU
    ' Các hàm xử lý nghiệp vụ ADO dùng chung 
#Region "Trích rút thông tin"
    Public Function Danh_sach_Cong_ty(Du_lieu As DataSet) As List(Of DataRow)
        Dim kq As List(Of DataRow) = Du_lieu.Tables("CONG_TY").Select.ToList
        Return kq
    End Function
    Public Function Danh_sach_Don_vi(Du_lieu As DataSet) As List(Of DataRow)
        Dim kq As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList
        Return kq
    End Function
    Public Function Danh_sach_Nhan_vien(Du_lieu As DataSet) As List(Of DataRow)
        Dim kq As List(Of DataRow) = Du_lieu.Tables("NHAN_VIEN").Select.ToList
        Return kq
    End Function
    Public Function Danh_sach_Nhan_vien_theo_Muc_luong(Du_lieu As DataSet, Can_duoi As Double, Can_tren As Double) As List(Of DataRow)
        Dim Kq As List(Of DataRow)
        Kq = Danh_sach_Nhan_vien(Du_lieu).FindAll(Function(x) x("Muc_luong") >= Can_duoi And x("Muc_luong") <= Can_tren)
        Return Kq
    End Function
#End Region
#Region "Tạo Chuỗi thông tin"

#End Region
#Region "Tạo đối tượng mới"
    Public Function Tao_Nhan_vien_moi(Du_lieu As DataSet) As DataRow
        Dim Nhan_vien As DataRow = Du_lieu.Tables("NHAN_VIEN").NewRow
        Nhan_vien("Ho_ten") = ""
        Nhan_vien("Gioi_tinh") = True
        Nhan_vien("CMND") = ""
        Nhan_vien("Ngay_sinh") = New DateTime(Today.Year - 30, 1, 1)
        Nhan_vien("Muc_luong") = 4000000
        Nhan_vien("Dia_chi") = ""
        Nhan_vien("ID_DON_VI") = Danh_sach_Don_vi(Du_lieu)(0)("ID")
        Return Nhan_vien
    End Function
#End Region
End Class
