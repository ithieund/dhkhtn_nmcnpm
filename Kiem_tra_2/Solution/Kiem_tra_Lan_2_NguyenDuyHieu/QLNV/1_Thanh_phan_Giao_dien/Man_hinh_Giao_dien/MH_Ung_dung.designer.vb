<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Ung_dung
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
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Thuc_don = New System.Windows.Forms.MenuStrip()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(56, 18)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(102, 33)
        Me.Th_Tieu_de.TabIndex = 0
        Me.Th_Tieu_de.Text = "Label1"
        '
        'Thuc_don
        '
        Me.Thuc_don.BackColor = System.Drawing.Color.White
        Me.Thuc_don.Dock = System.Windows.Forms.DockStyle.None
        Me.Thuc_don.Location = New System.Drawing.Point(9, 71)
        Me.Thuc_don.Name = "Thuc_don"
        Me.Thuc_don.Size = New System.Drawing.Size(202, 24)
        Me.Thuc_don.TabIndex = 1
        Me.Thuc_don.Text = "MenuStrip1"
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.Location = New System.Drawing.Point(12, 138)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(77, 25)
        Me.Th_Thong_bao.TabIndex = 2
        Me.Th_Thong_bao.Text = "Label1"
        '
        'MH_Chinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(663, 407)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Controls.Add(Me.Thuc_don)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.Thuc_don
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Chinh"
        Me.Text = "MH_Chinh"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Thuc_don As MenuStrip
    Friend WithEvents Th_Thong_bao As Label
End Class
