<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gerente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioVendedorToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.ClientesToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.ProveedoresToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.VentasToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.SalirToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioVendedorToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.VentasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 12, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 48)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioVendedorToolStripMenuItem
        '
        Me.InicioVendedorToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioVendedorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InicioVendedorToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.HouseChimney
        Me.InicioVendedorToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.InicioVendedorToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.InicioVendedorToolStripMenuItem.IconSize = 30
        Me.InicioVendedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InicioVendedorToolStripMenuItem.Name = "InicioVendedorToolStripMenuItem"
        Me.InicioVendedorToolStripMenuItem.Size = New System.Drawing.Size(111, 34)
        Me.InicioVendedorToolStripMenuItem.Text = "Inicio"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientesToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.ClientesToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientesToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClientesToolStripMenuItem.IconSize = 30
        Me.ClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(139, 34)
        Me.ClientesToolStripMenuItem.Text = "Usuarios"
        Me.ClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProveedoresToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.ChartSimple
        Me.ProveedoresToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProveedoresToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ProveedoresToolStripMenuItem.IconSize = 30
        Me.ProveedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(142, 34)
        Me.ProveedoresToolStripMenuItem.Text = "Reportes"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VentasToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.VentasToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VentasToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.VentasToolStripMenuItem.IconSize = 30
        Me.VentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(124, 34)
        Me.VentasToolStripMenuItem.Text = "Backup"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SalirToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.DoorClosed
        Me.SalirToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SalirToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SalirToolStripMenuItem.IconSize = 30
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(103, 34)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.LblFecha)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.LblHora)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.PictureBox1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1264, 633)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 48)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1264, 633)
        Me.ToolStripContainer1.TabIndex = 11
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1025, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 59)
        Me.Label2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(754, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 59)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bienvenido: "
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Trebuchet MS", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblFecha.Location = New System.Drawing.Point(25, 532)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(140, 49)
        Me.LblFecha.TabIndex = 7
        Me.LblFecha.Text = "Label2"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblHora.Location = New System.Drawing.Point(23, 422)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(168, 61)
        Me.LblHora.TabIndex = 6
        Me.LblHora.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FeriaZag.My.Resources.Resources._3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1348, 392)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'HoraFecha
        '
        Me.HoraFecha.Enabled = True
        '
        'Gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Gerente"
        Me.Text = "Sistema Feria Zag"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioVendedorToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ClientesToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents VentasToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents SalirToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblHora As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
