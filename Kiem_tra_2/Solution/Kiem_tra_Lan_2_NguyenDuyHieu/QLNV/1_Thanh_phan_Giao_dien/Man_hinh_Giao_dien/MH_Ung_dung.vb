Public Class MH_Ung_dung

#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN

#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
        Ung_dung = New XL_UNG_DUNG(Du_lieu)
        The_hien = New XL_THE_HIEN(Ung_dung)
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '1 ==== Khởi động dữ liệu

        '2 ===== Khởi động thể hiện
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        Me.FormBorderStyle = FormBorderStyle.None
        '===Tiêu đề 
        Dim Tieu_de As String = "Quản lý nhân viên"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh
        The_hien.Xuat_Thuc_don_tinh_cua_Ung_dung(Thuc_don, AddressOf XL_Chon_Chuc_nang)
        '===Thực đơn động 
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Me, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo 
        Th_Thong_bao.Padding = New Padding(10)
        Dim Thong_bao As String = "Hướng dẫn" & vbCrLf
        Thong_bao &= "-	Để sử dụng chức năng, bấm chọn chức năng trong thực đơn động hoặc thực đơn tĩnh." & vbCrLf
        Thong_bao &= "-	Để thoát ứng dụng, bấm chọn chức năng Kết thúc." & vbCrLf
        Th_Thong_bao.Text = Thong_bao
    End Sub
#End Region

#Region "Xử lý Biến cố Chính - Chọn chức năng "
    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Chuc_nang As XL_CHUC_NANG = Th_Chuc_nang.Tag
        Dim Ma_so_Chon As String = Chuc_nang.Ma_so
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
        Else
            The_hien.XL_Kich_hoat_Chuc_nang(Th_Chuc_nang, Bc)
        End If

    End Sub

#End Region




End Class