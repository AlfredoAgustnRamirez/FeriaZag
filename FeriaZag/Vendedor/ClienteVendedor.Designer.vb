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
        Me.TBActivo = New System.Windows.Forms.TextBox()
        Me.LBActivo = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.LBEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCodigoCvendedor = New System.Windows.Forms.TextBox()
        Me.ICBNuevoCvendedor = New FontAwesome.Sharp.IconButton()
        Me.ICBAgregarCvendedor = New FontAwesome.Sharp.IconButton()
        Me.ICBModificarCvendedor = New FontAwesome.Sharp.IconButton()
        Me.TBDirecciónCvendedor = New System.Windows.Forms.TextBox()
        Me.TBDniCvendedor = New System.Windows.Forms.TextBox()
        Me.LDirección = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBNombreCvendedor = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBApellidoCvendedor = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.TBTelefonoCvendedor = New System.Windows.Forms.TextBox()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscarCvendedor = New FontAwesome.Sharp.IconButton()
        Me.LBCliente = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBCodigo2 = New System.Windows.Forms.TextBox()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.TBActivo)
        Me.GBMantenimiento.Controls.Add(Me.LBActivo)
        Me.GBMantenimiento.Controls.Add(Me.TBEmail)
        Me.GBMantenimiento.Controls.Add(Me.LBEmail)
        Me.GBMantenimiento.Controls.Add(Me.Label1)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigoCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevoCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregarCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificarCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.TBDirecciónCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.TBDniCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.LDirección)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.TBNombreCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.LApellido)
        Me.GBMantenimiento.Controls.Add(Me.TBApellidoCvendedor)
        Me.GBMantenimiento.Controls.Add(Me.LDni)
        Me.GBMantenimiento.Controls.Add(Me.LTelefono)
        Me.GBMantenimiento.Controls.Add(Me.TBTelefonoCvendedor)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(14, 48)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 539)
        Me.GBMantenimiento.TabIndex = 22
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Datos Cliente"
        '
        'TBActivo
        '
        Me.TBActivo.Location = New System.Drawing.Point(135, 353)
        Me.TBActivo.Name = "TBActivo"
        Me.TBActivo.Size = New System.Drawing.Size(181, 26)
        Me.TBActivo.TabIndex = 30
        '
        'LBActivo
        '
        Me.LBActivo.AutoSize = True
        Me.LBActivo.Location = New System.Drawing.Point(44, 356)
        Me.LBActivo.Name = "LBActivo"
        Me.LBActivo.Size = New System.Drawing.Size(62, 22)
        Me.LBActivo.TabIndex = 29
        Me.LBActivo.Text = "Activo:"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(138, 251)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(183, 26)
        Me.TBEmail.TabIndex = 28
        '
        'LBEmail
        '
        Me.LBEmail.AutoSize = True
        Me.LBEmail.Location = New System.Drawing.Point(41, 255)
        Me.LBEmail.Name = "LBEmail"
        Me.LBEmail.Size = New System.Drawing.Size(55, 22)
        Me.LBEmail.TabIndex = 27
        Me.LBEmail.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Codigo:"
        '
        'TBCodigoCvendedor
        '
        Me.TBCodigoCvendedor.Enabled = False
        Me.TBCodigoCvendedor.Location = New System.Drawing.Point(138, 39)
        Me.TBCodigoCvendedor.Name = "TBCodigoCvendedor"
        Me.TBCodigoCvendedor.Size = New System.Drawing.Size(181, 26)
        Me.TBCodigoCvendedor.TabIndex = 24
        '
        'ICBNuevoCvendedor
        '
        Me.ICBNuevoCvendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevoCvendedor.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevoCvendedor.IconColor = System.Drawing.Color.Black
        Me.ICBNuevoCvendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevoCvendedor.IconSize = 40
        Me.ICBNuevoCvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevoCvendedor.Location = New System.Drawing.Point(40, 403)
        Me.ICBNuevoCvendedor.Name = "ICBNuevoCvendedor"
        Me.ICBNuevoCvendedor.Size = New System.Drawing.Size(126, 49)
        Me.ICBNuevoCvendedor.TabIndex = 23
        Me.ICBNuevoCvendedor.Text = "Nuevo   "
        Me.ICBNuevoCvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevoCvendedor.UseVisualStyleBackColor = False
        '
        'ICBAgregarCvendedor
        '
        Me.ICBAgregarCvendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregarCvendedor.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregarCvendedor.IconColor = System.Drawing.Color.Black
        Me.ICBAgregarCvendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregarCvendedor.IconSize = 40
        Me.ICBAgregarCvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregarCvendedor.Location = New System.Drawing.Point(190, 403)
        Me.ICBAgregarCvendedor.Name = "ICBAgregarCvendedor"
        Me.ICBAgregarCvendedor.Size = New System.Drawing.Size(129, 49)
        Me.ICBAgregarCvendedor.TabIndex = 21
        Me.ICBAgregarCvendedor.Text = "Guardar  "
        Me.ICBAgregarCvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBAgregarCvendedor.UseVisualStyleBackColor = False
        '
        'ICBModificarCvendedor
        '
        Me.ICBModificarCvendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBModificarCvendedor.IconChar = FontAwesome.Sharp.IconChar.CircleCheck
        Me.ICBModificarCvendedor.IconColor = System.Drawing.Color.Black
        Me.ICBModificarCvendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBModificarCvendedor.IconSize = 40
        Me.ICBModificarCvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBModificarCvendedor.Location = New System.Drawing.Point(114, 467)
        Me.ICBModificarCvendedor.Name = "ICBModificarCvendedor"
        Me.ICBModificarCvendedor.Size = New System.Drawing.Size(126, 50)
        Me.ICBModificarCvendedor.TabIndex = 20
        Me.ICBModificarCvendedor.Text = "Modificar "
        Me.ICBModificarCvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificarCvendedor.UseVisualStyleBackColor = False
        '
        'TBDirecciónCvendedor
        '
        Me.TBDirecciónCvendedor.Location = New System.Drawing.Point(138, 303)
        Me.TBDirecciónCvendedor.Name = "TBDirecciónCvendedor"
        Me.TBDirecciónCvendedor.Size = New System.Drawing.Size(181, 26)
        Me.TBDirecciónCvendedor.TabIndex = 19
        '
        'TBDniCvendedor
        '
        Me.TBDniCvendedor.Location = New System.Drawing.Point(137, 164)
        Me.TBDniCvendedor.Name = "TBDniCvendedor"
        Me.TBDniCvendedor.Size = New System.Drawing.Size(181, 26)
        Me.TBDniCvendedor.TabIndex = 18
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(39, 307)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(84, 22)
        Me.LDirección.TabIndex = 14
        Me.LDirección.Text = "Dirección:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(40, 81)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(72, 22)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'TBNombreCvendedor
        '
        Me.TBNombreCvendedor.Location = New System.Drawing.Point(140, 77)
        Me.TBNombreCvendedor.Name = "TBNombreCvendedor"
        Me.TBNombreCvendedor.Size = New System.Drawing.Size(181, 26)
        Me.TBNombreCvendedor.TabIndex = 12
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
        'TBApellidoCvendedor
        '
        Me.TBApellidoCvendedor.Location = New System.Drawing.Point(138, 120)
        Me.TBApellidoCvendedor.Name = "TBApellidoCvendedor"
        Me.TBApellidoCvendedor.Size = New System.Drawing.Size(181, 26)
        Me.TBApellidoCvendedor.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(42, 168)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 22)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "DNI:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(41, 212)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 22)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "Telefono:"
        '
        'TBTelefonoCvendedor
        '
        Me.TBTelefonoCvendedor.Location = New System.Drawing.Point(137, 209)
        Me.TBTelefonoCvendedor.Name = "TBTelefonoCvendedor"
        Me.TBTelefonoCvendedor.Size = New System.Drawing.Size(181, 26)
        Me.TBTelefonoCvendedor.TabIndex = 11
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView2)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(396, 157)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(812, 430)
        Me.GBListar.TabIndex = 24
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar Clientes"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(806, 405)
        Me.DataGridView2.TabIndex = 0
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.ComboBox2)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TBCodigo2)
        Me.GBConsulta.Controls.Add(Me.ICBBuscarCvendedor)
        Me.GBConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(399, 48)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 103)
        Me.GBConsulta.TabIndex = 25
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consultar Cliente"
        '
        'ICBBuscarCvendedor
        '
        Me.ICBBuscarCvendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscarCvendedor.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.ICBBuscarCvendedor.IconColor = System.Drawing.Color.Black
        Me.ICBBuscarCvendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscarCvendedor.IconSize = 42
        Me.ICBBuscarCvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBBuscarCvendedor.Location = New System.Drawing.Point(673, 39)
        Me.ICBBuscarCvendedor.Name = "ICBBuscarCvendedor"
        Me.ICBBuscarCvendedor.Size = New System.Drawing.Size(118, 41)
        Me.ICBBuscarCvendedor.TabIndex = 18
        Me.ICBBuscarCvendedor.Text = "       Buscar"
        Me.ICBBuscarCvendedor.UseVisualStyleBackColor = False
        '
        'LBCliente
        '
        Me.LBCliente.AutoSize = True
        Me.LBCliente.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBCliente.Location = New System.Drawing.Point(529, 9)
        Me.LBCliente.Name = "LBCliente"
        Me.LBCliente.Size = New System.Drawing.Size(160, 46)
        Me.LBCliente.TabIndex = 20
        Me.LBCliente.Text = "Clientes"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Todos", "Dni", "Nombre"})
        Me.ComboBox2.Location = New System.Drawing.Point(112, 45)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 30)
        Me.ComboBox2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buscar por:"
        '
        'TBCodigo2
        '
        Me.TBCodigo2.Location = New System.Drawing.Point(340, 45)
        Me.TBCodigo2.Name = "TBCodigo2"
        Me.TBCodigo2.Size = New System.Drawing.Size(313, 26)
        Me.TBCodigo2.TabIndex = 22
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
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBMantenimiento As GroupBox
    Friend WithEvents TBDirecciónCvendedor As TextBox
    Friend WithEvents TBDniCvendedor As TextBox
    Friend WithEvents LDirección As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBNombreCvendedor As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBApellidoCvendedor As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents TBTelefonoCvendedor As TextBox
    Friend WithEvents ICBNuevoCvendedor As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBAgregarCvendedor As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBModificarCvendedor As FontAwesome.Sharp.IconButton
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ICBBuscarCvendedor As FontAwesome.Sharp.IconButton
    Friend WithEvents LBCliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCodigoCvendedor As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents LBEmail As Label
    Friend WithEvents TBActivo As TextBox
    Friend WithEvents LBActivo As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBCodigo2 As TextBox
End Class
