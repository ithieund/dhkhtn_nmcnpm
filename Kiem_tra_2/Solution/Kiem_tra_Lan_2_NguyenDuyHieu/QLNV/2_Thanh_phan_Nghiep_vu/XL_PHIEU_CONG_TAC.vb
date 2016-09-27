
Public Class XL_PHIEU_CONG_TAC
#Region "Biến/Đối tượng toàn cục"
    Public ReadOnly Ung_dung As XL_UNG_DUNG
    Public ReadOnly Dong As DataRow
#End Region

#Region "Khởi động"
    Public Sub New(Ud As XL_UNG_DUNG, x As DataRow)
        Ung_dung = Ud
        Dong = x
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
    Public Property Tinh_thanh_pho As String
        Get
            Return Dong("Tinh_thanh_pho")
        End Get
        Set(value As String)
            Dong("Tinh_thanh_pho") = value
        End Set
    End Property
    Public Property Ngay_bat_dau As Date
        Get
            Return Dong("Ngay_bat_dau")
        End Get
        Set(value As Date)
            Dong("Ngay_bat_dau") = value
        End Set
    End Property
    Public Property So_ngay As Integer
        Get
            Return Dong("So_ngay")
        End Get
        Set(value As Integer)
            Dong("So_ngay") = value
        End Set
    End Property
    Public Property ID_NHAN_VIEN As Integer
        Get
            Return Dong("ID_NHAN_VIEN")
        End Get
        Set(value As Integer)
            Dong("ID_NHAN_VIEN") = value
        End Set
    End Property
#End Region

#Region "Thuộc tính tính toán "
#End Region

#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========
    Public ReadOnly Property Nhan_vien As XL_NHAN_VIEN
        Get
            Dim Kq As XL_NHAN_VIEN = Nothing
            Kq = Ung_dung.Danh_sach_Nhan_vien.FirstOrDefault(Function(x) x.ID = ID_NHAN_VIEN)
            Return Kq
        End Get
    End Property

    Public ReadOnly Property Don_vi As XL_DON_VI
        Get
            Dim Kq As XL_DON_VI = Nhan_vien.Don_vi
            Return Kq
        End Get
    End Property
    '====== Liên kết nghịch ========

#End Region

#Region "Tạo Chuỗi"
    '======  Xem Thông tin =====
    Public Function Tao_Chuoi_Tom_tat() As String
        Dim Kq As String = ""
        Kq &= "Phiếu " & ID
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin(Optional Co_ID As Boolean = False) As String
        Dim Kq As String = ""
        If Co_ID Then
            Kq &= "ID :" & ID & vbCrLf  '=== Chỉ phục vụ thử nghiệm
        End If

        Kq &= "Phiếu " & ID & vbCrLf
        Kq &= "Ngày bắt đầu : " & Ngay_bat_dau & vbCrLf
        Kq &= "Số ngày : " & So_ngay & vbCrLf
        Kq &= "Nhân viên : " & Nhan_vien().Tao_Chuoi_Tom_tat() & vbCrLf
        Kq &= "Đơn vị: " & Don_vi().Tao_Chuoi_Tom_tat() & vbCrLf
        Return Kq
    End Function

    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi() As String
        Dim Kq As String = "Lưu ý khi nhập liệu" & vbCrLf
        Kq &= "- Dùng thực đơn động để chọn nhân viên" & vbCrLf
        Kq &= "- Ngày bắt đầu không thể là ngày trong quá khứ" & vbCrLf
        Kq &= "- Số ngày phải là số nguyên dương" & vbCrLf
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat() As String
        Dim Kq As String = "Lưu ý khi nhập liệu" & vbCrLf
        Kq &= "- Dùng thực đơn động để chọn nhân viên" & vbCrLf
        Kq &= "- Số ngày phải là số nguyên dương" & vbCrLf
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa() As String
        Dim Kq As String = "Lưu ý khi  xóa " & vbCrLf
        Kq &= "- Bạn phải kiểm tra lại có chắc chắn muốn xóa hay không?" & vbCrLf
        Kq &= "- Một khi đã xóa thì không thể phục hồi!!!" & vbCrLf
        Return Kq
    End Function
#End Region

#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean

        Hop_le = Ngay_bat_dau >= Date.Today
        If Not Hop_le Then
            Kq &= "Ngày bắt đầu không thể là ngày trong quá khứ" & vbCrLf
        End If

        Hop_le = So_ngay > 0
        If Not Hop_le Then
            Kq &= "Số ngày phải là số nguyên dương" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat() As String
        Dim Kq As String = Kiem_tra_Ghi_moi()
        Dim Hop_le As Boolean

        Hop_le = Ngay_bat_dau >= Date.Today
        If Not Hop_le Then
            Kq &= "Ngày bắt đầu không thể là ngày trong quá khứ" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_tra_Xoa() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean = True
        Return Kq
    End Function
#End Region

End Class
