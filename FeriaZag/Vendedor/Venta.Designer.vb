﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GBVenta = New System.Windows.Forms.GroupBox()
        Me.CBTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.BVImprimirVenta = New FontAwesome.Sharp.IconButton()
        Me.BVCobrarVenta = New FontAwesome.Sharp.IconButton()
        Me.BVCancelarVenta = New FontAwesome.Sharp.IconButton()
        Me.CBPago = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BVAgregarP = New FontAwesome.Sharp.IconButton()
        Me.CBCategoriaPventa = New System.Windows.Forms.ComboBox()
        Me.TBOPrecioPventa = New System.Windows.Forms.TextBox()
        Me.BVBuscarP = New FontAwesome.Sharp.IconButton()
        Me.TBCodigoPventa = New System.Windows.Forms.TextBox()
        Me.TBNombrePventa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BVBuscar = New FontAwesome.Sharp.IconButton()
        Me.TBDniCventa = New System.Windows.Forms.TextBox()
        Me.TBApellidoCventa = New System.Windows.Forms.TextBox()
        Me.TBNombreCventa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBConsulta.SuspendLayout()
        Me.GBVenta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.ComboBox2)
        Me.GBConsulta.Controls.Add(Me.Label4)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TextBox1)
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(194, -116)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(812, 115)
        Me.GBConsulta.TabIndex = 24
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Consulta"
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.Location = New System.Drawing.Point(659, 42)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(118, 41)
        Me.ICBBuscar.TabIndex = 18
        Me.ICBBuscar.Text = "Buscar"
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(430, 48)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(153, 30)
        Me.ComboBox2.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 26)
        Me.TextBox1.TabIndex = 18
        '
        'GBVenta
        '
        Me.GBVenta.Controls.Add(Me.CBTipoDocumento)
        Me.GBVenta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBVenta.Location = New System.Drawing.Point(15, 56)
        Me.GBVenta.Name = "GBVenta"
        Me.GBVenta.Size = New System.Drawing.Size(215, 56)
        Me.GBVenta.TabIndex = 25
        Me.GBVenta.TabStop = False
        Me.GBVenta.Text = "Tipo Comprobante"
        '
        'CBTipoDocumento
        '
        Me.CBTipoDocumento.FormattingEnabled = True
        Me.CBTipoDocumento.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C"})
        Me.CBTipoDocumento.Location = New System.Drawing.Point(11, 21)
        Me.CBTipoDocumento.Name = "CBTipoDocumento"
        Me.CBTipoDocumento.Size = New System.Drawing.Size(145, 30)
        Me.CBTipoDocumento.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1006, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 56)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha de Venta"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 26)
        Me.DateTimePicker1.TabIndex = 27
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.BVImprimirVenta)
        Me.GBListar.Controls.Add(Me.BVCobrarVenta)
        Me.GBListar.Controls.Add(Me.BVCancelarVenta)
        Me.GBListar.Controls.Add(Me.CBPago)
        Me.GBListar.Controls.Add(Me.Label13)
        Me.GBListar.Controls.Add(Me.TBTotalVenta)
        Me.GBListar.Controls.Add(Me.Label12)
        Me.GBListar.Controls.Add(Me.DataGridView2)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(12, 292)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(1242, 301)
        Me.GBListar.TabIndex = 27
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Articulos"
        '
        'BVImprimirVenta
        '
        Me.BVImprimirVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVImprimirVenta.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.BVImprimirVenta.IconColor = System.Drawing.Color.Black
        Me.BVImprimirVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVImprimirVenta.IconSize = 25
        Me.BVImprimirVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVImprimirVenta.Location = New System.Drawing.Point(1001, 240)
        Me.BVImprimirVenta.Name = "BVImprimirVenta"
        Me.BVImprimirVenta.Size = New System.Drawing.Size(225, 37)
        Me.BVImprimirVenta.TabIndex = 45
        Me.BVImprimirVenta.Text = "Imprimir"
        Me.BVImprimirVenta.UseVisualStyleBackColor = False
        '
        'BVCobrarVenta
        '
        Me.BVCobrarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVCobrarVenta.IconChar = FontAwesome.Sharp.IconChar.DollarSign
        Me.BVCobrarVenta.IconColor = System.Drawing.Color.Black
        Me.BVCobrarVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVCobrarVenta.IconSize = 25
        Me.BVCobrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVCobrarVenta.Location = New System.Drawing.Point(1122, 178)
        Me.BVCobrarVenta.Name = "BVCobrarVenta"
        Me.BVCobrarVenta.Size = New System.Drawing.Size(103, 37)
        Me.BVCobrarVenta.TabIndex = 44
        Me.BVCobrarVenta.Text = "Cobrar  "
        Me.BVCobrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVCobrarVenta.UseVisualStyleBackColor = False
        '
        'BVCancelarVenta
        '
        Me.BVCancelarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVCancelarVenta.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BVCancelarVenta.IconColor = System.Drawing.Color.Black
        Me.BVCancelarVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVCancelarVenta.IconSize = 25
        Me.BVCancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVCancelarVenta.Location = New System.Drawing.Point(1001, 178)
        Me.BVCancelarVenta.Name = "BVCancelarVenta"
        Me.BVCancelarVenta.Size = New System.Drawing.Size(103, 37)
        Me.BVCancelarVenta.TabIndex = 43
        Me.BVCancelarVenta.Text = "Cancelar"
        Me.BVCancelarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVCancelarVenta.UseVisualStyleBackColor = False
        '
        'CBPago
        '
        Me.CBPago.FormattingEnabled = True
        Me.CBPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta", "Tranferencia", "Mercado Pago"})
        Me.CBPago.Location = New System.Drawing.Point(1047, 111)
        Me.CBPago.Name = "CBPago"
        Me.CBPago.Size = New System.Drawing.Size(142, 30)
        Me.CBPago.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1064, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 22)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Modo de Pago:"
        '
        'TBTotalVenta
        '
        Me.TBTotalVenta.Location = New System.Drawing.Point(1047, 49)
        Me.TBTotalVenta.Name = "TBTotalVenta"
        Me.TBTotalVenta.Size = New System.Drawing.Size(142, 26)
        Me.TBTotalVenta.TabIndex = 40
        Me.TBTotalVenta.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1088, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 22)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "TOTAL:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Categoria, Me.Precio, Me.Cantidad, Me.SubTotal, Me.Quitar})
        Me.DataGridView2.GridColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(975, 276)
        Me.DataGridView2.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'Quitar
        '
        Me.Quitar.HeaderText = "Quitar"
        Me.Quitar.Name = "Quitar"
        Me.Quitar.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.BVAgregarP)
        Me.GroupBox2.Controls.Add(Me.CBCategoriaPventa)
        Me.GroupBox2.Controls.Add(Me.TBOPrecioPventa)
        Me.GroupBox2.Controls.Add(Me.BVBuscarP)
        Me.GroupBox2.Controls.Add(Me.TBCodigoPventa)
        Me.GroupBox2.Controls.Add(Me.TBNombrePventa)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(491, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 226)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(662, 125)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(67, 26)
        Me.NumericUpDown1.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(577, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 22)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Cantidad:"
        '
        'BVAgregarP
        '
        Me.BVAgregarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVAgregarP.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.BVAgregarP.IconColor = System.Drawing.Color.Black
        Me.BVAgregarP.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVAgregarP.IconSize = 25
        Me.BVAgregarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVAgregarP.Location = New System.Drawing.Point(353, 170)
        Me.BVAgregarP.Name = "BVAgregarP"
        Me.BVAgregarP.Size = New System.Drawing.Size(103, 37)
        Me.BVAgregarP.TabIndex = 40
        Me.BVAgregarP.Text = "Agregar"
        Me.BVAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVAgregarP.UseVisualStyleBackColor = False
        '
        'CBCategoriaPventa
        '
        Me.CBCategoriaPventa.FormattingEnabled = True
        Me.CBCategoriaPventa.Location = New System.Drawing.Point(121, 123)
        Me.CBCategoriaPventa.Name = "CBCategoriaPventa"
        Me.CBCategoriaPventa.Size = New System.Drawing.Size(188, 30)
        Me.CBCategoriaPventa.TabIndex = 39
        '
        'TBOPrecioPventa
        '
        Me.TBOPrecioPventa.Location = New System.Drawing.Point(396, 125)
        Me.TBOPrecioPventa.Name = "TBOPrecioPventa"
        Me.TBOPrecioPventa.Size = New System.Drawing.Size(142, 26)
        Me.TBOPrecioPventa.TabIndex = 38
        '
        'BVBuscarP
        '
        Me.BVBuscarP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVBuscarP.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BVBuscarP.IconColor = System.Drawing.Color.Black
        Me.BVBuscarP.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVBuscarP.IconSize = 25
        Me.BVBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVBuscarP.Location = New System.Drawing.Point(553, 31)
        Me.BVBuscarP.Name = "BVBuscarP"
        Me.BVBuscarP.Size = New System.Drawing.Size(94, 40)
        Me.BVBuscarP.TabIndex = 33
        Me.BVBuscarP.Text = "Buscar"
        Me.BVBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVBuscarP.UseVisualStyleBackColor = False
        '
        'TBCodigoPventa
        '
        Me.TBCodigoPventa.Location = New System.Drawing.Point(274, 37)
        Me.TBCodigoPventa.Name = "TBCodigoPventa"
        Me.TBCodigoPventa.Size = New System.Drawing.Size(228, 26)
        Me.TBCodigoPventa.TabIndex = 4
        '
        'TBNombrePventa
        '
        Me.TBNombrePventa.Location = New System.Drawing.Point(121, 83)
        Me.TBNombrePventa.Name = "TBNombrePventa"
        Me.TBNombrePventa.Size = New System.Drawing.Size(608, 26)
        Me.TBNombrePventa.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(329, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 22)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Precio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Código Producto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 22)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Categoría:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 22)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Nombre:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BVBuscar)
        Me.GroupBox5.Controls.Add(Me.TBDniCventa)
        Me.GroupBox5.Controls.Add(Me.TBApellidoCventa)
        Me.GroupBox5.Controls.Add(Me.TBNombreCventa)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(15, 118)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(438, 177)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cliente"
        '
        'BVBuscar
        '
        Me.BVBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BVBuscar.IconColor = System.Drawing.Color.Black
        Me.BVBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVBuscar.IconSize = 25
        Me.BVBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVBuscar.Location = New System.Drawing.Point(193, 136)
        Me.BVBuscar.Name = "BVBuscar"
        Me.BVBuscar.Size = New System.Drawing.Size(84, 36)
        Me.BVBuscar.TabIndex = 32
        Me.BVBuscar.Text = "Buscar"
        Me.BVBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVBuscar.UseVisualStyleBackColor = False
        '
        'TBDniCventa
        '
        Me.TBDniCventa.Location = New System.Drawing.Point(133, 104)
        Me.TBDniCventa.Name = "TBDniCventa"
        Me.TBDniCventa.Size = New System.Drawing.Size(290, 26)
        Me.TBDniCventa.TabIndex = 5
        '
        'TBApellidoCventa
        '
        Me.TBApellidoCventa.Location = New System.Drawing.Point(133, 67)
        Me.TBApellidoCventa.Name = "TBApellidoCventa"
        Me.TBApellidoCventa.Size = New System.Drawing.Size(290, 26)
        Me.TBApellidoCventa.TabIndex = 4
        '
        'TBNombreCventa
        '
        Me.TBNombreCventa.Location = New System.Drawing.Point(133, 35)
        Me.TBNombreCventa.Name = "TBNombreCventa"
        Me.TBNombreCventa.Size = New System.Drawing.Size(290, 26)
        Me.TBNombreCventa.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(270, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(150, 26)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "Consumidor Final"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(529, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 46)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Nueva Venta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 645)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBVenta)
        Me.Controls.Add(Me.GBConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Venta"
        Me.Text = "Producto2"
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.GBVenta.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GBListar.ResumeLayout(False)
        Me.GBListar.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GBVenta As GroupBox
    Friend WithEvents CBTipoDocumento As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBDniCventa As TextBox
    Friend WithEvents TBApellidoCventa As TextBox
    Friend WithEvents TBNombreCventa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BVBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BVBuscarP As FontAwesome.Sharp.IconButton
    Friend WithEvents TBCodigoPventa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBOPrecioPventa As TextBox
    Friend WithEvents TBNombrePventa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BVAgregarP As FontAwesome.Sharp.IconButton
    Friend WithEvents CBCategoriaPventa As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents CBPago As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBTotalVenta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Quitar As DataGridViewTextBoxColumn
    Friend WithEvents BVImprimirVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents BVCobrarVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents BVCancelarVenta As FontAwesome.Sharp.IconButton
End Class
