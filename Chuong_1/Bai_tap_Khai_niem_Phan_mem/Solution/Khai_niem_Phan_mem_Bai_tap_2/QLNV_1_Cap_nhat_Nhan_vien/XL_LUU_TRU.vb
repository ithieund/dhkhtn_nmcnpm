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

    ' Xu ly cap nhat
    Public Function Cap_nhat(Dong As DataRow) As String

        Dim Bang As DataTable = Dong.Table
        Dim Du_lieu As DataSet = Bang.DataSet

        Try
            Du_lieu.WriteXml(Duong_dan_Tap_tin_Xml, XmlWriteMode.WriteSchema)
            Return ""
        Catch ex As Exception
            Return "Không cập nhật được dữ liệu"
        End Try

    End Function

End Class
