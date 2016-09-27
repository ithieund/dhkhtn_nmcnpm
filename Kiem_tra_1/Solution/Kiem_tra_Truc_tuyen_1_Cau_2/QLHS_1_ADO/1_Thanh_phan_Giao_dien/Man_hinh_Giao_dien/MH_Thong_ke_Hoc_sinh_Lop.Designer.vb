<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Thong_ke_Hoc_sinh_Lop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Th_Danh_sach_Thong_ke = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.Dock = System.Windows.Forms.DockStyle.Top
        Me.Th_Tieu_de.Location = New System.Drawing.Point(0, 0)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(561, 13)
        Me.Th_Tieu_de.TabIndex = 0
        Me.Th_Tieu_de.Text = "Label1"
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.Dock = System.Windows.Forms.DockStyle.Top
        Me.Th_Thong_bao.Location = New System.Drawing.Point(0, 13)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(561, 13)
        Me.Th_Thong_bao.TabIndex = 2
        Me.Th_Thong_bao.Text = "Label1"
        '
        'Th_Danh_sach_Thong_ke
        '
        Me.Th_Danh_sach_Thong_ke.Dock = System.Windows.Forms.DockStyle.Top
        Me.Th_Danh_sach_Thong_ke.Location = New System.Drawing.Point(0, 26)
        Me.Th_Danh_sach_Thong_ke.Name = "Th_Danh_sach_Thong_ke"
        Me.Th_Danh_sach_Thong_ke.Size = New System.Drawing.Size(561, 198)
        Me.Th_Danh_sach_Thong_ke.TabIndex = 3
        '
        'MH_Thong_ke_Lop_So_luong_Hoc_sinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 339)
        Me.Controls.Add(Me.Th_Danh_sach_Thong_ke)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Name = "MH_Thong_ke_Lop_So_luong_Hoc_sinh"
        Me.Text = "MH_Thong_ke_Lop_So_luong_Hoc_sinh"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Th_Danh_sach_Thong_ke As FlowLayoutPanel
End Class
