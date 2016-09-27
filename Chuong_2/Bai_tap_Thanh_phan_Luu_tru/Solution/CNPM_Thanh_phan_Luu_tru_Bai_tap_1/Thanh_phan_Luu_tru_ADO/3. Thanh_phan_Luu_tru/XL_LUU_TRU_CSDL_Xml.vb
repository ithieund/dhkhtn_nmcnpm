Imports System.Xml
Partial Public Class XL_LUU_TRU
#Region "Biến/Đối tượng toàn cục"

#End Region

#Region "Xử lý Đọc/Ghi Dữ liệu cấu trúc"
    Protected Function Doc_Du_lieu_Xml() As DataSet
        Dim Kq As New DataSet
        Kq.ReadXml(Duong_dan_Tap_tin_Xml, XmlReadMode.ReadSchema)
        Return Kq
    End Function

    Protected Function Ghi_moi_Xml(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Dim Du_lieu As DataSet = Bang.DataSet
        Bang.Rows.Add(Dong)
        Du_lieu.WriteXml(Duong_dan_Tap_tin_Xml, XmlWriteMode.WriteSchema)
        Return Kq
    End Function
    Protected Function Cap_nhat_Xml(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Dim Du_lieu As DataSet = Bang.DataSet
        Du_lieu.WriteXml(Duong_dan_Tap_tin_Xml, XmlWriteMode.WriteSchema)
        Return Kq
    End Function
    Protected Function Xoa_Xml(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Dim Du_lieu As DataSet = Bang.DataSet
        Bang.Rows.Remove(Dong)
        Du_lieu.WriteXml(Duong_dan_Tap_tin_Xml, XmlWriteMode.WriteSchema)
        Return Kq
    End Function
#End Region
End Class
