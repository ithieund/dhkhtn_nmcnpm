<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Chinh
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
        Me.Th_Tra_cuu = New System.Windows.Forms.Button()
        Me.Th_Them_moi = New System.Windows.Forms.Button()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Tra_cuu
        '
        Me.Th_Tra_cuu.BackColor = System.Drawing.Color.White
        Me.Th_Tra_cuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tra_cuu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Th_Tra_cuu.Location = New System.Drawing.Point(166, 176)
        Me.Th_Tra_cuu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_Tra_cuu.Name = "Th_Tra_cuu"
        Me.Th_Tra_cuu.Size = New System.Drawing.Size(280, 68)
        Me.Th_Tra_cuu.TabIndex = 0
        Me.Th_Tra_cuu.Text = "Tra cứu nhân viên"
        Me.Th_Tra_cuu.UseVisualStyleBackColor = False
        '
        'Th_Them_moi
        '
        Me.Th_Them_moi.BackColor = System.Drawing.Color.White
        Me.Th_Them_moi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Them_moi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Th_Them_moi.Location = New System.Drawing.Point(487, 176)
        Me.Th_Them_moi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Th_Them_moi.Name = "Th_Them_moi"
        Me.Th_Them_moi.Size = New System.Drawing.Size(287, 68)
        Me.Th_Them_moi.TabIndex = 1
        Me.Th_Them_moi.Text = "Thêm mới nhân viên"
        Me.Th_Them_moi.UseVisualStyleBackColor = False
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.White
        Me.Th_Tieu_de.Location = New System.Drawing.Point(221, 38)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(553, 93)
        Me.Th_Tieu_de.TabIndex = 2
        Me.Th_Tieu_de.Text = "Minh họa Thành phần Lưu trữ dữ liệu  ADO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Dữ liệu cấu trúc :   Access, SQLServ" &
    "er,Xml" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Dữ liệu Phi cấu trúc : Tập tin hình .png"
        '
        'MH_Chinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(949, 285)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Controls.Add(Me.Th_Them_moi)
        Me.Controls.Add(Me.Th_Tra_cuu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Chinh"
        Me.Text = "MH_Chinh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Th_Tra_cuu As System.Windows.Forms.Button
    Friend WithEvents Th_Them_moi As System.Windows.Forms.Button
    Friend WithEvents Th_Tieu_de As System.Windows.Forms.Label
End Class
