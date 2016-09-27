<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Tra_cuu_Hoc_sinh_theo_Ho_ten
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
        Me.Th_Chuoi_Ho_ten = New System.Windows.Forms.TextBox()
        Me.Th_Danh_sach_Hoc_sinh = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.Location = New System.Drawing.Point(27, 143)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(66, 24)
        Me.Th_Thong_bao.TabIndex = 13
        Me.Th_Thong_bao.Text = "Label1"
        '
        'Th_Chuoi_Ho_ten
        '
        Me.Th_Chuoi_Ho_ten.Location = New System.Drawing.Point(22, 101)
        Me.Th_Chuoi_Ho_ten.Name = "Th_Chuoi_Ho_ten"
        Me.Th_Chuoi_Ho_ten.Size = New System.Drawing.Size(213, 26)
        Me.Th_Chuoi_Ho_ten.TabIndex = 10
        '
        'Th_Danh_sach_Hoc_sinh
        '
        Me.Th_Danh_sach_Hoc_sinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Hoc_sinh.Location = New System.Drawing.Point(22, 180)
        Me.Th_Danh_sach_Hoc_sinh.Name = "Th_Danh_sach_Hoc_sinh"
        Me.Th_Danh_sach_Hoc_sinh.Size = New System.Drawing.Size(754, 310)
        Me.Th_Danh_sach_Hoc_sinh.TabIndex = 12
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(267, 35)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(102, 33)
        Me.Th_Tieu_de.TabIndex = 11
        Me.Th_Tieu_de.Text = "Label1"
        '
        'MH_Tra_cuu_Hoc_sinh_theo_Ho_ten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(863, 534)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.Th_Chuoi_Ho_ten)
        Me.Controls.Add(Me.Th_Danh_sach_Hoc_sinh)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Tra_cuu_Hoc_sinh_theo_Ho_ten"
        Me.Text = "MH_Tra_cuu_Hoc_sinh_theo_Ho_ten"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Th_Chuoi_Ho_ten As TextBox
    Friend WithEvents Th_Danh_sach_Hoc_sinh As FlowLayoutPanel
    Friend WithEvents Th_Tieu_de As Label
End Class
