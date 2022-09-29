<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteVendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.TBDirección = New System.Windows.Forms.TextBox()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.LDirección = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBCodigo = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.ICBNuevo = New FontAwesome.Sharp.IconButton()
        Me.ICBAgregar = New FontAwesome.Sharp.IconButton()
        Me.ICBEliminar = New FontAwesome.Sharp.IconButton()
        Me.ICBModificar = New FontAwesome.Sharp.IconButton()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dirección = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBCliente = New System.Windows.Forms.Label()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevo)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregar)
        Me.GBMantenimiento.Controls.Add(Me.ICBEliminar)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificar)
        Me.GBMantenimiento.Controls.Add(Me.TBDirección)
        Me.GBMantenimiento.Controls.Add(Me.TBDni)
        Me.GBMantenimiento.Controls.Add(Me.LDirección)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigo)
        Me.GBMantenimiento.Controls.Add(Me.LApellido)
        Me.GBMantenimiento.Controls.Add(Me.TBNombre)
        Me.GBMantenimiento.Controls.Add(Me.LDni)
        Me.GBMantenimiento.Controls.Add(Me.LTelefono)
        Me.GBMantenimiento.Controls.Add(Me.TBPrecio)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(12, 69)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 600)
        Me.GBMantenimiento.TabIndex = 22
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Datos Cliente"
        '
        'TBDirección
        '
        Me.TBDirección.Location = New System.Drawing.Point(138, 314)
        Me.TBDirección.Name = "TBDirección"
        Me.TBDirección.Size = New System.Drawing.Size(181, 26)
        Me.TBDirección.TabIndex = 19
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(138, 193)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(181, 26)
        Me.TBDni.TabIndex = 18
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(42, 319)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(84, 22)
        Me.LDirección.TabIndex = 14
        Me.LDirección.Text = "Dirección:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(38, 74)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(72, 22)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'TBCodigo
        '
        Me.TBCodigo.Location = New System.Drawing.Point(138, 70)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(181, 26)
        Me.TBCodigo.TabIndex = 12
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(37, 134)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(74, 22)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido:"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(138, 130)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(181, 26)
        Me.TBNombre.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(38, 197)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 22)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "DNI:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(38, 259)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 22)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "Telefono:"
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(138, 254)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(181, 26)
        Me.TBPrecio.TabIndex = 11
        '
        'ICBNuevo
        '
        Me.ICBNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevo.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevo.IconColor = System.Drawing.Color.Black
        Me.ICBNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevo.Location = New System.Drawing.Point(41, 412)
        Me.ICBNuevo.Name = "ICBNuevo"
        Me.ICBNuevo.Size = New System.Drawing.Size(126, 49)
        Me.ICBNuevo.TabIndex = 23
        Me.ICBNuevo.Text = "Nuevo"
        Me.ICBNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevo.UseVisualStyleBackColor = False
        '
        'ICBAgregar
        '
        Me.ICBAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregar.IconColor = System.Drawing.Color.Black
        Me.ICBAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregar.Location = New System.Drawing.Point(191, 412)
        Me.ICBAgregar.Name = "ICBAgregar"
        Me.ICBAgregar.Size = New System.Drawing.Size(129, 49)
        Me.ICBAgregar.TabIndex = 21
        Me.ICBAgregar.Text = "Guardar"
        Me.ICBAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBAgregar.UseVisualStyleBackColor = False
        '
        'ICBEliminar
        '
        Me.ICBEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBEliminar.IconChar = FontAwesome.Sharp.IconChar.X
        Me.ICBEliminar.IconColor = System.Drawing.Color.Black
        Me.ICBEliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBEliminar.Location = New System.Drawing.Point(191, 496)
        Me.ICBEliminar.Name = "ICBEliminar"
        Me.ICBEliminar.Size = New System.Drawing.Size(129, 50)
        Me.ICBEliminar.TabIndex = 22
        Me.ICBEliminar.Text = "Eliminar"
        Me.ICBEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBEliminar.UseVisualStyleBackColor = False
        '
        'ICBModificar
        '
        Me.ICBModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBModificar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck
        Me.ICBModificar.IconColor = System.Drawing.Color.Black
        Me.ICBModificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBModificar.Location = New System.Drawing.Point(41, 496)
        Me.ICBModificar.Name = "ICBModificar"
        Me.ICBModificar.Size = New System.Drawing.Size(126, 50)
        Me.ICBModificar.TabIndex = 20
        Me.ICBModificar.Text = "Modificar"
        Me.ICBModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificar.UseVisualStyleBackColor = False
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(394, 178)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(812, 459)
        Me.GBListar.TabIndex = 24
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar Clientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.DNI, Me.Telefono, Me.Dirección})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 434)
        Me.DataGridView1.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Dirección
        '
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.Name = "Dirección"
        Me.Dirección.ReadOnly = True
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.TextBox2)
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.Label4)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TextBox1)
        Me.GBConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(397, 69)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 103)
        Me.GBConsulta.TabIndex = 25
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consultar Cliente"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(384, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(153, 26)
        Me.TextBox2.TabIndex = 19
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.Location = New System.Drawing.Point(673, 39)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(118, 41)
        Me.ICBBuscar.TabIndex = 18
        Me.ICBBuscar.Text = "Buscar"
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 26)
        Me.TextBox1.TabIndex = 18
        '
        'LBCliente
        '
        Me.LBCliente.AutoSize = True
        Me.LBCliente.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCliente.Location = New System.Drawing.Point(519, 9)
        Me.LBCliente.Name = "LBCliente"
        Me.LBCliente.Size = New System.Drawing.Size(150, 43)
        Me.LBCliente.TabIndex = 20
        Me.LBCliente.Text = "Clientes"
        '
        'ClienteVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.LBCliente)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClienteVendedor"
        Me.Text = "ClienteVendedor"
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
    Friend WithEvents TBDirección As TextBox
    Friend WithEvents TBDni As TextBox
    Friend WithEvents LDirección As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBCodigo As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents ICBNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Dirección As DataGridViewTextBoxColumn
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LBCliente As Label
End Class
