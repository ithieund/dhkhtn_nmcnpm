' Thông báo PET : Đây chỉ  là phần mở đầu cho việc cải tiến BL
Public Class XL_CHUC_NANG
#Region "Biến đối tượng Toàn cục"
    Public ReadOnly Ten As String
    Public ReadOnly Ma_so As String
    Public ReadOnly Ung_dung As XL_UNG_DUNG
#End Region
#Region "Khởi động"
    Public Sub New(Ung_dung As XL_UNG_DUNG, Ten As String, Ma_so As String)
        Me.Ung_dung = Ung_dung
        Me.Ten = Ten
        Me.Ma_so = Ma_so
    End Sub
#End Region
End Class
