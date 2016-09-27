Partial Public Class XL_LUU_TRU
    Protected Function Doc_Du_lieu_QLNV_3() As DataSet
        Dim Kq As New DataSet
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Xml Then
            Kq = Doc_Du_lieu_Xml()
        Else
            Doc_bang("CONG_TY", "", Kq)
            Doc_bang("CHI_NHANH", "", Kq)
            Doc_bang("DON_VI", "", Kq)
            Doc_bang("NGOAI_NGU", "", Kq)
            Doc_bang("LOAI_CONG_VIEC", "", Kq)
            Doc_bang("NHAN_VIEN", "", Kq)
            Doc_bang("KHA_NANG", "", Kq)
            Doc_bang("YEU_CAU", "", Kq)
        End If
        Return Kq
    End Function
End Class
