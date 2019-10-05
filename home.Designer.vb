<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepedaMotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepedaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepedaMotorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepedaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SepedaMotorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignUpAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockSepedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsnama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SewaToolStripMenuItem, Me.PengembalianToolStripMenuItem, Me.RekapBulananToolStripMenuItem, Me.SignUpAdminToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.StockToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(761, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SewaToolStripMenuItem
        '
        Me.SewaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SepedaToolStripMenuItem, Me.SepedaMotorToolStripMenuItem})
        Me.SewaToolStripMenuItem.Name = "SewaToolStripMenuItem"
        Me.SewaToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.SewaToolStripMenuItem.Text = "Sewa"
        '
        'SepedaToolStripMenuItem
        '
        Me.SepedaToolStripMenuItem.Name = "SepedaToolStripMenuItem"
        Me.SepedaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SepedaToolStripMenuItem.Text = "Sepeda"
        '
        'SepedaMotorToolStripMenuItem
        '
        Me.SepedaMotorToolStripMenuItem.Name = "SepedaMotorToolStripMenuItem"
        Me.SepedaMotorToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SepedaMotorToolStripMenuItem.Text = "Sepeda Motor"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SepedaToolStripMenuItem1, Me.SepedaMotorToolStripMenuItem1})
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'SepedaToolStripMenuItem1
        '
        Me.SepedaToolStripMenuItem1.Name = "SepedaToolStripMenuItem1"
        Me.SepedaToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.SepedaToolStripMenuItem1.Text = "Sepeda"
        '
        'SepedaMotorToolStripMenuItem1
        '
        Me.SepedaMotorToolStripMenuItem1.Name = "SepedaMotorToolStripMenuItem1"
        Me.SepedaMotorToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.SepedaMotorToolStripMenuItem1.Text = "Sepeda Motor"
        '
        'RekapBulananToolStripMenuItem
        '
        Me.RekapBulananToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SepedaToolStripMenuItem2, Me.SepedaMotorToolStripMenuItem2})
        Me.RekapBulananToolStripMenuItem.Name = "RekapBulananToolStripMenuItem"
        Me.RekapBulananToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.RekapBulananToolStripMenuItem.Text = "Rekap Bulanan"
        '
        'SepedaToolStripMenuItem2
        '
        Me.SepedaToolStripMenuItem2.Name = "SepedaToolStripMenuItem2"
        Me.SepedaToolStripMenuItem2.Size = New System.Drawing.Size(148, 22)
        Me.SepedaToolStripMenuItem2.Text = "Sepeda"
        '
        'SepedaMotorToolStripMenuItem2
        '
        Me.SepedaMotorToolStripMenuItem2.Name = "SepedaMotorToolStripMenuItem2"
        Me.SepedaMotorToolStripMenuItem2.Size = New System.Drawing.Size(148, 22)
        Me.SepedaMotorToolStripMenuItem2.Text = "Sepeda Motor"
        '
        'SignUpAdminToolStripMenuItem
        '
        Me.SignUpAdminToolStripMenuItem.Name = "SignUpAdminToolStripMenuItem"
        Me.SignUpAdminToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.SignUpAdminToolStripMenuItem.Text = "Sign Up Admin"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockSepedaToolStripMenuItem, Me.StockMotorToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'StockSepedaToolStripMenuItem
        '
        Me.StockSepedaToolStripMenuItem.Name = "StockSepedaToolStripMenuItem"
        Me.StockSepedaToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.StockSepedaToolStripMenuItem.Text = "Stock Sepeda"
        '
        'StockMotorToolStripMenuItem
        '
        Me.StockMotorToolStripMenuItem.Name = "StockMotorToolStripMenuItem"
        Me.StockMotorToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.StockMotorToolStripMenuItem.Text = "Stock Motor"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(761, 503)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 823
        Me.LineShape1.Y1 = 27
        Me.LineShape1.Y2 = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(757, 211)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "STATUS"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(2, 285)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(757, 217)
        Me.DataGridView2.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsnama})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 481)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(761, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsnama
        '
        Me.tsnama.Name = "tsnama"
        Me.tsnama.Size = New System.Drawing.Size(37, 17)
        Me.tsnama.Text = "nama"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(761, 503)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SewaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapBulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignUpAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SepedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepedaMotorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepedaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepedaMotorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockSepedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockMotorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SepedaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepedaMotorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsnama As System.Windows.Forms.ToolStripStatusLabel
End Class
