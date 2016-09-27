Public Class MH_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi
#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU(LOAI_CSDL.Acesss)
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN

    Dim Du_lieu As DataSet

#End Region

#Region "Xử lý Khởi động"
    Public Sub New(Du_lieu As DataSet)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Du_lieu = Du_lieu
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '===Khởi động thể hiện ===
        Me.WindowState = FormWindowState.Maximized

        Xuat_Thong_ke()

    End Sub

#End Region

#Region "Xử lý Thể hiện ( Nhập/xuất ) "
    Sub Xuat_Thong_ke()

        ' Khoi tao bang thong ke
        Dim Thong_ke As DataTable = Du_lieu.Tables("DON_VI").Select.CopyToDataTable
        Thong_ke.Columns.Add("So_Nhan_vien")

        ' Xu ly du lieu thong ke
        For Each Dong As DataRow In Thong_ke.Rows
            Dim Don_vi As DataRow = Du_lieu.Tables("DON_VI").Select("ID = " & Dong("ID")).First
            Dong("So_Nhan_vien") = Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Don_vi).Count
        Next

        ' Xuat thong tin ra luoi
        TH_Luoi_Du_lieu.DataSource = Thong_ke
        TH_Luoi_Du_lieu.ReadOnly = True
        TH_Luoi_Du_lieu.RowHeadersVisible = False
        TH_Luoi_Du_lieu.AllowUserToAddRows = False
        TH_Luoi_Du_lieu.AllowUserToDeleteRows = False
        TH_Luoi_Du_lieu.EnableHeadersVisualStyles = False
        TH_Luoi_Du_lieu.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        TH_Luoi_Du_lieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        TH_Luoi_Du_lieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TH_Luoi_Du_lieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        TH_Luoi_Du_lieu.ColumnHeadersHeight = 40
        TH_Luoi_Du_lieu.DefaultCellStyle.BackColor = Color.White
        TH_Luoi_Du_lieu.DefaultCellStyle.ForeColor = Color.Red

        TH_Luoi_Du_lieu.Columns("ID").Visible = False
        TH_Luoi_Du_lieu.Columns("Ten").HeaderText = "Tên đơn vị"
        TH_Luoi_Du_lieu.Columns("Ten").Width = 200
        TH_Luoi_Du_lieu.Columns("So_Nhan_vien").HeaderText = "Số nhân viên"
        TH_Luoi_Du_lieu.Columns("So_Nhan_vien").Width = 150

    End Sub
#End Region
End Class