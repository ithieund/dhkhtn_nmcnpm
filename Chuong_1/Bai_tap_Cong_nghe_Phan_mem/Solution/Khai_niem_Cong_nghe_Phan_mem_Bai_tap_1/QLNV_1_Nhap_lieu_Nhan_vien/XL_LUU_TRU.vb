Public Class XL_LUU_TRU

#Region "Bien/Doi tuong toan cuc"
    Dim Ten_CSDL As String = "QLNV_1"
    Dim Thu_muc_CSQL As String = "..\..\..\"
    Dim Duong_dan_Tap_tin_XML As String = Thu_muc_CSQL & Ten_CSDL & ".xml"
#End Region

#Region "Xu ly doc"
    Public Function Doc_Du_Lieu() As DataSet

        Dim Kq As New DataSet
        Kq.ReadXml(Duong_dan_Tap_tin_XML, XmlReadMode.ReadSchema)
        Return Kq

    End Function
#End Region

#Region "Xu ly ghi"
    Public Function Ghi_Moi(Dong As DataRow) As String

        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Dim Du_lieu As DataSet = Bang.DataSet
        Bang.Rows.Add(Dong)
        Du_lieu.WriteXml(Duong_dan_Tap_tin_XML, XmlWriteMode.WriteSchema)
        Return Kq

    End Function

    Public Function Cap_nhat(Dong As DataRow) As String

        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Dim Du_lieu As DataSet = Bang.DataSet
        Du_lieu.WriteXml(Duong_dan_Tap_tin_XML, XmlWriteMode.WriteSchema)
        Return Kq

    End Function
#End Region

End Class
