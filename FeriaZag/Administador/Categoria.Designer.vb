<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria
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
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.ICBNuevo = New FontAwesome.Sharp.IconButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ICBAgregar = New FontAwesome.Sharp.IconButton()
        Me.ICBEliminar = New FontAwesome.Sharp.IconButton()
        Me.ICBModificar = New FontAwesome.Sharp.IconButton()
        Me.TBCodigo = New System.Windows.Forms.TextBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBCategoria = New System.Windows.Forms.Label()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.ICBNuevo)
        Me.GBMantenimiento.Controls.Add(Me.ComboBox1)
        Me.GBMantenimiento.Controls.Add(Me.Label2)
        Me.GBMantenimiento.Controls.Add(Me.ICBAgregar)
        Me.GBMantenimiento.Controls.Add(Me.ICBEliminar)
        Me.GBMantenimiento.Controls.Add(Me.ICBModificar)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigo)
        Me.GBMantenimiento.Controls.Add(Me.LCategoria)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(18, 71)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 486)
        Me.GBMantenimiento.TabIndex = 21
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Datos Categoria"
        '
        'ICBNuevo
        '
        Me.ICBNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBNuevo.IconChar = FontAwesome.Sharp.IconChar.ExternalLink
        Me.ICBNuevo.IconColor = System.Drawing.Color.Black
        Me.ICBNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBNuevo.IconSize = 40
        Me.ICBNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBNuevo.Location = New System.Drawing.Point(32, 235)
        Me.ICBNuevo.Name = "ICBNuevo"
        Me.ICBNuevo.Size = New System.Drawing.Size(126, 49)
        Me.ICBNuevo.TabIndex = 19
        Me.ICBNuevo.Text = "Nuevo   "
        Me.ICBNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBNuevo.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 30)
        Me.ComboBox1.TabIndex = 13
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
        'ICBAgregar
        '
        Me.ICBAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.ICBAgregar.IconColor = System.Drawing.Color.Black
        Me.ICBAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBAgregar.IconSize = 40
        Me.ICBAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBAgregar.Location = New System.Drawing.Point(207, 235)
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
        Me.ICBEliminar.Location = New System.Drawing.Point(207, 338)
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
        Me.ICBModificar.Location = New System.Drawing.Point(32, 338)
        Me.ICBModificar.Name = "ICBModificar"
        Me.ICBModificar.Size = New System.Drawing.Size(126, 50)
        Me.ICBModificar.TabIndex = 15
        Me.ICBModificar.Text = "Modificar "
        Me.ICBModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBModificar.UseVisualStyleBackColor = False
        '
        'TBCodigo
        '
        Me.TBCodigo.Enabled = False
        Me.TBCodigo.Location = New System.Drawing.Point(120, 52)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(216, 26)
        Me.TBCodigo.TabIndex = 12
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(28, 122)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(79, 22)
        Me.LCategoria.TabIndex = 3
        Me.LCategoria.Text = "Categoria"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreCat, Me.Cantidad})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 343)
        Me.DataGridView1.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'NombreCat
        '
        Me.NombreCat.HeaderText = "Categoría"
        Me.NombreCat.Name = "NombreCat"
        Me.NombreCat.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.ComboBox2)
        Me.GBConsulta.Controls.Add(Me.Label4)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TextBox1)
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(410, 44)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(153, 30)
        Me.ComboBox2.TabIndex = 18
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 26)
        Me.TextBox1.TabIndex = 18
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
    Friend WithEvents ICBNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ICBAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBModificar As FontAwesome.Sharp.IconButton
    Friend WithEvents TBCodigo As TextBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LBCategoria As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents NombreCat As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
End Class
