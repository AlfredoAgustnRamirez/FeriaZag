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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBPerfil = New System.Windows.Forms.Label()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbBackup
        '
        Me.LbBackup.AutoSize = True
        Me.LbBackup.Font = New System.Drawing.Font("Trebuchet MS", 45.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBackup.Location = New System.Drawing.Point(285, 9)
        Me.LbBackup.Name = "LbBackup"
        Me.LbBackup.Size = New System.Drawing.Size(614, 76)
        Me.LbBackup.TabIndex = 20
        Me.LbBackup.Text = "Usuarios Registrados"
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(406, 103)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(842, 570)
        Me.GBListar.TabIndex = 23
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar Usuarios"
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
        Me.DataGridView1.Size = New System.Drawing.Size(836, 545)
        Me.DataGridView1.TabIndex = 0
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.LBPerfil)
        Me.GBMantenimiento.Controls.Add(Me.TextBox1)
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
        Me.GBMantenimiento.Location = New System.Drawing.Point(12, 103)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 570)
        Me.GBMantenimiento.TabIndex = 22
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Datos Usuarios"
        '
        'TBDirección
        '
        Me.TBDirección.Location = New System.Drawing.Point(151, 281)
        Me.TBDirección.Name = "TBDirección"
        Me.TBDirección.Size = New System.Drawing.Size(181, 26)
        Me.TBDirección.TabIndex = 19
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(151, 160)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(181, 26)
        Me.TBDni.TabIndex = 18
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(55, 286)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(84, 22)
        Me.LDirección.TabIndex = 14
        Me.LDirección.Text = "Dirección:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(51, 41)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(72, 22)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'TBCodigo
        '
        Me.TBCodigo.Location = New System.Drawing.Point(151, 37)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(181, 26)
        Me.TBCodigo.TabIndex = 12
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(50, 101)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(74, 22)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido:"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(151, 97)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(181, 26)
        Me.TBNombre.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(51, 164)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 22)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "DNI:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(51, 226)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 22)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "Telefono:"
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(151, 221)
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
        Me.ICBNuevo.Location = New System.Drawing.Point(59, 393)
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
        Me.ICBAgregar.Location = New System.Drawing.Point(209, 393)
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
        Me.ICBEliminar.Location = New System.Drawing.Point(209, 477)
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
        Me.ICBModificar.Location = New System.Drawing.Point(59, 477)
        Me.ICBModificar.Name = "ICBModificar"
        Me.ICBModificar.Size = New System.Drawing.Size(126, 50)
        Me.ICBModificar.TabIndex = 20
        Me.ICBModificar.Text = "Modificar"
        Me.ICBModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 341)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 26)
        Me.TextBox1.TabIndex = 24
        '
        'LBPerfil
        '
        Me.LBPerfil.AutoSize = True
        Me.LBPerfil.Location = New System.Drawing.Point(55, 341)
        Me.LBPerfil.Name = "LBPerfil"
        Me.LBPerfil.Size = New System.Drawing.Size(54, 22)
        Me.LBPerfil.TabIndex = 25
        Me.LBPerfil.Text = "Perfil:"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.LbBackup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.GBListar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBMantenimiento.ResumeLayout(False)
        Me.GBMantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbBackup As Label
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents LBPerfil As Label
    Friend WithEvents TextBox1 As TextBox
End Class
