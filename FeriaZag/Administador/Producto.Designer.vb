<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Producto
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBCodigo = New System.Windows.Forms.TextBox()
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.TBActivo = New System.Windows.Forms.TextBox()
        Me.LBActivo = New System.Windows.Forms.Label()
        Me.ICBNuevo = New FontAwesome.Sharp.IconButton()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ICBAgregar = New FontAwesome.Sharp.IconButton()
        Me.ICBEliminar = New FontAwesome.Sharp.IconButton()
        Me.ICBModificar = New FontAwesome.Sharp.IconButton()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LBCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TBCodigo2 = New System.Windows.Forms.TextBox()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo:"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(28, 124)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(79, 22)
        Me.LCategoria.TabIndex = 3
        Me.LCategoria.Text = "Categoria"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(27, 183)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(66, 22)
        Me.LNombre.TabIndex = 4
        Me.LNombre.Text = "Nombre"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(120, 179)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(216, 26)
        Me.TBNombre.TabIndex = 9
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(120, 236)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(216, 26)
        Me.TBPrecio.TabIndex = 11
        '
        'TBCodigo
        '
        Me.TBCodigo.Enabled = False
        Me.TBCodigo.Location = New System.Drawing.Point(120, 52)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(216, 26)
        Me.TBCodigo.TabIndex = 12
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.TBActivo)
        Me.GBMantenimiento.Controls.Add(Me.LBActivo)
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevo)
        Me.GBMantenimiento.Controls.Add(Me.TBStock)
        Me.GBMantenimiento.Controls.Add(Me.LStock)
        Me.GBMantenimiento.Controls.Add(Me.ComboBox1)
        Me.GBMantenimiento.Controls.Add(Me.Label2)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregar)
        Me.GBMantenimiento.Controls.Add(Me.ICBEliminar)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificar)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigo)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.TBNombre)
        Me.GBMantenimiento.Controls.Add(Me.LCategoria)
        Me.GBMantenimiento.Controls.Add(Me.Label1)
        Me.GBMantenimiento.Controls.Add(Me.TBPrecio)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(12, 53)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(377, 531)
        Me.GBMantenimiento.TabIndex = 20
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Dato Productos"
        '
        'TBActivo
        '
        Me.TBActivo.Location = New System.Drawing.Point(120, 348)
        Me.TBActivo.Name = "TBActivo"
        Me.TBActivo.Size = New System.Drawing.Size(216, 26)
        Me.TBActivo.TabIndex = 32
        '
        'LBActivo
        '
        Me.LBActivo.AutoSize = True
        Me.LBActivo.Location = New System.Drawing.Point(29, 351)
        Me.LBActivo.Name = "LBActivo"
        Me.LBActivo.Size = New System.Drawing.Size(62, 22)
        Me.LBActivo.TabIndex = 31
        Me.LBActivo.Text = "Activo:"
        '
        'ICBNuevo
        '
        Me.ICBNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevo.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevo.IconColor = System.Drawing.Color.Black
        Me.ICBNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevo.IconSize = 40
        Me.ICBNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevo.Location = New System.Drawing.Point(32, 402)
        Me.ICBNuevo.Name = "ICBNuevo"
        Me.ICBNuevo.Size = New System.Drawing.Size(126, 49)
        Me.ICBNuevo.TabIndex = 19
        Me.ICBNuevo.Text = "Nuevo   "
        Me.ICBNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevo.UseVisualStyleBackColor = False
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(120, 295)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(216, 26)
        Me.TBStock.TabIndex = 18
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(28, 299)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(49, 22)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 30)
        Me.ComboBox1.TabIndex = 13
        '
        'ICBAgregar
        '
        Me.ICBAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregar.IconColor = System.Drawing.Color.Black
        Me.ICBAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregar.IconSize = 40
        Me.ICBAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregar.Location = New System.Drawing.Point(182, 402)
        Me.ICBAgregar.Name = "ICBAgregar"
        Me.ICBAgregar.Size = New System.Drawing.Size(129, 49)
        Me.ICBAgregar.TabIndex = 16
        Me.ICBAgregar.Text = "Guardar  "
        Me.ICBAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBAgregar.UseVisualStyleBackColor = False
        '
        'ICBEliminar
        '
        Me.ICBEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.ICBEliminar.IconColor = System.Drawing.Color.Black
        Me.ICBEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBEliminar.IconSize = 40
        Me.ICBEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBEliminar.Location = New System.Drawing.Point(182, 457)
        Me.ICBEliminar.Name = "ICBEliminar"
        Me.ICBEliminar.Size = New System.Drawing.Size(129, 50)
        Me.ICBEliminar.TabIndex = 17
        Me.ICBEliminar.Text = "Eliminar  "
        Me.ICBEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBEliminar.UseVisualStyleBackColor = False
        '
        'ICBModificar
        '
        Me.ICBModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBModificar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck
        Me.ICBModificar.IconColor = System.Drawing.Color.Black
        Me.ICBModificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBModificar.IconSize = 40
        Me.ICBModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBModificar.Location = New System.Drawing.Point(32, 457)
        Me.ICBModificar.Name = "ICBModificar"
        Me.ICBModificar.Size = New System.Drawing.Size(126, 50)
        Me.ICBModificar.TabIndex = 15
        Me.ICBModificar.Text = "Modificar "
        Me.ICBModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificar.UseVisualStyleBackColor = False
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(406, 193)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(812, 391)
        Me.GBListar.TabIndex = 22
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 366)
        Me.DataGridView1.TabIndex = 0
        '
        'LBCliente
        '
        Me.LBCliente.AutoSize = True
        Me.LBCliente.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBCliente.Location = New System.Drawing.Point(529, 9)
        Me.LBCliente.Name = "LBCliente"
        Me.LBCliente.Size = New System.Drawing.Size(193, 46)
        Me.LBCliente.TabIndex = 25
        Me.LBCliente.Text = "Productos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Codigo:"
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.ComboBox2)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TBCodigo2)
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(406, 58)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 115)
        Me.GBConsulta.TabIndex = 21
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consultar Producto"
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.IconSize = 40
        Me.ICBBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBBuscar.Location = New System.Drawing.Point(669, 34)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(118, 46)
        Me.ICBBuscar.TabIndex = 21
        Me.ICBBuscar.Text = "Buscar  "
        Me.ICBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Todos", "Categoria", "Descripcion", "Codigo"})
        Me.ComboBox2.Location = New System.Drawing.Point(89, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(216, 30)
        Me.ComboBox2.TabIndex = 20
        '
        'TBCodigo2
        '
        Me.TBCodigo2.Location = New System.Drawing.Point(325, 48)
        Me.TBCodigo2.Name = "TBCodigo2"
        Me.TBCodigo2.Size = New System.Drawing.Size(313, 26)
        Me.TBCodigo2.TabIndex = 18
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.LBCliente)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Producto"
        Me.Text = "Productos"
        Me.GBMantenimiento.ResumeLayout(False)
        Me.GBMantenimiento.PerformLayout()
        Me.GBListar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBCodigo As TextBox
    Friend WithEvents ICBModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents GBMantenimiento As GroupBox
    Friend WithEvents LStock As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBStock As TextBox
    Friend WithEvents ICBNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents LBCliente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents TBCodigo2 As TextBox
    Friend WithEvents TBActivo As TextBox
    Friend WithEvents LBActivo As Label
End Class
