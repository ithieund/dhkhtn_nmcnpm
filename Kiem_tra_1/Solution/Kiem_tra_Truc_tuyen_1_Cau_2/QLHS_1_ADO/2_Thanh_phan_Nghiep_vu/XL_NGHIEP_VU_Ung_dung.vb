Partial Public Class XL_NGHIEP_VU



#Region "Trích rút danh sách đối tượng - Không điều kiện"
    Public Function Danh_sach_Truong(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("Truong").Select.ToList
        Return Kq
    End Function
    Public Function Danh_sach_Khoi(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("Khoi").Select.ToList
        Return Kq
    End Function
    Public Function Danh_sach_Lop(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("Lop").Select.ToList
        Return Kq
    End Function
    Public Function Danh_sach_Gioi_tinh(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("GIOI_TINH").Select.ToList
        Return Kq
    End Function
    Public Function Danh_sach_Hoc_sinh(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("Hoc_sinh").Select.ToList
        Return Kq
    End Function
#End Region

#Region "Trích rút đối tượng -  theo ID"
    Public Function Truong(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_Truong(Du_lieu).FirstOrDefault(
            Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Khoi(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_Khoi(Du_lieu).FirstOrDefault(
            Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Lop(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_Lop(Du_lieu).FirstOrDefault(
            Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Gioi_tinh(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_Gioi_tinh(Du_lieu).FirstOrDefault(
            Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Hoc_sinh(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_Hoc_sinh(Du_lieu).FirstOrDefault(
            Function(x) x("ID") = ID)
        Return Kq
    End Function
#End Region

#Region "Tạo đối tượng mới "
    Public Function Tao_Truong_moi(Du_lieu As DataSet) As DataRow ' Dự trù cho tương lai
        Dim Truong As DataRow = Du_lieu.Tables("Truong").NewRow
        Truong("Ten") = "Tên" & Truong("ID")
        Truong("Dien_thoai") = "Điện thoại " & Truong("ID")
        Truong("Dia_chi") = "Địa chỉ " & Truong("ID")
        Return Truong
    End Function
    Public Function Tao_Khoi_moi(Du_lieu As DataSet) As DataRow
        Dim Khoi As DataRow = Du_lieu.Tables("Khoi").NewRow
        Khoi("Ten") = "Tên" & Khoi("ID")
        Khoi("Tuoi_toi_thieu") = 15
        Khoi("Tuoi_toi_da") = 20
        Return Khoi
    End Function
    Public Function Tao_Lop_moi(Du_lieu As DataSet) As DataRow
        Dim Lop As DataRow = Du_lieu.Tables("Lop").NewRow
        Lop("Ten") = "Tên " & Lop("ID")
        Lop("ID_Khoi") = Danh_sach_Khoi(Du_lieu)(0)("ID")
        Return Lop
    End Function
    Public Function Tao_Gioi_tinh_moi(Du_lieu As DataSet) As DataRow
        Dim Gioi_tinh As DataRow = Du_lieu.Tables("GIOI_TINH").NewRow
        Gioi_tinh("Ten") = "Tên " & Gioi_tinh("ID")
        Gioi_tinh("Ma_so") = "Mã số " & Gioi_tinh("ID")
        Return Gioi_tinh
    End Function
    Public Function Tao_Hoc_sinh_moi(Du_lieu As DataSet) As DataRow
        Dim Hoc_sinh As DataRow = Du_lieu.Tables("Hoc_sinh").NewRow
        Hoc_sinh("Ho_ten") = "Họ tên " & Hoc_sinh("ID")
        Hoc_sinh("ID_GIOI_TINH") = Danh_sach_Gioi_tinh(Du_lieu)(0)("ID")
        Hoc_sinh("CMND") = "CMND " & Hoc_sinh("ID")
        Hoc_sinh("Mail") = "Mail " & Hoc_sinh("ID")
        Hoc_sinh("Dien_thoai") = "Điện thoại " & Hoc_sinh("ID")
        Hoc_sinh("Ngay_sinh") = New DateTime(Today.Year - 16, 1, 1)
        Hoc_sinh("Dia_chi") = "Địa chỉ " & Hoc_sinh("ID")
        Hoc_sinh("ID_Lop") = Danh_sach_Lop(Du_lieu)(0)("ID")
        Return Hoc_sinh
    End Function
#End Region

#Region "Xử lý trích rút Danh sách đối tượng - theo điều kiện  "
    '===== Trích rút Danh sách học sinh  =====

    Public Function Danh_sach_Hoc_sinh_theo_Ho_ten(Du_lieu As DataSet, Chuoi As String) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Hoc_sinh(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("Ho_ten").ToString.Trim.ToUpper.Contains(Chuoi.Trim.ToUpper))
        Return Kq
    End Function


    '===  Các Trích rút khác - Sinh viên tự thực hiện =====

#End Region



End Class
