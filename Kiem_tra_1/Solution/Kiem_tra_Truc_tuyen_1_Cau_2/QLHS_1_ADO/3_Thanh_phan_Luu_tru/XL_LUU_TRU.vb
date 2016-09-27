Imports System.IO
Imports System.Data.OleDb


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

    Protected Thu_muc_Du_lieu As String = New DirectoryInfo("..\..\....\Du_lieu").FullName
    Protected Thu_muc_CSDL As String = Thu_muc_Du_lieu & "\CSDL"

    Protected Thu_muc_Media As String = Thu_muc_Du_lieu & "\Media"
    Protected Thu_muc_Hinh As String = Thu_muc_Media & "\Hinh"
    Protected Thu_muc_Tai_lieu As String = Thu_muc_Media & "\Tai_lieu"
    Protected Thu_muc_Am_Thanh As String = Thu_muc_Media & "\Am_thanh"
    Protected Thu_muc_Phim As String = Thu_muc_Media & "\Phim"

    Protected Ten_Ung_dung As String = "QLHS_1"
    Protected Ten_CSDL As String
    Protected Duong_dan_Tap_tin_Access As String
    Protected Chuoi_ket_noi_Access As String
#End Region

#Region "Xử lý Khởi động"
    Public Sub New(Optional Qui_mo As String = "Nho")
        Ten_CSDL = Ten_Ung_dung & "_" & Qui_mo
        Duong_dan_Tap_tin_Access = Thu_muc_CSDL & "\" & Ten_CSDL & ".mdb"
        Chuoi_ket_noi_Access = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Duong_dan_Tap_tin_Access

    End Sub

#End Region

#Region "Đọc-Ghi Dữ liệu Cấu trúc"
#Region "Public"
    '===== Khi thay đổi CSDL chỉ cần thay đổi hàm xử lý này
    Public Function Doc_Du_lieu() As DataSet
        Dim Kq As New DataSet
        Doc_Bang("Truong", "", Kq)
        Doc_Bang("Lop", "", Kq)
        Doc_Bang("Hoc_sinh", "", Kq)
        Doc_Bang("Khoi", "", Kq)
        Doc_Bang("GIOI_TINH", "", Kq)
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
#End Region

#Region "Nội bộ"
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
        Kq.Columns("ID").ReadOnly = False
        Return Kq
    End Function
    Protected Function Ghi_bang(Bang As DataTable) As String
        Dim Kq As String = Ghi_Bang_Access(Bang)
        Return Kq
    End Function
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
        Catch Loi As Exception
            MsgBox("Lỗi đọc CSDL" & vbCrLf & Loi.Message & ":" & Chuoi_lenh & ":" & Chuoi_ket_noi_Access)
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
            MsgBox(ex.Message)
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


#End Region

#Region "Đọc - Ghi Dữ liệu Phi Cấu trúc - Media "
#Region "Public"
    '===== Hiện nay chưa sử dụng hàm xử lý này 
    '===== Hàm xử lý này sẽ dùng rất tốt với giao diện Web
    Public Function Duong_dan_Media(Dong As DataRow, Loai As LOAI_MEDIA) As String
        Dim Kq As String = ""
        If Loai = LOAI_MEDIA.Hinh Then
            Kq = Duong_dan_Hinh(Dong)
        ElseIf Loai = LOAI_MEDIA.Tai_lieu Then
            Kq = Duong_dan_Tai_lieu(Dong)
        ElseIf Loai = LOAI_MEDIA.Am_thanh Then
            Kq = Duong_dan_Am_Thanh(Dong)
        ElseIf Loai = LOAI_MEDIA.Phim Then
            Kq = Duong_dan_Phim(Dong)
        End If
        Return Kq
    End Function
    Public Function Doc_Media(Dong As DataRow, Loai As LOAI_MEDIA) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Media(Dong, Loai)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
    Public Function Ghi_Media(Dong As DataRow, Loai As LOAI_MEDIA, Du_lieu_Media As Byte()) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Duong_dan_Media(Dong, Loai)
        File.WriteAllBytes(Duong_dan, Du_lieu_Media)
        Return Kq
    End Function

    Public Function Duong_dan_Media(Ma_so As String, Loai As LOAI_MEDIA) As String
        Dim Kq As String = ""
        If Loai = LOAI_MEDIA.Hinh Then
            Kq = Duong_dan_Hinh(Ma_so)
        ElseIf Loai = LOAI_MEDIA.Tai_lieu Then
            Kq = Duong_dan_Tai_lieu(Ma_so)
        ElseIf Loai = LOAI_MEDIA.Am_thanh Then
            Kq = Duong_dan_Am_Thanh(Ma_so)
        ElseIf Loai = LOAI_MEDIA.Phim Then
            Kq = Duong_dan_Phim(Ma_so)
        End If
        Return Kq
    End Function
    Public Function Doc_Media(Ma_so As String, Loai As LOAI_MEDIA) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Media(Ma_so, Loai)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
