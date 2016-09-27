Public Class XL_LUU_TRU

    ' Bien/Doi tuong toan cuc
    Dim Ten_Csdl As String = "QLNV_1"
    Dim Thu_muc_Csdl As String = "..\..\..\"
    Dim Duong_dan_Tap_tin_Xml As String = Thu_muc_Csdl & Ten_Csdl & ".xml"

    ' Xu ly doc
    Public Function Doc_Du_Lieu() As DataSet

        Dim Kq As New DataSet
        Kq.ReadXml(Duong_dan_Tap_tin_Xml, XmlReadMode.ReadSchema)
        Return Kq

    End Function

End Class
