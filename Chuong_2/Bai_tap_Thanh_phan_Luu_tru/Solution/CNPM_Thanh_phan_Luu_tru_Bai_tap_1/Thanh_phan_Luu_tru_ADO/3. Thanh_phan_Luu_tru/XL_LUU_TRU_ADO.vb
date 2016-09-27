Imports System.IO
Public Enum LOAI_CSDL
    Xml
    Acesss
    SQLServer_Tap_tin
    SQLServer
End Enum
Public Class XL_LUU_TRU
#Region "Biến/Đối tượng toàn cục"
    Protected Shared Thu_muc_Co_so As String = New FileInfo("..\..\..").FullName    ' Thư mục Solution
    Protected Shared Thu_muc_Du_lieu As String = Thu_muc_Co_so & "\Du_lieu"
    Protected Shared Thu_muc_Media As String = Thu_muc_Du_lieu & "\Media"
    Public ReadOnly Thu_muc_Hinh As String = Thu_muc_Media & "\Hinh"

    Protected Ten_CSDL As String
    Protected Thu_muc_CSDL As String = Thu_muc_Du_lieu & "\CSDL"
    Protected Loai_CSDL_Hien_hanh As LOAI_CSDL

    '===  Xml
    Protected Duong_dan_Tap_tin_Xml As String
    '=== Access
    Protected Duong_dan_Tap_tin_Access As String
    Protected Chuoi_ket_noi_Access As String
    '===SQLServer Tập tin
    Protected Duong_dan_Tap_tin_SQLServer As String
    Protected Chuoi_ket_noi_SQLServer_Tap_tin As String
    '=== SQLserver
    Protected Chuoi_ket_noi_SqlServer As String
#End Region

#Region "Xử lý Khởi động"
    Public Sub New(Optional Loai_CSDL_Hien_hanh As LOAI_CSDL = LOAI_CSDL.SQLServer_Tap_tin,
                   Optional Ten_CSDL As String = "QLNV_1")
        Me.Loai_CSDL_Hien_hanh = Loai_CSDL_Hien_hanh
        Me.Ten_CSDL = Ten_CSDL
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Acesss Then
            Duong_dan_Tap_tin_Access = Thu_muc_CSDL & "\" & Ten_CSDL & ".mdb"
            Chuoi_ket_noi_Access = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Duong_dan_Tap_tin_Access
        ElseIf Loai_CSDL_Hien_hanh = LOAI_CSDL.SQLServer_Tap_tin Then
            Duong_dan_Tap_tin_SQLServer = New FileInfo(Thu_muc_CSDL & "\" & Ten_CSDL & ".mdf").FullName
            Chuoi_ket_noi_SQLServer_Tap_tin = "Data Source=(LocalDB)\v11.0;" & "AttachDbFilename=" & Duong_dan_Tap_tin_SQLServer
        ElseIf Loai_CSDL_Hien_hanh = LOAI_CSDL.SQLServer Then
            Chuoi_ket_noi_SqlServer = "Data Source=???;Persist Security Info=True " & "; Initial Catalog=???" & "; User ID=???; Password= ???"
        ElseIf Loai_CSDL_Hien_hanh = LOAI_CSDL.Xml Then
            Duong_dan_Tap_tin_Xml = Thu_muc_CSDL & "\" & Ten_CSDL & ".xml"
        End If
    End Sub
#End Region

#Region "Xử lý Đọc/Ghi Dữ liệu cấu trúc "
    Public Function Doc_Du_lieu() As DataSet
        Dim Kq As New DataSet
        If Ten_CSDL = "QLNV_1" Then
            Kq = Doc_Du_lieu_QLNV_1()
        ElseIf Ten_CSDL = "QLNV_2" Then
            Kq = Doc_Du_lieu_QLNV_2()
        ElseIf Ten_CSDL = "QLNV_3" Then
            Kq = Doc_Du_lieu_QLNV_3()
        End If
        Return Kq
    End Function
    Public Function Ghi_moi(Dong As DataRow) As String
        Dim Kq As String = ""
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Xml Then
            Kq = Ghi_moi_Xml(Dong)
        Else
            Dim Bang As DataTable = Dong.Table
            Bang.Rows.Add(Dong)
            Kq = Ghi_bang(Bang)
        End If
        Return Kq
    End Function
    Public Function Cap_nhat(Dong As DataRow) As String
        Dim Kq As String = ""
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Xml Then
            Kq = Cap_nhat_Xml(Dong)
        Else
            Dim Bang As DataTable = Dong.Table
            Kq = Ghi_bang(Bang)
        End If

        Return Kq
    End Function
    Public Function Xoa(Dong As DataRow) As String
        Dim Kq As String = ""
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Xml Then
            Kq = Xoa_Xml(Dong)
        Else
            Dim Bang As DataTable = Dong.Table
            Dong.Delete()
            Kq = Ghi_bang(Bang)
        End If
        Return Kq
    End Function
#End Region
#Region "Xử lý Đọc/Ghi  Nội bộ "
    ' Các hàm xử lý Đọc/Ghi cơ sở - trực tiếp với CSDL
    Protected Function Doc_bang(Ten_bang As String, Dieu_kien As String, Du_lieu As DataSet) As DataTable
        Dim Kq As New DataTable
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Acesss Then
            Kq = Doc_Bang_Access(Ten_bang, Dieu_kien)
        ElseIf Loai_CSDL_Hien_hanh = LOAI_CSDL.SQLServer_Tap_tin Then
            Kq = Doc_Bang_SQLServer_Tap_tin(Ten_bang, Dieu_kien)
        ElseIf Loai_CSDL_Hien_hanh = LOAI_CSDL.SQLServer Then
            Kq = Doc_Bang_SQLServer(Ten_bang, Dieu_kien)
        End If
        If Du_lieu IsNot Nothing Then
            Du_lieu.Tables.Add(Kq)
        End If
        Kq.Columns("ID").ReadOnly = False
        For Each Cot As DataColumn In Kq.Columns
            Cot.ColumnMapping = MappingType.Attribute
        Next
        Return Kq
    End Function
    Protected Function Ghi_bang(Bang As DataTable) As String
        Dim Kq As String = ""
        If Loai_CSDL_Hien_hanh = LOAI_CSDL.Acesss Then
            Kq = Ghi_Bang_Access(Bang)
        ElseIf Loai_CSDL_Hien_hanh = LOAI_CSDL.SQLServer_Tap_tin Then
            Kq = Ghi_Bang_SQLServer_Tap_tin(Bang)
        ElseIf Loai_CSDL_Hien_hanh = LOAI_CSDL.SQLServer Then
            Kq = Ghi_Bang_SQLServer(Bang)
        End If
        Return Kq
    End Function
#End Region
End Class


