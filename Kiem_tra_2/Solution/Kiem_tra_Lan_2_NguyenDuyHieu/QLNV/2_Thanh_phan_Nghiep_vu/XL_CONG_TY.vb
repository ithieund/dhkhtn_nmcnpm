
Public Class XL_CONG_TY
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
     Public Property Ten As String
        Get
            Return Dong("Ten")
        End Get
        Set(value As String)
            Dong("Ten") = value
        End Set
    End Property
     Public Property Dien_thoai As String
        Get
            Return Dong("Dien_thoai")
        End Get
        Set(value As String)
            Dong("Dien_thoai") = value
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
     Public Property Tuoi_toi_thieu As Integer
        Get
            Return Dong("Tuoi_toi_thieu")
        End Get
        Set(value As Integer)
            Dong("Tuoi_toi_thieu") = value
        End Set
    End Property
     Public Property Tuoi_toi_da As Integer
        Get
            Return Dong("Tuoi_toi_da")
        End Get
        Set(value As Integer)
            Dong("Tuoi_toi_da") = value
        End Set
    End Property
     Public Property Muc_luong_toi_thieu As Integer
        Get
            Return Dong("Muc_luong_toi_thieu")
        End Get
        Set(value As Integer)
            Dong("Muc_luong_toi_thieu") = value
        End Set
    End Property
#End Region
#Region "Thuộc tính tính toán "
#End Region

#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========
    
    
    '====== Liên kết nghịch ========
    
    
    
#End Region

#Region "Tạo Chuỗi"
 '======  Xem Thông tin =====
    Public Function Tao_Chuoi_Tom_tat() As String
        Dim Kq As String = ""
        Kq &= Ten
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin( Optional Co_ID As Boolean = False) As String
        Dim Kq As String = ""
        If Co_ID Then
           Kq &= "ID :" & ID & vbCrLf  '=== Chỉ phục vụ thử nghiệm
        End If
        
	Kq &= "Tên : " & Ten & vbCrLf
	Kq &= "Điện thoại : " & Dien_thoai & vbCrLf
	Kq &= "Địa chỉ : " & Dia_chi & vbCrLf
	Kq &= "Tuoi_toi_thieu : " & Tuoi_toi_thieu & vbCrLf
	Kq &= "Tuoi_toi_da : " & Tuoi_toi_da & vbCrLf
	Kq &= "Muc_luong_toi_thieu : " & Muc_luong_toi_thieu & vbCrLf
	
        Return Kq
    End Function
    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi() As String 
        Dim Kq As String =  ""
        '====== Tự thực hiện =====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat( ) As String 
        Dim Kq As String =  ""
        '====== Tự thực hiện =====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa() As String
        Dim Kq As String = ""
        '====== Tự thực hiện =====
        Return Kq
    End Function
#End Region
#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean = True
        '=== Tên khác trống và duy nhất 
        Hop_le = Ten <> "" AndAlso Ung_dung.Danh_sach_Cong_ty.FirstOrDefault(
                                        Function(x) x.ID <> ID And x.Ten = Ten) Is Nothing
        If Not Hop_le Then
            Kq &= "Tên phải khác trống và duy nhất " & vbCrLf
        End If
        '=== Kiểm tra điện thoại====
        Hop_le = Dien_thoai <> ""
        If Not Hop_le Then
            Kq &= "Điện thoại phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Dia_chi <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        '=== Tuổi tối thiểu là số nguyên >18
        Hop_le = Tuoi_toi_thieu >= 18
        If Not Hop_le Then
            Kq &= "Tuổi tối thiểu >=18" & vbCrLf
        End If
        '=== Tuổi tối đa là số nguyên >=Tuổi tối thiểu và <=120
        Hop_le = Tuoi_toi_da >= Tuoi_toi_thieu And Tuoi_toi_da <= 120
        If Not Hop_le Then
            Kq &= "Tuổi tối đa>=" & Tuoi_toi_thieu & " Tuổi tối đa <=120 " & vbCrLf
        End If
        '=== Mức lương tối thiểu à số nguyên >3500000
        Hop_le = Muc_luong_toi_thieu >= 3500000
        If Not Hop_le Then
            Kq &= "Mức lương  tối thiểu >=3500000" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat() As String
        Dim Kq As String = Kiem_tra_Ghi_moi()

        Return Kq
    End Function
    Public Function Kiem_tra_Xoa() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean = False
        If Not Hop_le Then
            Kq &= "Không thể xóa vì Công ty " & vbCrLf
        End If
        Return Kq
    End Function
#End Region

End Class
