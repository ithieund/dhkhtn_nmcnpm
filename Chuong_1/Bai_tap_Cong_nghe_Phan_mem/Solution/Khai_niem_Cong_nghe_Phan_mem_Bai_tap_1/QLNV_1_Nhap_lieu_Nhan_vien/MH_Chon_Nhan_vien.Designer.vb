﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Chon_Nhan_vien
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
        Me.Th_Danh_sach_Don_vi = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(31, 159)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(921, 353)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 6
        '
        'Th_Danh_sach_Don_vi
        '
        Me.Th_Danh_sach_Don_vi.Location = New System.Drawing.Point(31, 74)
        Me.Th_Danh_sach_Don_vi.Name = "Th_Danh_sach_Don_vi"
        Me.Th_Danh_sach_Don_vi.Size = New System.Drawing.Size(575, 65)
        Me.Th_Danh_sach_Don_vi.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(315, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tra cứu nhân viên theo đơn vị"
        '
        'MH_Chon_Nhan_vien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 535)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Th_Danh_sach_Don_vi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Chon_Nhan_vien"
        Me.Text = "MH_Chon_Nhan_vien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Th_Danh_sach_Don_vi As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
