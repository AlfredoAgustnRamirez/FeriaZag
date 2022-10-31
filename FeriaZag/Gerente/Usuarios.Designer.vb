<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LbBackup = New System.Windows.Forms.Label()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DGUsuario = New System.Windows.Forms.DataGridView()
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.TBActivo = New System.Windows.Forms.TextBox()
        Me.LBActivo = New System.Windows.Forms.Label()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.CBPrefilUsuario = New System.Windows.Forms.ComboBox()
        Me.LBPerfil = New System.Windows.Forms.Label()
        Me.LBContraseña = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.LBUsuario = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCodigoUsuario = New System.Windows.Forms.TextBox()
        Me.ICBNuevo = New FontAwesome.Sharp.IconButton()
        Me.ICBAgregar = New FontAwesome.Sharp.IconButton()
        Me.ICBEliminar = New FontAwesome.Sharp.IconButton()
        Me.ICBModificar = New FontAwesome.Sharp.IconButton()
        Me.TBDirecciónUsuario = New System.Windows.Forms.TextBox()
        Me.TBDniUsuario = New System.Windows.Forms.TextBox()
        Me.LDirección = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.TBTelefonoUsuario = New System.Windows.Forms.TextBox()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.TbDni = New System.Windows.Forms.TextBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.LbDni = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TBCodigo2 = New System.Windows.Forms.TextBox()
        Me.GBListar.SuspendLayout()
        CType(Me.DGUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbBackup
        '
        Me.LbBackup.AutoSize = True
        Me.LbBackup.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbBackup.Location = New System.Drawing.Point(529, 9)
        Me.LbBackup.Name = "LbBackup"
        Me.LbBackup.Size = New System.Drawing.Size(376, 46)
        Me.LbBackup.TabIndex = 20
        Me.LbBackup.Text = "Usuarios Registrados"
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DGUsuario)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(408, 195)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(842, 445)
        Me.GBListar.TabIndex = 23
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar Usuarios"
        '
        'DGUsuario
        '
        Me.DGUsuario.AllowUserToAddRows = False
        Me.DGUsuario.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGUsuario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGUsuario.GridColor = System.Drawing.Color.White
        Me.DGUsuario.Location = New System.Drawing.Point(3, 22)
        Me.DGUsuario.Name = "DGUsuario"
        Me.DGUsuario.ReadOnly = True
        Me.DGUsuario.Size = New System.Drawing.Size(836, 420)
        Me.DGUsuario.TabIndex = 0
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.TBActivo)
        Me.GBMantenimiento.Controls.Add(Me.LBActivo)
        Me.GBMantenimiento.Controls.Add(Me.TBContraseña)
        Me.GBMantenimiento.Controls.Add(Me.CBPrefilUsuario)
        Me.GBMantenimiento.Controls.Add(Me.LBPerfil)
        Me.GBMantenimiento.Controls.Add(Me.LBContraseña)
        Me.GBMantenimiento.Controls.Add(Me.TBUsuario)
        Me.GBMantenimiento.Controls.Add(Me.LBUsuario)
        Me.GBMantenimiento.Controls.Add(Me.TBEmail)
        Me.GBMantenimiento.Controls.Add(Me.LblCorreo)
        Me.GBMantenimiento.Controls.Add(Me.Label1)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigoUsuario)
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevo)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregar)
        Me.GBMantenimiento.Controls.Add(Me.ICBEliminar)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificar)
        Me.GBMantenimiento.Controls.Add(Me.TBDirecciónUsuario)
        Me.GBMantenimiento.Controls.Add(Me.TBDniUsuario)
        Me.GBMantenimiento.Controls.Add(Me.LDirección)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.TBNombreUsuario)
        Me.GBMantenimiento.Controls.Add(Me.LApellido)
        Me.GBMantenimiento.Controls.Add(Me.TBApellidoUsuario)
        Me.GBMantenimiento.Controls.Add(Me.LDni)
        Me.GBMantenimiento.Controls.Add(Me.LTelefono)
        Me.GBMantenimiento.Controls.Add(Me.TBTelefonoUsuario)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(14, 58)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 582)
        Me.GBMantenimiento.TabIndex = 22
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Datos Usuarios"
        '
        'TBActivo
        '
        Me.TBActivo.Location = New System.Drawing.Point(151, 400)
        Me.TBActivo.Name = "TBActivo"
        Me.TBActivo.Size = New System.Drawing.Size(181, 26)
        Me.TBActivo.TabIndex = 35
        '
        'LBActivo
        '
        Me.LBActivo.AutoSize = True
        Me.LBActivo.Location = New System.Drawing.Point(60, 403)
        Me.LBActivo.Name = "LBActivo"
        Me.LBActivo.Size = New System.Drawing.Size(62, 22)
        Me.LBActivo.TabIndex = 34
        Me.LBActivo.Text = "Activo:"
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(151, 358)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(181, 26)
        Me.TBContraseña.TabIndex = 33
        '
        'CBPrefilUsuario
        '
        Me.CBPrefilUsuario.FormattingEnabled = True
        Me.CBPrefilUsuario.Items.AddRange(New Object() {"Gerente", "Administrador", "Vendedor"})
        Me.CBPrefilUsuario.Location = New System.Drawing.Point(151, 57)
        Me.CBPrefilUsuario.Name = "CBPrefilUsuario"
        Me.CBPrefilUsuario.Size = New System.Drawing.Size(181, 30)
        Me.CBPrefilUsuario.TabIndex = 1
        '
        'LBPerfil
        '
        Me.LBPerfil.AutoSize = True
        Me.LBPerfil.Location = New System.Drawing.Point(55, 65)
        Me.LBPerfil.Name = "LBPerfil"
        Me.LBPerfil.Size = New System.Drawing.Size(54, 22)
        Me.LBPerfil.TabIndex = 25
        Me.LBPerfil.Text = "Perfil:"
        '
        'LBContraseña
        '
        Me.LBContraseña.AutoSize = True
        Me.LBContraseña.Location = New System.Drawing.Point(55, 363)
        Me.LBContraseña.Name = "LBContraseña"
        Me.LBContraseña.Size = New System.Drawing.Size(94, 22)
        Me.LBContraseña.TabIndex = 32
        Me.LBContraseña.Text = "Contraseña:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(152, 321)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(181, 26)
        Me.TBUsuario.TabIndex = 31
        '
        'LBUsuario
        '
        Me.LBUsuario.AutoSize = True
        Me.LBUsuario.Location = New System.Drawing.Point(56, 326)
        Me.LBUsuario.Name = "LBUsuario"
        Me.LBUsuario.Size = New System.Drawing.Size(68, 22)
        Me.LBUsuario.TabIndex = 30
        Me.LBUsuario.Text = "Usuario:"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(152, 281)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(181, 26)
        Me.TBEmail.TabIndex = 29
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(57, 285)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(55, 22)
        Me.LblCorreo.TabIndex = 28
        Me.LblCorreo.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Codigo:"
        '
        'TBCodigoUsuario
        '
        Me.TBCodigoUsuario.Enabled = False
        Me.TBCodigoUsuario.Location = New System.Drawing.Point(151, 25)
        Me.TBCodigoUsuario.Name = "TBCodigoUsuario"
        Me.TBCodigoUsuario.Size = New System.Drawing.Size(181, 26)
        Me.TBCodigoUsuario.TabIndex = 27
        '
        'ICBNuevo
        '
        Me.ICBNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevo.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevo.IconColor = System.Drawing.Color.Black
        Me.ICBNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevo.IconSize = 40
        Me.ICBNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevo.Location = New System.Drawing.Point(54, 448)
        Me.ICBNuevo.Name = "ICBNuevo"
        Me.ICBNuevo.Size = New System.Drawing.Size(126, 49)
        Me.ICBNuevo.TabIndex = 23
        Me.ICBNuevo.Text = "Nuevo   "
        Me.ICBNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevo.UseVisualStyleBackColor = False
        '
        'ICBAgregar
        '
        Me.ICBAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregar.IconColor = System.Drawing.Color.Black
        Me.ICBAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregar.IconSize = 40
        Me.ICBAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregar.Location = New System.Drawing.Point(204, 448)
        Me.ICBAgregar.Name = "ICBAgregar"
        Me.ICBAgregar.Size = New System.Drawing.Size(129, 49)
        Me.ICBAgregar.TabIndex = 21
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
        Me.ICBEliminar.Location = New System.Drawing.Point(204, 503)
        Me.ICBEliminar.Name = "ICBEliminar"
        Me.ICBEliminar.Size = New System.Drawing.Size(129, 50)
        Me.ICBEliminar.TabIndex = 22
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
        Me.ICBModificar.Location = New System.Drawing.Point(54, 503)
        Me.ICBModificar.Name = "ICBModificar"
        Me.ICBModificar.Size = New System.Drawing.Size(126, 50)
        Me.ICBModificar.TabIndex = 20
        Me.ICBModificar.Text = "Modificar "
        Me.ICBModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificar.UseVisualStyleBackColor = False
        '
        'TBDirecciónUsuario
        '
        Me.TBDirecciónUsuario.Location = New System.Drawing.Point(152, 244)
        Me.TBDirecciónUsuario.Name = "TBDirecciónUsuario"
        Me.TBDirecciónUsuario.Size = New System.Drawing.Size(181, 26)
        Me.TBDirecciónUsuario.TabIndex = 19
        '
        'TBDniUsuario
        '
        Me.TBDniUsuario.Location = New System.Drawing.Point(152, 169)
        Me.TBDniUsuario.Name = "TBDniUsuario"
        Me.TBDniUsuario.Size = New System.Drawing.Size(181, 26)
        Me.TBDniUsuario.TabIndex = 18
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(56, 249)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(84, 22)
        Me.LDirección.TabIndex = 14
        Me.LDirección.Text = "Dirección:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(52, 100)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(72, 22)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'TBNombreUsuario
        '
        Me.TBNombreUsuario.Location = New System.Drawing.Point(152, 96)
        Me.TBNombreUsuario.Name = "TBNombreUsuario"
        Me.TBNombreUsuario.Size = New System.Drawing.Size(181, 26)
        Me.TBNombreUsuario.TabIndex = 12
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(52, 137)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(74, 22)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido:"
        '
        'TBApellidoUsuario
        '
        Me.TBApellidoUsuario.Location = New System.Drawing.Point(153, 133)
        Me.TBApellidoUsuario.Name = "TBApellidoUsuario"
        Me.TBApellidoUsuario.Size = New System.Drawing.Size(181, 26)
        Me.TBApellidoUsuario.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(52, 173)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 22)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "DNI:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(52, 211)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 22)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "Telefono:"
        '
        'TBTelefonoUsuario
        '
        Me.TBTelefonoUsuario.Location = New System.Drawing.Point(152, 206)
        Me.TBTelefonoUsuario.Name = "TBTelefonoUsuario"
        Me.TBTelefonoUsuario.Size = New System.Drawing.Size(181, 26)
        Me.TBTelefonoUsuario.TabIndex = 11
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.TbDni)
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.LbDni)
        Me.GBConsulta.Controls.Add(Me.LbNombre)
        Me.GBConsulta.Controls.Add(Me.TBCodigo2)
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(411, 65)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 115)
        Me.GBConsulta.TabIndex = 26
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consultar Usuario"
        '
        'TbDni
        '
        Me.TbDni.Location = New System.Drawing.Point(386, 50)
        Me.TbDni.Name = "TbDni"
        Me.TbDni.Size = New System.Drawing.Size(180, 26)
        Me.TbDni.TabIndex = 22
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.IconSize = 40
        Me.ICBBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBBuscar.Location = New System.Drawing.Point(630, 38)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(118, 46)
        Me.ICBBuscar.TabIndex = 21
        Me.ICBBuscar.Text = "Buscar  "
        Me.ICBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'LbDni
        '
        Me.LbDni.AutoSize = True
        Me.LbDni.Location = New System.Drawing.Point(328, 50)
        Me.LbDni.Name = "LbDni"
        Me.LbDni.Size = New System.Drawing.Size(39, 22)
        Me.LbDni.TabIndex = 19
        Me.LbDni.Text = "Dni:"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(17, 51)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(72, 22)
        Me.LbNombre.TabIndex = 18
        Me.LbNombre.Text = "Nombre:"
        '
        'TBCodigo2
        '
        Me.TBCodigo2.Location = New System.Drawing.Point(100, 51)
        Me.TBCodigo2.Name = "TBCodigo2"
        Me.TBCodigo2.Size = New System.Drawing.Size(180, 26)
        Me.TBCodigo2.TabIndex = 18
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.LbBackup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.GBListar.ResumeLayout(False)
        CType(Me.DGUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBMantenimiento.ResumeLayout(False)
        Me.GBMantenimiento.PerformLayout()
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbBackup As Label
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DGUsuario As DataGridView
    Friend WithEvents GBMantenimiento As GroupBox
    Friend WithEvents TBDirecciónUsuario As TextBox
    Friend WithEvents TBDniUsuario As TextBox
    Friend WithEvents LDirección As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBNombreUsuario As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBApellidoUsuario As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents TBTelefonoUsuario As TextBox
    Friend WithEvents ICBNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents LBPerfil As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCodigoUsuario As TextBox
    Friend WithEvents CBPrefilUsuario As ComboBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents LBContraseña As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents LBUsuario As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents TBActivo As TextBox
    Friend WithEvents LBActivo As Label
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents LbDni As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents TBCodigo2 As TextBox
    Friend WithEvents TbDni As TextBox
End Class