#End Region

#Region "Nội bộ- Hình"

    Protected Function Duong_dan_Hinh(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Loai_doi_tuong As String = Dong.Table.TableName
        Dim ID As Integer = Dong("ID")
        Dim Duong_dan As String = Thu_muc_Hinh & "\" & Loai_doi_tuong & "_" & ID & ".png"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Hinh & "\" & Loai_doi_tuong & ".png"
            If Not File.Exists(Duong_dan) Then
                Duong_dan = Thu_muc_Hinh & "\Hinh.png"
            End If
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Hinh(Dong As DataRow) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Hinh(Dong)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
    Protected Function Ghi_Du_lieu_Hinh(Dong As DataRow, Du_lieu_Hinh As Byte()) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Duong_dan_Hinh(Dong)
        File.WriteAllBytes(Duong_dan, Du_lieu_Hinh)
        Return Kq
    End Function

    Protected Function Duong_dan_Hinh(Ma_so As String) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Thu_muc_Hinh & "\" & Ma_so & ".png"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Hinh & "\Hinh.png"
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Hinh(Ma_so As String) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Hinh(Ma_so)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
#End Region

#Region "Nội bộ - Tài liệu"
    Protected Function Duong_dan_Tai_lieu(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Loai_doi_tuong As String = Dong.Table.TableName
        Dim ID As Integer = Dong("ID")
        Dim Duong_dan As String = Thu_muc_Tai_lieu & "\" & Loai_doi_tuong & "_" & ID & ".pdf"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Tai_lieu & "\" & Loai_doi_tuong & ".pdf"
            If Not File.Exists(Duong_dan) Then
                Duong_dan = Thu_muc_Tai_lieu & "\Tai_lieu.pdf"
            End If
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Tai_lieu(Dong As DataRow) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Tai_lieu(Dong)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
    Protected Function Ghi_Du_lieu_Tai_lieu(Dong As DataRow, Du_lieu_Tai_lieu As Byte()) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Duong_dan_Tai_lieu(Dong)
        File.WriteAllBytes(Duong_dan, Du_lieu_Tai_lieu)
        Return Kq
    End Function
    '=======
    Protected Function Duong_dan_Tai_lieu(Ma_so As String) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Thu_muc_Tai_lieu & "\" & Ma_so & ".pdf"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Tai_lieu & "\Tai_lieu.pdf"
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Tai_lieu(Ma_so As String) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Tai_lieu(Ma_so)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
#End Region

#Region "Nội bộ - Âm thanh "
    Protected Function Duong_dan_Am_Thanh(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Loai_doi_tuong As String = Dong.Table.TableName
        Dim ID As Integer = Dong("ID")
        Dim Duong_dan As String = Thu_muc_Am_Thanh & "\" & Loai_doi_tuong & "_" & ID & ".mp3"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Am_Thanh & "\" & Loai_doi_tuong & ".mp3"
            If Not File.Exists(Duong_dan) Then
                Duong_dan = Thu_muc_Am_Thanh & "\Am_Thanh.mp3"
            End If
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Am_Thanh(Dong As DataRow) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Am_Thanh(Dong)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
    Protected Function Ghi_Du_lieu_Am_Thanh(Dong As DataRow, Du_lieu_Am_Thanh As Byte()) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Duong_dan_Am_Thanh(Dong)
        File.WriteAllBytes(Duong_dan, Du_lieu_Am_Thanh)
        Return Kq
    End Function
    ' =====
    Protected Function Duong_dan_Am_Thanh(Ma_so As String) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Thu_muc_Am_Thanh & "\" & Ma_so & ".mp3"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Am_Thanh & "\Am_Thanh.mp3"
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Am_Thanh(Ma_so As String) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Am_Thanh(Ma_so)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
#End Region

#Region "Nội bộ - Phim  "
    Protected Function Duong_dan_Phim(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Loai_doi_tuong As String = Dong.Table.TableName
        Dim ID As Integer = Dong("ID")
        Dim Duong_dan As String = Thu_muc_Phim & "\" & Loai_doi_tuong & "_" & ID & ".mp4"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Phim & "\" & Loai_doi_tuong & ".mp4"
            If Not File.Exists(Duong_dan) Then
                Duong_dan = Thu_muc_Phim & "\Phim.mp4"
            End If
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Phim(Dong As DataRow) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Phim(Dong)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
    Protected Function Ghi_Du_lieu_Phim(Dong As DataRow, Du_lieu_Phim As Byte()) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Duong_dan_Phim(Dong)
        File.WriteAllBytes(Duong_dan, Du_lieu_Phim)
        Return Kq
    End Function
    ' =====
    Protected Function Duong_dan_Phim(Ma_so As String) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Thu_muc_Phim & "\" & Ma_so & ".mp4"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Phim & "\Phim.mp4"
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Protected Function Doc_Du_lieu_Phim(Ma_so As String) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Phim(Ma_so)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
#End Region
#End Region

End Class


