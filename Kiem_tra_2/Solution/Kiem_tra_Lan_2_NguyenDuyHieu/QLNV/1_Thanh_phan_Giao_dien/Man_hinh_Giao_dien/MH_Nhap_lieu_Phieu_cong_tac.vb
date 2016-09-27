Public Class MH_Nhap_lieu_Phieu_cong_tac

#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN


    Protected Phieu_cong_tac As XL_PHIEU_CONG_TAC
    Protected Ma_so_Nhap_lieu As String
#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New(Ung_dung As XL_UNG_DUNG, Ma_so_Nhap_lieu As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)

        Me.Ma_so_Nhap_lieu = Ma_so_Nhap_lieu
        Khoi_dong()
    End Sub

    Sub Khoi_dong()
        If Ma_so_Nhap_lieu = "GHI_MOI" Then
            Th_Chon_phieu_cong_tac.Visible = False
            Khoi_dong_Ghi_moi()
        ElseIf Ma_so_Nhap_lieu = "CAP_NHAT" Then
            Khoi_dong_Cap_nhat()
        ElseIf Ma_so_Nhap_lieu = "XOA" Then
            Khoi_dong_Xoa()
        End If
        Khoi_dong_chung()
    End Sub
    Sub Khoi_dong_chung()
        '1.==== Khởi động dữ liệu 

        '2==== Khởi động thể hiện 
        '===== Màn hình ======
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        Me.Font = New Font("Arial", 11)
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        '===Tiêu đề : Hiện nay  có nội dung riêng

        Th_Tieu_de.Font = New Font("Arial", 18)
        Th_Tieu_de.ForeColor = Color.Snow
        Th_Tieu_de.TextAlign = ContentAlignment.MiddleLeft

        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động : Chung  
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Th_Tieu_de)
        Dim Danh_sach_Chuc_nang As New List(Of XL_CHUC_NANG)
        Danh_sach_Chuc_nang.Add(New XL_CHUC_NANG(Ung_dung, "Chọn nhân viên", "CHON_NHAN_VIEN"))
        Danh_sach_Chuc_nang.Add(Ung_dung.Chuc_nang_Ket_thuc)
        The_hien.Tao_Thuc_don_dong(Danh_sach_Chuc_nang,
                                   Th_Ho_so, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo :   Hiện nay là riêng
        '=== Hồ sơ nhập liệu :  
        Th_Ho_so.BorderStyle = BorderStyle.FixedSingle
        The_hien.Khoi_dong_Ho_so_Phieu_cong_tac(Phieu_cong_tac, Th_Ho_so)
    End Sub

#End Region

#Region "Ghi mới"
    Sub Khoi_dong_Ghi_moi()
        '1.==== Khởi động dữ liệu 
        Phieu_cong_tac = Ung_dung.Tao_Phieu_cong_tac_moi()

        '2.===Khởi động thể hiện ===
        '==== Màn hình ====    ***** Khởi động chung *****
        '===Tiêu đề 
        Dim Tieu_de As String = "Lập phiếu công tác"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   

        '=== Thông báo :   
        Dim Thong_bao As String = Phieu_cong_tac.Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi
        Th_Thong_bao.Text = Thong_bao

        '=== Yêu cầu xử lý : Đồng ý 
        AddHandler Th_Dong_y.Click, AddressOf XL_Dong_y_Ghi_moi
    End Sub

    Sub XL_Dong_y_Ghi_moi(Th_Dong_y As Control, Bc As EventArgs)
        Dim Chuoi_loi As String = The_hien.Nhap_Ho_so_Phieu_cong_tac(Phieu_cong_tac, Th_Ho_so)
        If Chuoi_loi = "" Then
            Thuc_hien_Ghi_moi()
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu " & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
    Sub Thuc_hien_Ghi_moi()
        Dim Chuoi_loi As String = Phieu_cong_tac.Kiem_tra_Ghi_moi
        If Chuoi_loi = "" Then
            Chuoi_loi = Luu_tru.Ghi(Phieu_cong_tac.Dong, LOAI_GHI.Ghi_moi)
        End If
        If Chuoi_loi = "" Then
            Dim Thong_bao As String = "Đã ghi hồ sơ phiếu công tác" & vbCrLf
            Thong_bao &= Phieu_cong_tac.Tao_Chuoi_Thong_tin
            Thong_bao &= "======" & vbCrLf
            Thong_bao &= "Có thể tiếp tục nhập liệu phiếu công tác mới"
            Th_Thong_bao.Text = Thong_bao

            ' Thay đổi trạng thái màn hình với phiếu công tác mới 
            Phieu_cong_tac = Ung_dung.Tao_Phieu_cong_tac_moi()
            The_hien.Xuat_Ho_so_Phieu_cong_tac(Phieu_cong_tac, Th_Ho_so)
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
#End Region


#Region "Cập nhật  "
    Sub Khoi_dong_Cap_nhat()
        '1.==== Khởi động dữ liệu 
        If Ung_dung.Danh_sach_Phieu_cong_tac.Count > 0 Then
            Phieu_cong_tac = Ung_dung.Danh_sach_Phieu_cong_tac(0)
        End If
        '2.===Khởi động thể hiện ===
        '==== Màn hình === **** Khởi động chung *****

        '===Tiêu đề 
        Dim Tieu_de As String = "Cập nhật phiếu công tác "
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   

        '=== Thông báo :   
        Dim Thong_bao As String = Phieu_cong_tac.Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat
        Th_Thong_bao.Text = Thong_bao

        '=== Yêu cầu thực hiện : Đồng ý 
        Th_Dong_y.Visible = Phieu_cong_tac IsNot Nothing
        AddHandler Th_Dong_y.Click, AddressOf XL_Dong_y_Cap_nhat

        '=== Yêu cầu xử lý : Chọn phiếu
        AddHandler Th_Chon_phieu_cong_tac.Click, AddressOf XL_Chon_phieu_cong_tac
    End Sub
    Sub XL_Dong_y_Cap_nhat(Th_Dong_y As Control, Bc As EventArgs)
        Dim Chuoi_loi As String = The_hien.Nhap_Ho_so_Phieu_cong_tac(Phieu_cong_tac, Th_Ho_so)
        If Chuoi_loi = "" Then
            Thuc_hien_Cap_nhat()
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
    Sub Thuc_hien_Cap_nhat()
        Dim Chuoi_loi As String = Phieu_cong_tac.Kiem_tra_Cap_nhat
        If Chuoi_loi = "" Then
            Chuoi_loi = Luu_tru.Ghi(Phieu_cong_tac.Dong, LOAI_GHI.Cap_nhat)
        End If
        '===== Xử lý Thông báo & Trạng thái  =====
        If Chuoi_loi = "" Then
            Dim Thong_bao As String = "Đã cập nhật hồ sơ phiếu công tác" & vbCrLf
            Thong_bao &= Phieu_cong_tac.Tao_Chuoi_Thong_tin
            Thong_bao &= "======" & vbCrLf
            Th_Thong_bao.Text = Thong_bao
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
#End Region


#Region "Xóa   "
    Sub Khoi_dong_Xoa() ' Trạng thái đầu 
        '1.==== Khởi động dữ liệu 
        If Ung_dung.Danh_sach_Phieu_cong_tac.Count > 0 Then
            Phieu_cong_tac = Ung_dung.Danh_sach_Phieu_cong_tac(0)
        End If

        '2.===Khởi động thể hiện ===
        '==== Màn hình === ***** Khởi động chung *****

        '===Tiêu đề 
        Dim Tieu_de As String = "Hủy phiếu công tác "
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   

        '=== Thông báo :   
        Dim Thong_bao As String = Phieu_cong_tac.Tao_Chuoi_Thong_bao_Luu_y_Xoa
        Th_Thong_bao.Text = Thong_bao

        '=== Đồng ý 
        Th_Dong_y.Visible = Phieu_cong_tac IsNot Nothing
        AddHandler Th_Dong_y.Click, AddressOf XL_Dong_y_Xoa

        '=== Yêu cầu xử lý : Chọn phiếu
        AddHandler Th_Chon_phieu_cong_tac.Click, AddressOf XL_Chon_phieu_cong_tac
    End Sub

    Sub XL_Dong_y_Xoa(Th_Dong_y As Control, Bc As EventArgs)
        If MsgBox("Bạn có thực sự muốn xóa hồ sơ này?", MsgBoxStyle.YesNo, "Xác nhận") = MsgBoxResult.Yes Then
            Thuc_hien_Xoa()
        End If
    End Sub
    Sub Thuc_hien_Xoa()
        Dim Chuoi_loi As String = Phieu_cong_tac.Kiem_tra_Xoa
        If Chuoi_loi = "" Then
            Chuoi_loi = Luu_tru.Ghi(Phieu_cong_tac.Dong, LOAI_GHI.Xoa)

        End If
        '===== Xử lý Thông báo & Trạng thái  =====
        If Chuoi_loi = "" Then
            Dim Thong_bao As String = "Đã xóa hồ sơ phiếu công tác" & vbCrLf
            Thong_bao &= "======" & vbCrLf
            Th_Thong_bao.Text = Thong_bao
        Else
            Dim Thong_bao As String = "Lỗi khi xóa" & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
#End Region


#Region "Xử lý Biến cố Phụ - Chọn chức năng"

    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Chuc_nang As XL_CHUC_NANG = Th_Chuc_nang.Tag
        Dim Ma_so_Chon As String = Chuc_nang.Ma_so
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
        ElseIf Ma_so_Chon = "CHON_NHAN_VIEN" Then
            Dim Mh = New MH_Tra_cuu_Nhan_vien(Ung_dung, "DON_VI", True)
            Mh.ShowDialog()

            Dim Nhan_vien_Chon As XL_NHAN_VIEN = Mh.Nhan_vien_Chon()
            If Nhan_vien_Chon IsNot Nothing Then
                Th_Nhan_vien.Text = Nhan_vien_Chon.Ho_ten
                Th_Nhan_vien.Tag = Nhan_vien_Chon.ID
            End If
        End If
    End Sub

    Sub XL_Chon_phieu_cong_tac(Th_Chon_phieu_cong_tac As Button, Bc As EventArgs)
        Dim Mh As New MH_Tra_cuu_Phieu_cong_tac(Ung_dung, "THEO_THANG_CONG_TAC", True)
        Mh.ShowDialog()

        Dim Phieu_cong_tac_Chon As XL_PHIEU_CONG_TAC = Mh.Phieu_cong_tac_Chon()
        If Phieu_cong_tac_Chon IsNot Nothing Then
            Phieu_cong_tac = Phieu_cong_tac_Chon
            The_hien.Xuat_Ho_so_Phieu_cong_tac(Phieu_cong_tac, Th_Ho_so)
        End If
    End Sub

#End Region

End Class