﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoVendedor
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBMantenimiento = New System.Windows.Forms.GroupBox()
        Me.TBStockPvendedor = New System.Windows.Forms.TextBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.CBcategoriaPvendedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCodigo = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TBNombrePvendedor = New System.Windows.Forms.TextBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPrecioPvendedor = New System.Windows.Forms.TextBox()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.CBCategoria2Pvendedor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNombre2Pvendedor = New System.Windows.Forms.TextBox()
        Me.LbProductos = New System.Windows.Forms.Label()
        Me.GBMantenimiento.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBMantenimiento
        '
        Me.GBMantenimiento.Controls.Add(Me.TBStockPvendedor)
        Me.GBMantenimiento.Controls.Add(Me.LStock)
        Me.GBMantenimiento.Controls.Add(Me.CBcategoriaPvendedor)
        Me.GBMantenimiento.Controls.Add(Me.Label2)
        Me.GBMantenimiento.Controls.Add(Me.TBCodigo)
        Me.GBMantenimiento.Controls.Add(Me.LNombre)
        Me.GBMantenimiento.Controls.Add(Me.TBNombrePvendedor)
        Me.GBMantenimiento.Controls.Add(Me.LCategoria)
        Me.GBMantenimiento.Controls.Add(Me.Label1)
        Me.GBMantenimiento.Controls.Add(Me.TBPrecioPvendedor)
        Me.GBMantenimiento.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMantenimiento.Location = New System.Drawing.Point(27, 69)
        Me.GBMantenimiento.Name = "GBMantenimiento"
        Me.GBMantenimiento.Size = New System.Drawing.Size(376, 451)
        Me.GBMantenimiento.TabIndex = 21
        Me.GBMantenimiento.TabStop = False
        Me.GBMantenimiento.Text = "Datos Productos"
        '
        'TBStockPvendedor
        '
        Me.TBStockPvendedor.Location = New System.Drawing.Point(119, 348)
        Me.TBStockPvendedor.Name = "TBStockPvendedor"
        Me.TBStockPvendedor.Size = New System.Drawing.Size(216, 26)
        Me.TBStockPvendedor.TabIndex = 18
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(26, 352)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(49, 22)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'CBcategoriaPvendedor
        '
        Me.CBcategoriaPvendedor.FormattingEnabled = True
        Me.CBcategoriaPvendedor.Location = New System.Drawing.Point(119, 212)
        Me.CBcategoriaPvendedor.Name = "CBcategoriaPvendedor"
        Me.CBcategoriaPvendedor.Size = New System.Drawing.Size(216, 30)
        Me.CBcategoriaPvendedor.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo:"
        '
        'TBCodigo
        '
        Me.TBCodigo.Enabled = False
        Me.TBCodigo.Location = New System.Drawing.Point(119, 88)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(216, 26)
        Me.TBCodigo.TabIndex = 12
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(26, 152)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(66, 22)
        Me.LNombre.TabIndex = 4
        Me.LNombre.Text = "Nombre"
        '
        'TBNombrePvendedor
        '
        Me.TBNombrePvendedor.Location = New System.Drawing.Point(119, 148)
        Me.TBNombrePvendedor.Name = "TBNombrePvendedor"
        Me.TBNombrePvendedor.Size = New System.Drawing.Size(216, 26)
        Me.TBNombrePvendedor.TabIndex = 9
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(27, 216)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(79, 22)
        Me.LCategoria.TabIndex = 3
        Me.LCategoria.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Precio"
        '
        'TBPrecioPvendedor
        '
        Me.TBPrecioPvendedor.Location = New System.Drawing.Point(119, 284)
        Me.TBPrecioPvendedor.Name = "TBPrecioPvendedor"
        Me.TBPrecioPvendedor.Size = New System.Drawing.Size(216, 26)
        Me.TBPrecioPvendedor.TabIndex = 11
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(418, 161)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(812, 362)
        Me.GBListar.TabIndex = 23
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listar Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.producto, Me.categoria, Me.precio, Me.Stock})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(806, 337)
        Me.DataGridView1.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'producto
        '
        Me.producto.HeaderText = "Producto"
        Me.producto.Name = "producto"
        Me.producto.ReadOnly = True
        '
        'categoria
        '
        Me.categoria.HeaderText = "Catrgoría"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.CBCategoria2Pvendedor)
        Me.GBConsulta.Controls.Add(Me.Label4)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TBNombre2Pvendedor)
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(418, 69)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 78)
        Me.GBConsulta.TabIndex = 24
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consultar Productos"
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.Location = New System.Drawing.Point(631, 19)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(118, 41)
        Me.ICBBuscar.TabIndex = 18
        Me.ICBBuscar.Text = "Buscar"
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'CBCategoria2Pvendedor
        '
        Me.CBCategoria2Pvendedor.FormattingEnabled = True
        Me.CBCategoria2Pvendedor.Location = New System.Drawing.Point(424, 25)
        Me.CBCategoria2Pvendedor.Name = "CBCategoria2Pvendedor"
        Me.CBCategoria2Pvendedor.Size = New System.Drawing.Size(153, 30)
        Me.CBCategoria2Pvendedor.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre"
        '
        'TBNombre2Pvendedor
        '
        Me.TBNombre2Pvendedor.Location = New System.Drawing.Point(107, 25)
        Me.TBNombre2Pvendedor.Name = "TBNombre2Pvendedor"
        Me.TBNombre2Pvendedor.Size = New System.Drawing.Size(153, 26)
        Me.TBNombre2Pvendedor.TabIndex = 18
        '
        'LbProductos
        '
        Me.LbProductos.AutoSize = True
        Me.LbProductos.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbProductos.Location = New System.Drawing.Point(529, 9)
        Me.LbProductos.Name = "LbProductos"
        Me.LbProductos.Size = New System.Drawing.Size(204, 46)
        Me.LbProductos.TabIndex = 19
        Me.LbProductos.Text = "Productos "
        '
        'ProductoVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.LbProductos)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GBMantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductoVendedor"
        Me.Text = "ProductoVendedor"
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
    Friend WithEvents TBStockPvendedor As TextBox
    Friend WithEvents LStock As Label
    Friend WithEvents CBcategoriaPvendedor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCodigo As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TBNombrePvendedor As TextBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBPrecioPvendedor As TextBox
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents CBCategoria2Pvendedor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNombre2Pvendedor As TextBox
    Friend WithEvents LbProductos As Label
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
End Class
