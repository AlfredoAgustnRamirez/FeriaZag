<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proveedor
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
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBCodigoProveedor = New System.Windows.Forms.TextBox()
        Me.ICBEliminarProveedor = New FontAwesome.Sharp.IconButton()
        Me.ICBModificarProveedor = New FontAwesome.Sharp.IconButton()
        Me.ICBAgregarProveedor = New FontAwesome.Sharp.IconButton()
        Me.ICBNuevoProveedor = New FontAwesome.Sharp.IconButton()
        Me.TBObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBDirecciónProveedor = New System.Windows.Forms.TextBox()
        Me.TBCbuProveedor = New System.Windows.Forms.TextBox()
        Me.LDirección = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBNombreProveedor = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBApellidoProveedor = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.TBTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LBCliente = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TbBusqueda = New System.Windows.Forms.TextBox()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBConsulta.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.Label4)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigoProveedor)
        Me.GBMantenimiento.Controls.Add(Me.ICBEliminarProveedor)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificarProveedor)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregarProveedor)
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevoProveedor)
        Me.GBMantenimiento.Controls.Add(Me.TBObservaciones)
        Me.GBMantenimiento.Controls.Add(Me.Label1)
        Me.GBMantenimiento.Controls.Add(Me.TBDirecciónProveedor)
        Me.GBMantenimiento.Controls.Add(Me.TBCbuProveedor)
        Me.GBMantenimiento.Controls.Add(Me.LDirección)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.TBNombreProveedor)
        Me.GBMantenimiento.Controls.Add(Me.LApellido)
        Me.GBMantenimiento.Controls.Add(Me.TBApellidoProveedor)
        Me.GBMantenimiento.Controls.Add(Me.LDni)
        Me.GBMantenimiento.Controls.Add(Me.LTelefono)
        Me.GBMantenimiento.Controls.Add(Me.TBTelefonoProveedor)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(28, 55)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(374, 531)
        Me.GBMantenimiento.TabIndex = 22
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Mantenimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 22)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Codigo:"
        '
        'TBCodigoProveedor
        '
        Me.TBCodigoProveedor.Enabled = False
        Me.TBCodigoProveedor.Location = New System.Drawing.Point(173, 25)
        Me.TBCodigoProveedor.Name = "TBCodigoProveedor"
        Me.TBCodigoProveedor.Size = New System.Drawing.Size(153, 26)
        Me.TBCodigoProveedor.TabIndex = 28
        '
        'ICBEliminarProveedor
        '
        Me.ICBEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBEliminarProveedor.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.ICBEliminarProveedor.IconColor = System.Drawing.Color.Black
        Me.ICBEliminarProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBEliminarProveedor.IconSize = 40
        Me.ICBEliminarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBEliminarProveedor.Location = New System.Drawing.Point(197, 462)
        Me.ICBEliminarProveedor.Name = "ICBEliminarProveedor"
        Me.ICBEliminarProveedor.Size = New System.Drawing.Size(129, 46)
        Me.ICBEliminarProveedor.TabIndex = 26
        Me.ICBEliminarProveedor.Text = "Eliminar  "
        Me.ICBEliminarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBEliminarProveedor.UseVisualStyleBackColor = False
        '
        'ICBModificarProveedor
        '
        Me.ICBModificarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBModificarProveedor.IconChar = FontAwesome.Sharp.IconChar.CircleCheck
        Me.ICBModificarProveedor.IconColor = System.Drawing.Color.Black
        Me.ICBModificarProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBModificarProveedor.IconSize = 40
        Me.ICBModificarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBModificarProveedor.Location = New System.Drawing.Point(55, 462)
        Me.ICBModificarProveedor.Name = "ICBModificarProveedor"
        Me.ICBModificarProveedor.Size = New System.Drawing.Size(126, 46)
        Me.ICBModificarProveedor.TabIndex = 25
        Me.ICBModificarProveedor.Text = "Modificar "
        Me.ICBModificarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificarProveedor.UseVisualStyleBackColor = False
        '
        'ICBAgregarProveedor
        '
        Me.ICBAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregarProveedor.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregarProveedor.IconColor = System.Drawing.Color.Black
        Me.ICBAgregarProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregarProveedor.IconSize = 40
        Me.ICBAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregarProveedor.Location = New System.Drawing.Point(197, 385)
        Me.ICBAgregarProveedor.Name = "ICBAgregarProveedor"
        Me.ICBAgregarProveedor.Size = New System.Drawing.Size(129, 52)
        Me.ICBAgregarProveedor.TabIndex = 24
        Me.ICBAgregarProveedor.Text = "Guardar  "
        Me.ICBAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBAgregarProveedor.UseVisualStyleBackColor = False
        '
        'ICBNuevoProveedor
        '
        Me.ICBNuevoProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevoProveedor.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevoProveedor.IconColor = System.Drawing.Color.Black
        Me.ICBNuevoProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevoProveedor.IconSize = 40
        Me.ICBNuevoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevoProveedor.Location = New System.Drawing.Point(55, 385)
        Me.ICBNuevoProveedor.Name = "ICBNuevoProveedor"
        Me.ICBNuevoProveedor.Size = New System.Drawing.Size(126, 52)
        Me.ICBNuevoProveedor.TabIndex = 23
        Me.ICBNuevoProveedor.Text = "Nuevo  "
        Me.ICBNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevoProveedor.UseVisualStyleBackColor = False
        '
        'TBObservaciones
        '
        Me.TBObservaciones.Location = New System.Drawing.Point(173, 318)
        Me.TBObservaciones.Name = "TBObservaciones"
        Me.TBObservaciones.Size = New System.Drawing.Size(153, 26)
        Me.TBObservaciones.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Observaciones:"
        '
        'TBDirecciónProveedor
        '
        Me.TBDirecciónProveedor.Location = New System.Drawing.Point(173, 215)
        Me.TBDirecciónProveedor.Name = "TBDirecciónProveedor"
        Me.TBDirecciónProveedor.Size = New System.Drawing.Size(153, 26)
        Me.TBDirecciónProveedor.TabIndex = 19
        '
        'TBCbuProveedor
        '
        Me.TBCbuProveedor.Location = New System.Drawing.Point(173, 265)
        Me.TBCbuProveedor.Name = "TBCbuProveedor"
        Me.TBCbuProveedor.Size = New System.Drawing.Size(153, 26)
        Me.TBCbuProveedor.TabIndex = 18
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(45, 218)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(84, 22)
        Me.LDirección.TabIndex = 14
        Me.LDirección.Text = "Dirección:"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(41, 71)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(72, 22)
        Me.LNombre.TabIndex = 2
        Me.LNombre.Text = "Nombre:"
        '
        'TBNombreProveedor
        '
        Me.TBNombreProveedor.Location = New System.Drawing.Point(173, 68)
        Me.TBNombreProveedor.Name = "TBNombreProveedor"
        Me.TBNombreProveedor.Size = New System.Drawing.Size(153, 26)
        Me.TBNombreProveedor.TabIndex = 12
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(40, 117)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(74, 22)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido:"
        '
        'TBApellidoProveedor
        '
        Me.TBApellidoProveedor.Location = New System.Drawing.Point(173, 115)
        Me.TBApellidoProveedor.Name = "TBApellidoProveedor"
        Me.TBApellidoProveedor.Size = New System.Drawing.Size(153, 26)
        Me.TBApellidoProveedor.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(41, 267)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(83, 22)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "Cbu/Alias:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(41, 164)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(77, 22)
        Me.LTelefono.TabIndex = 1
        Me.LTelefono.Text = "Telefono:"
        '
        'TBTelefonoProveedor
        '
        Me.TBTelefonoProveedor.Location = New System.Drawing.Point(173, 161)
        Me.TBTelefonoProveedor.Name = "TBTelefonoProveedor"
        Me.TBTelefonoProveedor.Size = New System.Drawing.Size(153, 26)
        Me.TBTelefonoProveedor.TabIndex = 11
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.TbBusqueda)
        Me.GBConsulta.Controls.Add(Me.ComboBox2)
        Me.GBConsulta.Controls.Add(Me.IconButton1)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(433, 58)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(752, 102)
        Me.GBConsulta.TabIndex = 23
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consulta"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(609, 42)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(118, 46)
        Me.IconButton1.TabIndex = 20
        Me.IconButton1.Text = "Buscar  "
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.GBListar.Location = New System.Drawing.Point(433, 183)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(752, 403)
        Me.GBListar.TabIndex = 24
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(746, 381)
        Me.DataGridView1.TabIndex = 0
        '
        'LBCliente
        '
        Me.LBCliente.AutoSize = True
        Me.LBCliente.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBCliente.Location = New System.Drawing.Point(529, 9)
        Me.LBCliente.Name = "LBCliente"
        Me.LBCliente.Size = New System.Drawing.Size(236, 46)
        Me.LBCliente.TabIndex = 25
        Me.LBCliente.Text = "Proveedores"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Todos", "Nombre", "Cbu/Alias"})
        Me.ComboBox2.Location = New System.Drawing.Point(133, 51)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(169, 30)
        Me.ComboBox2.TabIndex = 23
        '
        'TbBusqueda
        '
        Me.TbBusqueda.Location = New System.Drawing.Point(308, 54)
        Me.TbBusqueda.Name = "TbBusqueda"
        Me.TbBusqueda.Size = New System.Drawing.Size(295, 26)
        Me.TbBusqueda.TabIndex = 24
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 749)
        Me.Controls.Add(Me.LBCliente)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Proveedor"
        Me.Text = "proveedor"
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
    Friend WithEvents TBDirecciónProveedor As TextBox
    Friend WithEvents TBCbuProveedor As TextBox
    Friend WithEvents LDirección As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBNombreProveedor As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBApellidoProveedor As TextBox
    Friend WithEvents LDni As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents TBTelefonoProveedor As TextBox
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBObservaciones As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ICBEliminarProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBModificarProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBAgregarProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBNuevoProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TBCodigoProveedor As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents LBCliente As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TbBusqueda As TextBox
End Class
