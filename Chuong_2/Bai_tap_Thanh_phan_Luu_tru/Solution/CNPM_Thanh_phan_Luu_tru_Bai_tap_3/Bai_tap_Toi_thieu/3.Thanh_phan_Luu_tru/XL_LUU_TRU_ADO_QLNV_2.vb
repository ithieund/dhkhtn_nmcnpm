Partial Public Class XL_LUU_TRU
    Protected Function Doc_Du_lieu_QLNV_2() As DataSet
        Dim Kq As New DataSet
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Xml Then
            Kq = Doc_Du_lieu_Xml()
        Else
            Doc_bang("CONG_TY", "", Kq)
            Doc_bang("DON_VI", "", Kq)
            Doc_bang("NGOAI_NGU", "", Kq)
            Doc_bang("NHAN_VIEN", "", Kq)
            Doc_bang("KHA_NANG", "", Kq)
        End If
        Return Kq
    End Function
End Class
