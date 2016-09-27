<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Cap_nhat_Don_vi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Th_Ten_Don_vi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.XL_Dong_y = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XL_Chon_Don_vi = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Th_Ten_Don_vi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(21, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 70)
        Me.Panel1.TabIndex = 10
        '
        'Th_Ten_Don_vi
        '
        Me.Th_Ten_Don_vi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Ten_Don_vi.Location = New System.Drawing.Point(123, 21)
        Me.Th_Ten_Don_vi.Name = "Th_Ten_Don_vi"
        Me.Th_Ten_Don_vi.Size = New System.Drawing.Size(298, 26)
        Me.Th_Ten_Don_vi.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên đơn vị"
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.ForeColor = System.Drawing.Color.Navy
        Me.Th_Thong_bao.Location = New System.Drawing.Point(494, 68)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(0, 24)
        Me.Th_Thong_bao.TabIndex = 12
        '
        'XL_Dong_y
        '
        Me.XL_Dong_y.BackColor = System.Drawing.Color.Red
        Me.XL_Dong_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XL_Dong_y.ForeColor = System.Drawing.Color.White
        Me.XL_Dong_y.Location = New System.Drawing.Point(187, 153)
        Me.XL_Dong_y.Name = "XL_Dong_y"
        Me.XL_Dong_y.Size = New System.Drawing.Size(129, 53)
        Me.XL_Dong_y.TabIndex = 11
        Me.XL_Dong_y.Text = "Đồng ý"
        Me.XL_Dong_y.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(150, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cập nhật đơn vị"
        '
        'XL_Chon_Don_vi
        '
        Me.XL_Chon_Don_vi.BackColor = System.Drawing.Color.Red
        Me.XL_Chon_Don_vi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XL_Chon_Don_vi.ForeColor = System.Drawing.Color.White
        Me.XL_Chon_Don_vi.Location = New System.Drawing.Point(344, 153)
        Me.XL_Chon_Don_vi.Name = "XL_Chon_Don_vi"
        Me.XL_Chon_Don_vi.Size = New System.Drawing.Size(138, 53)
        Me.XL_Chon_Don_vi.TabIndex = 13
        Me.XL_Chon_Don_vi.Text = "Chọn đơn vị"
        Me.XL_Chon_Don_vi.UseVisualStyleBackColor = False
        '
        'MH_Cap_nhat_Don_vi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 226)
        Me.Controls.Add(Me.XL_Chon_Don_vi)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.XL_Dong_y)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Cap_nhat_Don_vi"
        Me.Text = "MH_Cap_nhat_Don_vi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Th_Ten_Don_vi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents XL_Dong_y As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents XL_Chon_Don_vi As Button
End Class
