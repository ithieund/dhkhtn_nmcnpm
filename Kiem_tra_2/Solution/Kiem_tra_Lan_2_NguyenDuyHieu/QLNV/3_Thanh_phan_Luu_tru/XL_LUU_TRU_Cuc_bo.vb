Imports System.IO
Imports System.Data.OleDb
' Thông báo PET : Với mục tiêu giảng dạy. Class này được thiết kế và Lập trình theo hướng 
'  1. Đặc thù cho ứng dụng QLNV_1 và Tổng quát cho các loại  qui mô khác nhau  ( sẽ có các CSDL khác nhau )
'  2. Đặc thù cho loại CSDL Access 2000-2003  và có thể dễ dàng thay đổi sang các loại CSDL khác 
'  3. Đặc thù cho loại Media Hình  và  có thể dễ dàng mở rộng bổ sung các loại Media khác 
Public Enum LOAI_CSDL
    Access_2000_2003
    Access_2013
    SQLServer_Tap_tin
    SQLServer
    MySql
    Sqlite
End Enum
Public Enum LOAI_MEDIA
    Hinh
    Tai_lieu
    Am_thanh
    Phim
End Enum
Public Enum LOAI_GHI
    Ghi_moi
    Cap_nhat
    Xoa
End Enum
Public Class XL_LUU_TRU

#Region "Biến/Đối tượng toàn cục"

    Protected Thu_muc_Debug As New DirectoryInfo(Application.StartupPath)
    Protected Thu_muc_Bin As DirectoryInfo = Thu_muc_Debug.Parent
    Protected Thu_muc_Project As DirectoryInfo = Thu_muc_Bin.Parent
    Protected Thu_muc_Solution As DirectoryInfo = Thu_muc_Project.Parent

    Protected Thu_muc_Du_lieu As String = Thu_muc_Solution.FullName & "\Du_lieu"
    Protected Thu_muc_CSDL As String = Thu_muc_Du_lieu & "\CSDL"

    Protected Thu_muc_Media As String = Thu_muc_Du_lieu & "\Media"
    Protected Thu_muc_Hinh As String = Thu_muc_Media & "\Hinh"
    Protected Thu_muc_Tai_lieu As String = Thu_muc_Media & "\Tai_lieu"
    Protected Thu_muc_Am_Thanh As String = Thu_muc_Media & "\Am_thanh"
    Protected Thu_muc_Phim As String = Thu_muc_Media & "\Phim"

    Protected Ten_Ung_dung As String = "QLNV"
    Protected Ten_CSDL As String
    Protected Duong_dan_Tap_tin_Access As String
    Protected Chuoi_ket_noi_Access As String
#End Region

#Region "Xử lý Khởi động"
    Public Sub New(Optional Loai As LOAI_CSDL = LOAI_CSDL.Access_2000_2003)
        Ten_CSDL = Ten_Ung_dung
        If Loai = LOAI_CSDL.Access_2000_2003 Then
            Duong_dan_Tap_tin_Access = Thu_muc_CSDL & "\" & Ten_CSDL & ".mdb"
            Chuoi_ket_noi_Access = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Duong_dan_Tap_tin_Access
            ''  Thông báo PET : hay có thể sử dụng
            ''  Chuoi_ket_noi_Access = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Duong_dan_Tap_tin_Access
            ''   === > Thực hiện tốt hơn !!!
            ''  Các anh chị có thể download Driver thư viện tại địa chỉ
            '' https://www.microsoft.com/en-us/download/details.aspx?id=13255

        End If

    End Sub
#End Region

