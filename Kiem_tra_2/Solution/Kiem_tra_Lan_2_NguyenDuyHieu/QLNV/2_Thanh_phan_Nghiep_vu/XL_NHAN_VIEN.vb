
Public Class XL_NHAN_VIEN
#Region "Biến/Đối tượng toàn cục"
    Public Readonly Ung_dung As XL_UNG_DUNG
Public Readonly Dong As DataRow
#End Region
  
#Region "Khởi động"
    Public Sub New(Ud As XL_UNG_DUNG, x As DataRow)
        Ung_dung = Ud
        Dong= x
    End Sub
#End Region

#Region "Thuộc tính"

    Public Property ID As Integer
        Get
            Return Dong("ID")
        End Get
        Set(value As Integer)
            Dong("ID") = value
        End Set
    End Property
     Public Property Ho_ten As String
        Get
            Return Dong("Ho_ten")
        End Get
        Set(value As String)
            Dong("Ho_ten") = value
        End Set
    End Property
    Public Property Gioi_tinh As Boolean
        Get
            Return Dong("Gioi_tinh")
        End Get
        Set(value As Boolean)
            Dong("Gioi_tinh") = value
        End Set
    End Property
    Public Property CMND As String
        Get
            Return Dong("CMND")
        End Get
        Set(value As String)
            Dong("CMND") = value
        End Set
    End Property
     Public Property Ngay_sinh As Date
        Get
            Return Dong("Ngay_sinh")
        End Get
        Set(value As Date)
            Dong("Ngay_sinh") = value
        End Set
    End Property
    Public Property Muc_luong As Integer
        Get
            Return Dong("Muc_luong")
        End Get
        Set(value As Integer)
            Dong("Muc_luong") = value
        End Set
    End Property
    Public Property Dia_chi As String
        Get
            Return Dong("Dia_chi")
        End Get
        Set(value As String)
            Dong("Dia_chi") = value
        End Set
    End Property
     Public Property ID_DON_VI As Integer
        Get
            Return Dong("ID_DON_VI")
        End Get
        Set(value As Integer)
            Dong("ID_DON_VI") = value
        End Set
    End Property
#End Region

#Region "Thuộc tính tính toán "
    Public ReadOnly Property Tuoi As Integer
        Get
            Dim kq As Integer
            kq = Today.Year - Ngay_sinh.Year
            Return kq
        End Get
    End Property
#End Region

#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========
    Public ReadOnly Property Don_vi As XL_DON_VI
        Get
            Dim Kq As XL_DON_VI = Nothing
            Kq = Ung_dung.Danh_sach_Don_vi.FirstOrDefault(Function(x) x.ID = ID_DON_VI)
            Return Kq
        End Get
    End Property 
    
    Public ReadOnly Property Chi_nhanh As XL_CHI_NHANH
        Get
            Dim Kq As XL_CHI_NHANH = Don_vi.Chi_nhanh
            Return Kq
        End Get
    End Property
    '====== Liên kết nghịch ========

#End Region

#Region "Tạo Chuỗi"
    '======  Xem Thông tin =====
    Public Function Tao_Chuoi_Tom_tat() As String
        Dim Kq As String = ""
        Kq &= Ho_ten
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin(Optional Co_ID As Boolean = False) As String
        Dim Kq As String = ""
        If Co_ID Then
            Kq &= "ID :" & ID & vbCrLf  '=== Chỉ phục vụ thử nghiệm
        End If

        Dim Chuoi_Gioi_tinh As String = ""
        If Gioi_tinh = True Then
            Chuoi_Gioi_tinh = "Nam"
        Else
            Chuoi_Gioi_tinh = "Nữ"
        End If

        Kq &= "Họ tên : " & Ho_ten & vbCrLf
        Kq &= "Giới tính: " & Chuoi_Gioi_tinh & vbCrLf
        Kq &= "CMND : " & CMND & vbCrLf
        Kq &= "Ngày sinh : " & Ngay_sinh & vbCrLf
        Kq &= "Tuổi:" & Tuoi & vbCrLf
        Kq &= "Mức lương : " & Muc_luong & vbCrLf
        Kq &= "Địa chỉ : " & Dia_chi & vbCrLf
        Kq &= "Đơn vị: " & Don_vi().Tao_Chuoi_Tom_tat() & vbCrLf
        Return Kq
    End Function

    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi() As String
        Dim Kq As String = "Lưu ý khi nhập liệu" & vbCrLf
        Dim Cong_ty As XL_CONG_TY = Ung_dung.Danh_sach_Cong_ty()(0)
        Kq &= "- Họ tên phải khác trống" & vbCrLf
        Kq &= "- CMND phải khác trống và duy nhất" & vbCrLf
        Kq &= "- Điện thoại  phải khác trống" & vbCrLf
        Kq &= "- Địa chỉ  phải khác trống" & vbCrLf
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat( ) As String
        Dim Kq As String = Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi()
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa() As String
        Dim Kq As String = "Lưu ý khi  xóa " & vbCrLf
        Kq &= "- Cần kiểm tra lại :Thật sự muốn xóa  nhân viên ?" & vbCrLf
        Kq &= "- Hiện nay phần mềm chưa có chức năng phục hồi dữ liệu sau khi xóa !!!" & vbCrLf
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi() As String
        Dim Kq As String = ""
        Dim Cong_ty As XL_CONG_TY = Ung_dung.Danh_sach_Cong_ty()(0)
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Ho_ten <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ====  
        Hop_le = CMND <> "" And Ung_dung.Danh_sach_Nhan_vien().FirstOrDefault(
                                                Function(x) x.CMND = CMND And x.ID <> ID) Is Nothing
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Dia_chi <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat() As String
        Dim Kq As String = Kiem_tra_Ghi_moi()
        Return Kq
    End Function
    Public Function Kiem_tra_Xoa() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean =True
        '====== Tự thực hiện =====
        Return Kq
    End Function
#End Region

End Class
