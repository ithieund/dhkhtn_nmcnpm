<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Chon_Hoc_sinh
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
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Th_Danh_sach_Hoc_sinh = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Danh_sach_Lop = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.Location = New System.Drawing.Point(27, 135)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(66, 24)
        Me.Th_Thong_bao.TabIndex = 10
        Me.Th_Thong_bao.Text = "Label1"
        '
        'Th_Danh_sach_Hoc_sinh
        '
        Me.Th_Danh_sach_Hoc_sinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Hoc_sinh.Location = New System.Drawing.Point(22, 174)
        Me.Th_Danh_sach_Hoc_sinh.Name = "Th_Danh_sach_Hoc_sinh"
        Me.Th_Danh_sach_Hoc_sinh.Size = New System.Drawing.Size(542, 83)
        Me.Th_Danh_sach_Hoc_sinh.TabIndex = 9
        '
        'Th_Danh_sach_Lop
        '
        Me.Th_Danh_sach_Lop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Lop.Location = New System.Drawing.Point(22, 70)
        Me.Th_Danh_sach_Lop.Name = "Th_Danh_sach_Lop"
        Me.Th_Danh_sach_Lop.Size = New System.Drawing.Size(542, 53)
        Me.Th_Danh_sach_Lop.TabIndex = 8
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(236, 21)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(102, 33)
        Me.Th_Tieu_de.TabIndex = 7
        Me.Th_Tieu_de.Text = "Label1"
        '
        'MH_Chon_Hoc_sinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(839, 529)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.Th_Danh_sach_Hoc_sinh)
        Me.Controls.Add(Me.Th_Danh_sach_Lop)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Chon_Hoc_sinh"
        Me.Text = "MH_Chon_Hoc_sinh"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Th_Danh_sach_Hoc_sinh As FlowLayoutPanel
    Friend WithEvents Th_Danh_sach_Lop As FlowLayoutPanel
    Friend WithEvents Th_Tieu_de As Label
End Class