#Region "Đọc-Ghi CSDL"

    '===== Khi thay đổi CSDL chỉ cần thay đổi hàm xử lý này
    Public Function Doc_Du_lieu() As DataSet
        Dim Kq As New DataSet
        Kq.DataSetName = Ten_CSDL
        Doc_Bang("CONG_TY", "", Kq)
        Doc_Bang("DON_VI", "", Kq)
        Doc_Bang("NHAN_VIEN", "", Kq)
        Doc_Bang("CHI_NHANH", "", Kq)
        Doc_Bang("PHIEU_CONG_TAC", "", Kq)
        Kq.DataSetName = Ten_CSDL
        Return Kq
    End Function
    Public Function Ghi(Dong As DataRow, Loai As LOAI_GHI) As String
        Dim Kq As String = ""
        If Loai = LOAI_GHI.Ghi_moi Then
            Kq = Ghi_moi(Dong)
        ElseIf Loai = LOAI_GHI.Cap_nhat Then
            Kq = Cap_nhat(Dong)
        ElseIf Loai = LOAI_GHI.Xoa Then
            Kq = Xoa(Dong)
        End If
        Return Kq
    End Function


    '==== Xử lý nội bộ
    Protected Function Ghi_moi(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Bang.Rows.Add(Dong)
        Kq = Ghi_bang(Bang)

        Return Kq
    End Function
    Protected Function Cap_nhat(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Kq = Ghi_bang(Bang)

        Return Kq
    End Function
    Protected Function Xoa(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Dong.Delete()
        Kq = Ghi_bang(Bang)
        Return Kq
    End Function
    Protected Function Doc_Bang(Ten_bang As String, Optional Dieu_kien As String = "",
                                     Optional Du_lieu As DataSet = Nothing) As DataTable
        Dim Kq As DataTable = Doc_Bang_Access(Ten_bang, Dieu_kien, Du_lieu)

        Return Kq
    End Function
    Protected Function Ghi_bang(Bang As DataTable) As String
        Dim Kq As String = Ghi_Bang_Access(Bang)
        Return Kq
    End Function




#End Region

#Region "Đọc ghi - Media "

    Public Function Doc_Media(Ma_so As String, Optional Loai As LOAI_MEDIA = LOAI_MEDIA.Hinh) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Media(Ma_so, Loai)
        Try
            Kq = File.ReadAllBytes(Duong_dan)
        Catch ex As Exception
            Kq = New Byte() {}
        End Try

        Return Kq
    End Function

    Public Function Ghi_Media(Ma_so_Media As String, Du_lieu_Media As Byte(),
                              Optional Loai_Media As LOAI_MEDIA = LOAI_MEDIA.Hinh) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Duong_dan_Media(Ma_so_Media, Loai_Media)
        Try
            File.WriteAllBytes(Duong_dan, Du_lieu_Media)
        Catch ex As Exception
            Kq = ex.Message
        End Try
        Return Kq
    End Function
    Protected Function Duong_dan_Media(Ma_so As String,
                                    Optional Loai_Media As LOAI_MEDIA = LOAI_MEDIA.Hinh) As String
        Dim Kq As String = ""
        If Loai_Media = Loai_Media.Hinh Then
            Dim Duong_dan As String = Thu_muc_Hinh & "\" & Ma_so & ".png"
            If Not File.Exists(Duong_dan) Then
                ' Tự động tạo hình định sản ( Bắt buộc phải có tập tin Hinh.png trong thư mục Hinh )
                Dim Duong_dan_Hinh As String = Thu_muc_Hinh & "\Hinh.png"
                File.Copy(Duong_dan_Hinh, Duong_dan, True)
            End If
            Kq = Duong_dan
        End If
        Return Kq
    End Function
#End Region
#Region "CSDL Access"
    Protected Function Doc_Bang_Access(Ten_bang As String, Optional Dieu_kien As String = "",
                                  Optional Du_lieu As DataSet = Nothing) As DataTable
        Dim Kq As New DataTable(Ten_bang)
        Dim Chuoi_lenh As String = "Select * From " & Ten_bang
        If Dieu_kien <> "" Then
            Chuoi_lenh &= " Where " & Dieu_kien
        End If
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi_Access)
            Bo_thich_ung.FillSchema(Kq, SchemaType.Source)
            Bo_thich_ung.Fill(Kq)
            If Du_lieu IsNot Nothing Then
                Du_lieu.Tables.Add(Kq)
            End If
            Kq.Columns(0).ReadOnly = False
            For Each Cot As DataColumn In Kq.Columns
                Cot.ColumnMapping = MappingType.Attribute
            Next
        Catch Loi As Exception
            Du_lieu.ExtendedProperties("Chuoi_loi") = "Lỗi đọc CSDL" & vbCrLf & Loi.Message & ":" & Chuoi_lenh & ":" & Chuoi_ket_noi_Access
        End Try
        Return Kq
    End Function


    Protected Function Ghi_Bang_Access(Bang As DataTable) As String
        Dim Kq As String = ""
        Dim Ten_bang As String = Bang.TableName
        Dim Chuoi_lenh As String = "Select  * From " & Ten_bang
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi_Access)
            Dim Phat_sinh_lenh As New OleDbCommandBuilder(Bo_thich_ung)
            AddHandler Bo_thich_ung.RowUpdated, AddressOf Cap_nhat_ID_Access
            Bo_thich_ung.Update(Bang)
        Catch ex As Exception
            Kq = ex.Message

        End Try
        Return Kq
    End Function
    Protected Sub Cap_nhat_ID_Access(ByVal Dt As Object, ByVal Bc As OleDbRowUpdatedEventArgs)
        ' Ket_noi = Kết nối đang sử dụng 
        Dim Ket_noi As OleDbConnection = Bc.Command.Connection
        ' Kiểm tra là lệnh thêm mới 
        If Bc.StatementType = StatementType.Insert Then
            ' Lenh = Lệnh đọc mã số phát sinh tự động 
            Dim Lenh As New OleDbCommand("Select @@IDENTITY", Ket_noi)
            ' ID = Kết quả thực hiện Lenh 
            Dim ID As Integer = Lenh.ExecuteScalar()
            ' Gán ID vào cột đầu tiên của dòng vừa thêm vào 
            Bc.Row(0) = ID
        End If

    End Sub
#End Region
End Class


