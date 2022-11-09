<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Categoria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.TBCategoria = New System.Windows.Forms.TextBox()
        Me.ICBNuevoCategoria = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ICBAgregarCategoria = New FontAwesome.Sharp.IconButton()
        Me.ICBEliminarCategoria = New FontAwesome.Sharp.IconButton()
        Me.ICBModificarCategoria = New FontAwesome.Sharp.IconButton()
        Me.TBCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.CBCategoria2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LBCategoria = New System.Windows.Forms.Label()
        Me.TBActivo = New System.Windows.Forms.TextBox()
        Me.LBActivo = New System.Windows.Forms.Label()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.TBActivo)
        Me.GBMantenimiento.Controls.Add(Me.LBActivo)
        Me.GBMantenimiento.Controls.Add(Me.TBCategoria)
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevoCategoria)
        Me.GBMantenimiento.Controls.Add(Me.Label2)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregarCategoria)
        Me.GBMantenimiento.Controls.Add(Me.ICBEliminarCategoria)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificarCategoria)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigoCategoria)
        Me.GBMantenimiento.Controls.Add(Me.LCategoria)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(18, 71)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 486)
        Me.GBMantenimiento.TabIndex = 21
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Datos Categoria"
        '
        'TBCategoria
        '
        Me.TBCategoria.Location = New System.Drawing.Point(120, 128)
        Me.TBCategoria.Name = "TBCategoria"
        Me.TBCategoria.Size = New System.Drawing.Size(216, 26)
        Me.TBCategoria.TabIndex = 20
        '
        'ICBNuevoCategoria
        '
        Me.ICBNuevoCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevoCategoria.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevoCategoria.IconColor = System.Drawing.Color.Black
        Me.ICBNuevoCategoria.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevoCategoria.IconSize = 40
        Me.ICBNuevoCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevoCategoria.Location = New System.Drawing.Point(32, 245)
        Me.ICBNuevoCategoria.Name = "ICBNuevoCategoria"
        Me.ICBNuevoCategoria.Size = New System.Drawing.Size(126, 49)
        Me.ICBNuevoCategoria.TabIndex = 19
        Me.ICBNuevoCategoria.Text = "Nuevo   "
        Me.ICBNuevoCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevoCategoria.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo:"
        '
        'ICBAgregarCategoria
        '
        Me.ICBAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregarCategoria.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregarCategoria.IconColor = System.Drawing.Color.Black
        Me.ICBAgregarCategoria.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregarCategoria.IconSize = 40
        Me.ICBAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregarCategoria.Location = New System.Drawing.Point(207, 245)
        Me.ICBAgregarCategoria.Name = "ICBAgregarCategoria"
        Me.ICBAgregarCategoria.Size = New System.Drawing.Size(129, 49)
        Me.ICBAgregarCategoria.TabIndex = 16
        Me.ICBAgregarCategoria.Text = "Guardar  "
        Me.ICBAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBAgregarCategoria.UseVisualStyleBackColor = False
        '
        'ICBEliminarCategoria
        '
        Me.ICBEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBEliminarCategoria.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.ICBEliminarCategoria.IconColor = System.Drawing.Color.Black
        Me.ICBEliminarCategoria.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBEliminarCategoria.IconSize = 40
        Me.ICBEliminarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBEliminarCategoria.Location = New System.Drawing.Point(207, 338)
        Me.ICBEliminarCategoria.Name = "ICBEliminarCategoria"
        Me.ICBEliminarCategoria.Size = New System.Drawing.Size(129, 50)
        Me.ICBEliminarCategoria.TabIndex = 17
        Me.ICBEliminarCategoria.Text = "Eliminar  "
        Me.ICBEliminarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBEliminarCategoria.UseVisualStyleBackColor = False
        '
        'ICBModificarCategoria
        '
        Me.ICBModificarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBModificarCategoria.IconChar = FontAwesome.Sharp.IconChar.CircleCheck
        Me.ICBModificarCategoria.IconColor = System.Drawing.Color.Black
        Me.ICBModificarCategoria.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBModificarCategoria.IconSize = 40
        Me.ICBModificarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBModificarCategoria.Location = New System.Drawing.Point(32, 338)
        Me.ICBModificarCategoria.Name = "ICBModificarCategoria"
        Me.ICBModificarCategoria.Size = New System.Drawing.Size(126, 50)
        Me.ICBModificarCategoria.TabIndex = 15
        Me.ICBModificarCategoria.Text = "Modificar "
        Me.ICBModificarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificarCategoria.UseVisualStyleBackColor = False
        '
        'TBCodigoCategoria
        '
        Me.TBCodigoCategoria.Enabled = False
        Me.TBCodigoCategoria.Location = New System.Drawing.Point(120, 66)
        Me.TBCodigoCategoria.Name = "TBCodigoCategoria"
        Me.TBCodigoCategoria.Size = New System.Drawing.Size(216, 26)
        Me.TBCodigoCategoria.TabIndex = 12
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(28, 131)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(85, 22)
        Me.LCategoria.TabIndex = 3
        Me.LCategoria.Text = "Categoria:"
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(412, 189)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(812, 368)
        Me.GBListar.TabIndex = 23
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar Categoria"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 343)
        Me.DataGridView1.TabIndex = 0
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.CBCategoria2)
        Me.GBConsulta.Controls.Add(Me.Label4)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TBNombreCategoria)
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(412, 75)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 108)
        Me.GBConsulta.TabIndex = 24
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consultar Categoria"
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.IconSize = 40
        Me.ICBBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBBuscar.Location = New System.Drawing.Point(647, 42)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(118, 46)
        Me.ICBBuscar.TabIndex = 18
        Me.ICBBuscar.Text = "Buscar  "
        Me.ICBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'CBCategoria2
        '
        Me.CBCategoria2.FormattingEnabled = True
        Me.CBCategoria2.Location = New System.Drawing.Point(410, 44)
        Me.CBCategoria2.Name = "CBCategoria2"
        Me.CBCategoria2.Size = New System.Drawing.Size(153, 30)
        Me.CBCategoria2.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Categoria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre:"
        '
        'TBNombreCategoria
        '
        Me.TBNombreCategoria.Location = New System.Drawing.Point(106, 48)
        Me.TBNombreCategoria.Name = "TBNombreCategoria"
        Me.TBNombreCategoria.Size = New System.Drawing.Size(168, 26)
        Me.TBNombreCategoria.TabIndex = 18
        '
        'LBCategoria
        '
        Me.LBCategoria.AutoSize = True
        Me.LBCategoria.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBCategoria.Location = New System.Drawing.Point(529, 9)
        Me.LBCategoria.Name = "LBCategoria"
        Me.LBCategoria.Size = New System.Drawing.Size(186, 46)
        Me.LBCategoria.TabIndex = 19
        Me.LBCategoria.Text = "Categoria"
        '
        'TBActivo
        '
        Me.TBActivo.Location = New System.Drawing.Point(120, 189)
        Me.TBActivo.Name = "TBActivo"
        Me.TBActivo.Size = New System.Drawing.Size(216, 26)
        Me.TBActivo.TabIndex = 34
        '
        'LBActivo
        '
        Me.LBActivo.AutoSize = True
        Me.LBActivo.Location = New System.Drawing.Point(29, 192)
        Me.LBActivo.Name = "LBActivo"
        Me.LBActivo.Size = New System.Drawing.Size(62, 22)
        Me.LBActivo.TabIndex = 33
        Me.LBActivo.Text = "Activo:"
        '
        'Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.LBCategoria)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Categoria"
        Me.Text = "Categoria"
        Me.GBMantenimiento.ResumeLayout(False)
        Me.GBMantenimiento.PerformLayout()
        Me.GBListar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBMantenimiento As GroupBox
    Friend WithEvents ICBNuevoCategoria As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ICBAgregarCategoria As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBEliminarCategoria As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBModificarCategoria As FontAwesome.Sharp.IconButton
    Friend WithEvents TBCodigoCategoria As TextBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents CBCategoria2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNombreCategoria As TextBox
    Friend WithEvents LBCategoria As Label
    Friend WithEvents TBCategoria As TextBox
    Friend WithEvents TBActivo As TextBox
    Friend WithEvents LBActivo As Label
End Class
