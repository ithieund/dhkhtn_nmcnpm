Imports System.IO
Partial Public Class XL_LUU_TRU

#Region "Biến/Đối tượng toàn cục"

#End Region

#Region "Xử lý Đọc/Ghi Dữ liệu Phi cấu trúc - Hình"
    Public Function Duong_dan_Hinh(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Loai_doi_tuong As String = Dong.Table.TableName
        Dim ID As Integer = Dong("ID")
        Dim Duong_dan As String = Thu_muc_Hinh & "\" & Loai_doi_tuong & "_" & ID & ".png"
        If Not File.Exists(Duong_dan) Then
            Duong_dan = Thu_muc_Hinh & "\" & Loai_doi_tuong & ".png"
        End If
        Kq = New FileInfo(Duong_dan).FullName
        Return Kq
    End Function
    Public Function Doc_Du_lieu_Hinh(Dong As DataRow) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Duong_dan_Hinh(Dong)
        Kq = File.ReadAllBytes(Duong_dan)
        Return Kq
    End Function
    Public Function Ghi_Du_lieu_Hinh(Dong As DataRow, Du_lieu_Hinh As Byte()) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Duong_dan_Hinh(Dong)
        File.WriteAllBytes(Duong_dan, Du_lieu_Hinh)
        Return Kq
    End Function
#End Region
End Class
