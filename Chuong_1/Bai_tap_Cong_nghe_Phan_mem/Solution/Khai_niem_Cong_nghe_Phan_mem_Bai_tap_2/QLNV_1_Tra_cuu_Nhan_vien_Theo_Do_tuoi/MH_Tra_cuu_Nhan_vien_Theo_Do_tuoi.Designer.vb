<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi
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
        Me.Th_Danh_sach_Nhan_vien = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Do_tuoi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(31, 125)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(945, 328)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 7
        '
        'Th_Do_tuoi
        '
        Me.Th_Do_tuoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Do_tuoi.Location = New System.Drawing.Point(121, 68)
        Me.Th_Do_tuoi.Name = "Th_Do_tuoi"
        Me.Th_Do_tuoi.Size = New System.Drawing.Size(289, 26)
        Me.Th_Do_tuoi.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Độ tuổi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(317, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tra cứu nhân viên theo độ tuổi"
        '
        'MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 478)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Th_Do_tuoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi"
        Me.Text = "MH_Tra_cuu_Nhan_vien_Theo_Do_tuoi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Th_Do_tuoi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
