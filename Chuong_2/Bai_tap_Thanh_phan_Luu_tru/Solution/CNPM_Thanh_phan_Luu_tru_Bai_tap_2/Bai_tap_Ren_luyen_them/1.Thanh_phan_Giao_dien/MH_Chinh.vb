Public Class MH_Chinh
#Region "Biến/Đối tượng toàn cục"
    Dim Luu_tru As New XL_LUU_TRU(LOAI_CSDL.Acesss)
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN
    Dim Du_lieu As DataSet
#End Region

#Region "Xử lý Khởi động"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        '==== Khởi động dữ liệu : 
        Du_lieu = Luu_tru.Doc_Du_lieu


        '=== Khởi động thể hiện 
        Me.WindowState = FormWindowState.Maximized
        AddHandler Th_Tra_cuu_Nhan_vien_Theo_Don_vi.Click, AddressOf XL_Chon_Tra_cuu_Nhan_vien_Theo_Don_vi
        AddHandler TH_Tra_cuu_Nhan_vien_Theo_Muc_luong.Click, AddressOf XL_Chon_Tra_cuu_Nhan_vien_Theo_Muc_luong
        AddHandler TH_Tra_cuu_Nhan_vien_Theo_Do_tuoi.Click, AddressOf XL_Chon_Tra_cuu_Nhan_vien_Theo_Do_tuoi
        AddHandler Th_Them_moi.Click, AddressOf XL_Chon_Them_moi
        AddHandler TH_Cap_nhat.Click, AddressOf XL_Chon_Cap_nhat
        AddHandler TH_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi.Click, AddressOf XL_Chon_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi
    End Sub
#End Region

#Region "Xử lý Biến cố"
    Sub XL_Chon_Tra_cuu_Nhan_vien_Theo_Don_vi(Th_Tra_cuu As Control, Bc As EventArgs)
        Dim Mh As New MH_Tra_cuu_Nhan_vien_theo_Don_vi(Du_lieu)
        Mh.ShowDialog()
    End Sub

    Sub XL_Chon_Tra_cuu_Nhan_vien_Theo_Muc_luong(Th_Tra_cuu As Control, Bc As EventArgs)
        Dim Mh As New MH_Tra_cuu_Nhan_vien_Theo_Muc_luong(Du_lieu)
        Mh.ShowDialog()
    End Sub

    Sub XL_Chon_Tra_cuu_Nhan_vien_Theo_Do_tuoi(Th_Tra_cuu As Control, Bc As EventArgs)
        Dim Mh As New MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi(Du_lieu)
        Mh.ShowDialog()
    End Sub

    Sub XL_Chon_Them_moi(Th_Them_moi As Control, Bc As EventArgs)
        Dim Mh As New MH_Them_moi_Nhan_vien(Du_lieu)
        Mh.ShowDialog()
    End Sub

    Sub XL_Chon_Cap_nhat(Th_Them_moi As Control, Bc As EventArgs)
        Dim Mh As New MH_Cap_nhat_Nhan_vien(Du_lieu)
        Mh.ShowDialog()
    End Sub

    Sub XL_Chon_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi(Th_Them_moi As Control, Bc As EventArgs)
        Dim Mh As New MH_Thong_ke_So_luong_Nhan_vien_Theo_Don_vi(Du_lieu)
        Mh.ShowDialog()
    End Sub
#End Region

End Class
'Bài tập  : 
'Tối thiểu/Bắt buộc  :  Bổ sung các chức năng   
'    - Tra cứu nhân viên theo mức lương     
'    - Cập nhật nhân viên 
'Rèn luyện thêm: Bổ sung các chức năng     
'    - Tra cứu nhân viên theo độ tuổi    
'    - Thống kê số lượng nhân viên theo đơn vị 
'Nâng cao/Tùy chọn : Quản lý nhân viên 2   
'    Tra cứu nhân viên theo 1 ngoại ngữ 