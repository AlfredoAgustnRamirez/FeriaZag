<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.TBActivo = New System.Windows.Forms.TextBox()
        Me.LBActivo = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.LBEmail = New System.Windows.Forms.Label()
        Me.LBCodigoCliente = New System.Windows.Forms.Label()
        Me.TBCodigoCliente = New System.Windows.Forms.TextBox()
        Me.TBDirecciónCliente = New System.Windows.Forms.TextBox()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.LDirección = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.TBTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.TbBusqueda = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LBCliente = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ICBEliminarCliente = New FontAwesome.Sharp.IconButton()
        Me.ICBModificarCliente = New FontAwesome.Sharp.IconButton()
        Me.ICBAgregarCliente = New FontAwesome.Sharp.IconButton()
        Me.ICBNuevoCliente = New FontAwesome.Sharp.IconButton()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBConsulta.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.TBActivo)
        Me.GBMantenimiento.Controls.Add(Me.LBActivo)
        Me.GBMantenimiento.Controls.Add(Me.TBEmail)
        Me.GBMantenimiento.Controls.Add(Me.LBEmail)
        Me.GBMantenimiento.Controls.Add(Me.LBCodigoCliente)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigoCliente)
        Me.GBMantenimiento.Controls.Add(Me.ICBEliminarCliente)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificarCliente)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregarCliente)
        Me.GBMantenimiento.Controls.Add(Me.TBDirecciónCliente)
        Me.GBMantenimiento.Controls.Add(Me.TBDniCliente)
        Me.GBMantenimiento.Controls.Add(Me.LDirección)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevoCliente)
        Me.GBMantenimiento.Controls.Add(Me.TBNombreCliente)
        Me.GBMantenimiento.Controls.Add(Me.LApellido)
        Me.GBMantenimiento.Controls.Add(Me.TBApellidoCliente)
        Me.GBMantenimiento.Controls.Add(Me.LDni)
        Me.GBMantenimiento.Controls.Add(Me.LTelefono)
        Me.GBMantenimiento.Controls.Add(Me.TBTelefonoCliente)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(22, 59)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 530)
        Me.GBMantenimiento.TabIndex = 21
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Mantenimiento"
        '
        'TBActivo
        '
        Me.TBActivo.Location = New System.Drawing.Point(139, 365)
        Me.TBActivo.Name = "TBActivo"
        Me.TBActivo.Size = New System.Drawing.Size(181, 26)
        Me.TBActivo.TabIndex = 28
        '
        'LBActivo
        '
        Me.LBActivo.AutoSize = True
        Me.LBActivo.Location = New System.Drawing.Point(39, 369)
        Me.LBActivo.Name = "LBActivo"
        Me.LBActivo.Size = New System.Drawing.Size(62, 22)
        Me.LBActivo.TabIndex = 27
        Me.LBActivo.Text = "Activo:"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(138, 268)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(183, 26)
        Me.TBEmail.TabIndex = 26
        '
        'LBEmail
        '
        Me.LBEmail.AutoSize = True
        Me.LBEmail.Location = New System.Drawing.Point(38, 272)
        Me.LBEmail.Name = "LBEmail"
        Me.LBEmail.Size = New System.Drawing.Size(55, 22)
        Me.LBEmail.TabIndex = 25
        Me.LBEmail.Text = "Email:"
        '
        'LBCodigoCliente
        '
        Me.LBCodigoCliente.AutoSize = True
        Me.LBCodigoCliente.Location = New System.Drawing.Point(38, 39)
        Me.LBCodigoCliente.Name = "LBCodigoCliente"
        Me.LBCodigoCliente.Size = New System.Drawing.Size(66, 22)
        Me.LBCodigoCliente.TabIndex = 24
        Me.LBCodigoCliente.Text = "Codigo:"
        '
        'TBCodigoCliente
        '
        Me.TBCodigoCliente.Enabled = False
        Me.TBCodigoCliente.Location = New System.Drawing.Point(138, 35)
        Me.TBCodigoCliente.Name = "TBCodigoCliente"
        Me.TBCodigoCliente.Size = New System.Drawing.Size(181, 26)
        Me.TBCodigoCliente.TabIndex = 23
        '
        'TBDirecciónCliente
        '
        Me.TBDirecciónCliente.Location = New System.Drawing.Point(138, 319)
        Me.TBDirecciónCliente.Name = "TBDirecciónCliente"
        Me.TBDirecciónCliente.Size = New System.Drawing.Size(183, 26)
        Me.TBDirecciónCliente.TabIndex = 19
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Location = New System.Drawing.Point(139, 168)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(181, 26)
        Me.TBDniCliente.TabIndex = 18
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(37, 323)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(84, 22)
        Me.LDirección.TabIndex = 14
        Me.LDirección.Text = "Dirección:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(39, 79)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(72, 22)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Location = New System.Drawing.Point(139, 75)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(181, 26)
        Me.TBNombreCliente.TabIndex = 12
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(37, 124)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(74, 22)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido:"
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Location = New System.Drawing.Point(138, 121)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(181, 26)
        Me.TBApellidoCliente.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(39, 172)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 22)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "DNI:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(37, 223)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 22)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "Telefono:"
        '
        'TBTelefonoCliente
        '
        Me.TBTelefonoCliente.Location = New System.Drawing.Point(138, 219)
        Me.TBTelefonoCliente.Name = "TBTelefonoCliente"
        Me.TBTelefonoCliente.Size = New System.Drawing.Size(181, 26)
        Me.TBTelefonoCliente.TabIndex = 11
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.TbBusqueda)
        Me.GBConsulta.Controls.Add(Me.ComboBox2)
        Me.GBConsulta.Controls.Add(Me.IconButton1)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(419, 58)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 115)
        Me.GBConsulta.TabIndex = 22
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consulta"
        '
        'TbBusqueda
        '
        Me.TbBusqueda.Location = New System.Drawing.Point(366, 49)
        Me.TbBusqueda.Name = "TbBusqueda"
        Me.TbBusqueda.Size = New System.Drawing.Size(287, 26)
        Me.TbBusqueda.TabIndex = 29
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Todos", "Dni", "Nombre"})
        Me.ComboBox2.Location = New System.Drawing.Point(133, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(216, 30)
        Me.ComboBox2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Busqueda por:"
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(419, 180)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(812, 409)
        Me.GBListar.TabIndex = 23
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 384)
        Me.DataGridView1.TabIndex = 0
        '
        'LBCliente
        '
        Me.LBCliente.AutoSize = True
        Me.LBCliente.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBCliente.Location = New System.Drawing.Point(529, 9)
        Me.LBCliente.Name = "LBCliente"
        Me.LBCliente.Size = New System.Drawing.Size(144, 46)
        Me.LBCliente.TabIndex = 24
        Me.LBCliente.Text = "Cliente"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(668, 40)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(118, 46)
        Me.IconButton1.TabIndex = 19
        Me.IconButton1.Text = "Buscar  "
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ICBEliminarCliente
        '
        Me.ICBEliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.ICBEliminarCliente.IconColor = System.Drawing.Color.Black
        Me.ICBEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBEliminarCliente.IconSize = 40
        Me.ICBEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBEliminarCliente.Location = New System.Drawing.Point(188, 472)
        Me.ICBEliminarCliente.Name = "ICBEliminarCliente"
        Me.ICBEliminarCliente.Size = New System.Drawing.Size(129, 46)
        Me.ICBEliminarCliente.TabIndex = 22
        Me.ICBEliminarCliente.Text = "Eliminar  "
        Me.ICBEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBEliminarCliente.UseVisualStyleBackColor = False
        '
        'ICBModificarCliente
        '
        Me.ICBModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBModificarCliente.IconChar = FontAwesome.Sharp.IconChar.CircleCheck
        Me.ICBModificarCliente.IconColor = System.Drawing.Color.Black
        Me.ICBModificarCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBModificarCliente.IconSize = 40
        Me.ICBModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBModificarCliente.Location = New System.Drawing.Point(46, 472)
        Me.ICBModificarCliente.Name = "ICBModificarCliente"
        Me.ICBModificarCliente.Size = New System.Drawing.Size(126, 46)
        Me.ICBModificarCliente.TabIndex = 21
        Me.ICBModificarCliente.Text = "Modificar "
        Me.ICBModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificarCliente.UseVisualStyleBackColor = False
        '
        'ICBAgregarCliente
        '
        Me.ICBAgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregarCliente.IconColor = System.Drawing.Color.Black
        Me.ICBAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregarCliente.IconSize = 40
        Me.ICBAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregarCliente.Location = New System.Drawing.Point(190, 422)
        Me.ICBAgregarCliente.Name = "ICBAgregarCliente"
        Me.ICBAgregarCliente.Size = New System.Drawing.Size(129, 44)
        Me.ICBAgregarCliente.TabIndex = 20
        Me.ICBAgregarCliente.Text = "Guardar  "
        Me.ICBAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBAgregarCliente.UseVisualStyleBackColor = False
        '
        'ICBNuevoCliente
        '
        Me.ICBNuevoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevoCliente.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevoCliente.IconColor = System.Drawing.Color.Black
        Me.ICBNuevoCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevoCliente.IconSize = 40
        Me.ICBNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevoCliente.Location = New System.Drawing.Point(48, 422)
        Me.ICBNuevoCliente.Name = "ICBNuevoCliente"
        Me.ICBNuevoCliente.Size = New System.Drawing.Size(126, 44)
        Me.ICBNuevoCliente.TabIndex = 16
        Me.ICBNuevoCliente.Text = "Nuevo  "
        Me.ICBNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevoCliente.UseVisualStyleBackColor = False
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 644)
        Me.Controls.Add(Me.LBCliente)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cliente"
        Me.Text = "Clientes"
        Me.GBMantenimiento.ResumeLayout(False)
        Me.GBMantenimiento.PerformLayout()
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.GBListar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBMantenimiento As GroupBox
    Friend WithEvents TBDirecciónCliente As TextBox
    Friend WithEvents TBDniCliente As TextBox
    Friend WithEvents LDirección As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents ICBNuevoCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents TBTelefonoCliente As TextBox
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LBCliente As Label
    Friend WithEvents ICBAgregarCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBModificarCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBEliminarCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents LBCodigoCliente As Label
    Friend WithEvents TBCodigoCliente As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents LBEmail As Label
    Friend WithEvents TBActivo As TextBox
    Friend WithEvents LBActivo As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TbBusqueda As TextBox
End Class
