Imports System.Data.OleDb
Partial Public Class XL_LUU_TRU
#Region "Biến/Đối tượng toàn cục"

#End Region

#Region "Xử lý Đọc/Ghi Dữ liệu Cấu trúc"

    Protected Function Doc_Bang_Access(Ten_bang As String, Optional Dieu_kien As String = "") As DataTable
        Dim Kq As New DataTable(Ten_bang)
        Dim Chuoi_lenh As String = "Select * From " & Ten_bang
        If Dieu_kien <> "" Then
            Chuoi_lenh &= " Where " & Dieu_kien
        End If
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi_Access)
            Bo_thich_ung.FillSchema(Kq, SchemaType.Source)
            Bo_thich_ung.Fill(Kq)
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
    Private Sub Cap_nhat_ID_Access(ByVal Dt As Object, ByVal Bc As OleDbRowUpdatedEventArgs)
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
