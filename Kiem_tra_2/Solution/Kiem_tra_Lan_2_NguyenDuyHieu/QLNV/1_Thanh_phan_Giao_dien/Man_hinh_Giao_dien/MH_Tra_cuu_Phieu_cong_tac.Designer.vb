<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Tra_cuu_Phieu_cong_tac
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
        Me.Th_Chuoi_Tra_cuu = New System.Windows.Forms.TextBox()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Thuc_don_Ung_dung = New System.Windows.Forms.MenuStrip()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Th_Danh_sach_Phieu_cong_tac = New System.Windows.Forms.ToolStrip()
        Me.SuspendLayout()
        '
        'Th_Chuoi_Tra_cuu
        '
        Me.Th_Chuoi_Tra_cuu.BackColor = System.Drawing.Color.White
        Me.Th_Chuoi_Tra_cuu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Chuoi_Tra_cuu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Th_Chuoi_Tra_cuu.Location = New System.Drawing.Point(0, 45)
        Me.Th_Chuoi_Tra_cuu.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.Th_Chuoi_Tra_cuu.Name = "Th_Chuoi_Tra_cuu"
        Me.Th_Chuoi_Tra_cuu.Size = New System.Drawing.Size(775, 20)
        Me.Th_Chuoi_Tra_cuu.TabIndex = 27
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Dock = System.Windows.Forms.DockStyle.Top
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(0, 0)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Padding = New System.Windows.Forms.Padding(10)
        Me.Th_Tieu_de.Size = New System.Drawing.Size(97, 45)
        Me.Th_Tieu_de.TabIndex = 26
        Me.Th_Tieu_de.Text = "Label1"
        Me.Th_Tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Thuc_don_Ung_dung
        '
        Me.Thuc_don_Ung_dung.BackColor = System.Drawing.Color.White
        Me.Thuc_don_Ung_dung.Location = New System.Drawing.Point(0, 0)
        Me.Thuc_don_Ung_dung.Name = "Thuc_don_Ung_dung"
        Me.Thuc_don_Ung_dung.Size = New System.Drawing.Size(775, 24)
        Me.Thuc_don_Ung_dung.TabIndex = 25
        Me.Thuc_don_Ung_dung.Text = "MenuStrip1"
        Me.Thuc_don_Ung_dung.Visible = False
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Dock = System.Windows.Forms.DockStyle.Top
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.ForeColor = System.Drawing.Color.White
        Me.Th_Thong_bao.Location = New System.Drawing.Point(0, 65)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Padding = New System.Windows.Forms.Padding(10)
        Me.Th_Thong_bao.Size = New System.Drawing.Size(86, 44)
        Me.Th_Thong_bao.TabIndex = 29
        Me.Th_Thong_bao.Text = "Label2"
        '
        'Th_Danh_sach_Phieu_cong_tac
        '
        Me.Th_Danh_sach_Phieu_cong_tac.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Th_Danh_sach_Phieu_cong_tac.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.Th_Danh_sach_Phieu_cong_tac.Location = New System.Drawing.Point(0, 109)
        Me.Th_Danh_sach_Phieu_cong_tac.Name = "Th_Danh_sach_Phieu_cong_tac"
        Me.Th_Danh_sach_Phieu_cong_tac.Size = New System.Drawing.Size(775, 0)
        Me.Th_Danh_sach_Phieu_cong_tac.Stretch = True
        Me.Th_Danh_sach_Phieu_cong_tac.TabIndex = 30
        Me.Th_Danh_sach_Phieu_cong_tac.Text = "ToolStrip2"
        '
        'MH_Tra_cuu_Phieu_cong_tac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 468)
        Me.Controls.Add(Me.Th_Danh_sach_Phieu_cong_tac)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.Th_Chuoi_Tra_cuu)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Controls.Add(Me.Thuc_don_Ung_dung)
        Me.Name = "MH_Tra_cuu_Phieu_cong_tac"
        Me.Text = "MH_Tra_cuu_Phieu_cong_tac"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Chuoi_Tra_cuu As TextBox
    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Thuc_don_Ung_dung As MenuStrip
    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Th_Danh_sach_Phieu_cong_tac As ToolStrip
End Class
