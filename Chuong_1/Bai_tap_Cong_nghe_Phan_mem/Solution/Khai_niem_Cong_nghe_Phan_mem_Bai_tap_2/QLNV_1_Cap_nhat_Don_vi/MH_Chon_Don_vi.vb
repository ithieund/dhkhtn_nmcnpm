Public Class MH_Chon_Don_vi

#Region "Bien/Doi tuong giao tiep"
    Public Don_vi_Chon As DataRow
#End Region

#Region "Bien/Doi tuong toan cuc"
    Dim Luu_tru As New XL_LUU_TRU
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim Du_lieu As DataSet
#End Region

#Region "Xu ly khoi dong"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Khoi_dong()

    End Sub

    Sub Khoi_dong()

        ' Khoi dong du lieu
        Du_lieu = Luu_tru.Doc_Du_Lieu

        ' Khoi dong the hien
        Xuat_Danh_sach_Don_vi()

    End Sub

    Sub Xuat_Danh_sach_Don_vi()

        Dim Danh_sach_Don_vi As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList

        For Each Don_vi As DataRow In Danh_sach_Don_vi
            ' Tao the hien don vi
            Dim Th_Don_vi As New Button

            ' Xuat tom tat
            Dim Chuoi_Tom_tat As String = Don_vi("Ten")
            Th_Don_vi.Text = Chuoi_Tom_tat

            ' Xuat thong tin dang ghi chu
            Dim Chuoi_Thong_tin As String = ""
            Chuoi_Thong_tin &= "Tên: " & Don_vi("Ten") & vbCrLf
            Chuoi_Thong_tin &= "Số nhân viên: " & Nghiep_vu.Danh_sach_Nhan_vien_theo_Don_vi(Don_vi).Count & vbCrLf

            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Don_vi, Chuoi_Thong_tin)

            ' Dinh dang the hien
            Th_Don_vi.Size = New Size(120, 40)
            Th_Don_vi.Font = New Font("Arial", 12)
            Th_Don_vi.ForeColor = Color.Blue
            Th_Don_vi.BackColor = Color.White

            ' Bo sung the hien don vi vao danh sach don vi
            Th_Danh_sach_Don_vi.Controls.Add(Th_Don_vi)

            ' Chuan bi bien co chon
            Th_Don_vi.Tag = Don_vi
            AddHandler Th_Don_vi.Click, AddressOf XL_Chon_Don_vi_Click
        Next

    End Sub
#End Region

#Region "Xu ly bien co"
    Sub XL_Chon_Don_vi_Click(Th_Don_vi As Control, Bc As EventArgs)

        Don_vi_Chon = Th_Don_vi.Tag
        Me.Close()

    End Sub
#End Region
End Class