<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteAdmin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.LbBackup = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GBListar = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BVImprimirVenta = New FontAwesome.Sharp.IconButton()
        Me.BVBuscar = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBListar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(250, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 56)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha Hasta"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 25)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(126, 26)
        Me.DateTimePicker2.TabIndex = 27
        Me.DateTimePicker2.Value = New Date(2022, 11, 14, 0, 0, 0, 0)
        '
        'LbBackup
        '
        Me.LbBackup.AutoSize = True
        Me.LbBackup.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbBackup.Location = New System.Drawing.Point(486, 9)
        Me.LbBackup.Name = "LbBackup"
        Me.LbBackup.Size = New System.Drawing.Size(338, 46)
        Me.LbBackup.TabIndex = 57
        Me.LbBackup.Text = "Reporte de Ventas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(69, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 56)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha Desde"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 26)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.Value = New Date(2022, 11, 14, 0, 0, 0, 0)
        '
        'GBListar
        '
        Me.GBListar.Controls.Add(Me.DataGridView1)
        Me.GBListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBListar.Location = New System.Drawing.Point(63, 168)
        Me.GBListar.Name = "GBListar"
        Me.GBListar.Size = New System.Drawing.Size(1109, 343)
        Me.GBListar.TabIndex = 60
        Me.GBListar.TabStop = False
        Me.GBListar.Text = "Listado de Ventas"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Size = New System.Drawing.Size(1103, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'BVImprimirVenta
        '
        Me.BVImprimirVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVImprimirVenta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVImprimirVenta.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.BVImprimirVenta.IconColor = System.Drawing.Color.Black
        Me.BVImprimirVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVImprimirVenta.IconSize = 25
        Me.BVImprimirVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVImprimirVenta.Location = New System.Drawing.Point(532, 532)
        Me.BVImprimirVenta.Name = "BVImprimirVenta"
        Me.BVImprimirVenta.Size = New System.Drawing.Size(225, 37)
        Me.BVImprimirVenta.TabIndex = 46
        Me.BVImprimirVenta.Text = "Imprimir Reporte"
        Me.BVImprimirVenta.UseVisualStyleBackColor = False
        '
        'BVBuscar
        '
        Me.BVBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BVBuscar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.BVBuscar.IconColor = System.Drawing.Color.Black
        Me.BVBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVBuscar.IconSize = 25
        Me.BVBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVBuscar.Location = New System.Drawing.Point(448, 121)
        Me.BVBuscar.Name = "BVBuscar"
        Me.BVBuscar.Size = New System.Drawing.Size(137, 36)
        Me.BVBuscar.TabIndex = 61
        Me.BVBuscar.Text = "Buscar"
        Me.BVBuscar.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButton2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Calendar
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 25
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(914, 124)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(103, 37)
        Me.IconButton2.TabIndex = 59
        Me.IconButton2.Text = "Hoy    "
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButton1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Calendar
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 25
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(1023, 125)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(149, 37)
        Me.IconButton1.TabIndex = 58
        Me.IconButton1.Text = "Ultimos 7 días"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ReporteAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.BVImprimirVenta)
        Me.Controls.Add(Me.BVBuscar)
        Me.Controls.Add(Me.GBListar)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LbBackup)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteAdmin"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GBListar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents LbBackup As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GBListar As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BVBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents BVImprimirVenta As FontAwesome.Sharp.IconButton
End Class
