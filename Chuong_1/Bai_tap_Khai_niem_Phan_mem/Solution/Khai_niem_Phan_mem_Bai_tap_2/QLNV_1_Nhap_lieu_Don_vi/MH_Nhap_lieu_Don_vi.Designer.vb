<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Nhap_lieu_Don_vi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Th_ten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XL_Dong_y = New System.Windows.Forms.Button()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(83, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm đơn vị mới"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Th_ten)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(27, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 88)
        Me.Panel1.TabIndex = 1
        '
        'Th_ten
        '
        Me.Th_ten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_ten.Location = New System.Drawing.Point(104, 31)
        Me.Th_ten.Name = "Th_ten"
        Me.Th_ten.Size = New System.Drawing.Size(194, 26)
        Me.Th_ten.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên đơn vị"
        '
        'XL_Dong_y
        '
        Me.XL_Dong_y.BackColor = System.Drawing.Color.Red
        Me.XL_Dong_y.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XL_Dong_y.ForeColor = System.Drawing.Color.White
        Me.XL_Dong_y.Location = New System.Drawing.Point(127, 186)
        Me.XL_Dong_y.Name = "XL_Dong_y"
        Me.XL_Dong_y.Size = New System.Drawing.Size(124, 57)
        Me.XL_Dong_y.TabIndex = 2
        Me.XL_Dong_y.Text = "Đồng ý"
        Me.XL_Dong_y.UseVisualStyleBackColor = False
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.ForeColor = System.Drawing.Color.Red
        Me.Th_Thong_bao.Location = New System.Drawing.Point(368, 71)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(0, 20)
        Me.Th_Thong_bao.TabIndex = 4
        '
        'MH_Nhap_lieu_Don_vi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 261)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.XL_Dong_y)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Nhap_lieu_Don_vi"
        Me.Text = "MH_Nhap_lieu_Don_vi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Th_ten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents XL_Dong_y As Button
    Friend WithEvents Th_Thong_bao As Label
End Class
