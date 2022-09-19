<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IBInicio = New FontAwesome.Sharp.IconButton()
        Me.IBInventario = New FontAwesome.Sharp.IconButton()
        Me.IBProveedores = New FontAwesome.Sharp.IconButton()
        Me.IBClientes = New FontAwesome.Sharp.IconButton()
        Me.IBVenta = New FontAwesome.Sharp.IconButton()
        Me.IBSalir = New FontAwesome.Sharp.IconButton()
        Me.IBReportes = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(830, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IBInicio
        '
        Me.IBInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IBInicio.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IBInicio.IconColor = System.Drawing.Color.Black
        Me.IBInicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBInicio.Location = New System.Drawing.Point(0, 0)
        Me.IBInicio.Name = "IBInicio"
        Me.IBInicio.Size = New System.Drawing.Size(75, 23)
        Me.IBInicio.TabIndex = 1
        Me.IBInicio.Text = "Inicio"
        Me.IBInicio.UseVisualStyleBackColor = False
        '
        'IBInventario
        '
        Me.IBInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IBInventario.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IBInventario.IconColor = System.Drawing.Color.Black
        Me.IBInventario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBInventario.Location = New System.Drawing.Point(81, 1)
        Me.IBInventario.Name = "IBInventario"
        Me.IBInventario.Size = New System.Drawing.Size(75, 23)
        Me.IBInventario.TabIndex = 2
        Me.IBInventario.Text = "Productos"
        Me.IBInventario.UseVisualStyleBackColor = False
        '
        'IBProveedores
        '
        Me.IBProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IBProveedores.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IBProveedores.IconColor = System.Drawing.Color.Black
        Me.IBProveedores.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBProveedores.Location = New System.Drawing.Point(162, 1)
        Me.IBProveedores.Name = "IBProveedores"
        Me.IBProveedores.Size = New System.Drawing.Size(75, 23)
        Me.IBProveedores.TabIndex = 3
        Me.IBProveedores.Text = "Proveedores"
        Me.IBProveedores.UseVisualStyleBackColor = False
        '
        'IBClientes
        '
        Me.IBClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IBClientes.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IBClientes.IconColor = System.Drawing.Color.Black
        Me.IBClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBClientes.Location = New System.Drawing.Point(243, 0)
        Me.IBClientes.Name = "IBClientes"
        Me.IBClientes.Size = New System.Drawing.Size(75, 24)
        Me.IBClientes.TabIndex = 4
        Me.IBClientes.Text = "Clientes"
        Me.IBClientes.UseVisualStyleBackColor = False
        '
        'IBVenta
        '
        Me.IBVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IBVenta.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IBVenta.IconColor = System.Drawing.Color.Black
        Me.IBVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBVenta.Location = New System.Drawing.Point(324, 1)
        Me.IBVenta.Name = "IBVenta"
        Me.IBVenta.Size = New System.Drawing.Size(75, 23)
        Me.IBVenta.TabIndex = 5
        Me.IBVenta.Text = "Venta"
        Me.IBVenta.UseVisualStyleBackColor = False
        '
        'IBSalir
        '
        Me.IBSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IBSalir.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IBSalir.IconColor = System.Drawing.Color.Black
        Me.IBSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBSalir.Location = New System.Drawing.Point(755, 1)
        Me.IBSalir.Name = "IBSalir"
        Me.IBSalir.Size = New System.Drawing.Size(75, 23)
        Me.IBSalir.TabIndex = 6
        Me.IBSalir.Text = "Salir"
        Me.IBSalir.UseVisualStyleBackColor = False
        '
        'IBReportes
        '
        Me.IBReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IBReportes.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IBReportes.IconColor = System.Drawing.Color.Black
        Me.IBReportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IBReportes.Location = New System.Drawing.Point(674, 0)
        Me.IBReportes.Name = "IBReportes"
        Me.IBReportes.Size = New System.Drawing.Size(75, 23)
        Me.IBReportes.TabIndex = 7
        Me.IBReportes.Text = "Reportes"
        Me.IBReportes.UseVisualStyleBackColor = False
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(830, 394)
        Me.Controls.Add(Me.IBReportes)
        Me.Controls.Add(Me.IBSalir)
        Me.Controls.Add(Me.IBVenta)
        Me.Controls.Add(Me.IBClientes)
        Me.Controls.Add(Me.IBProveedores)
        Me.Controls.Add(Me.IBInventario)
        Me.Controls.Add(Me.IBInicio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IBInicio As FontAwesome.Sharp.IconButton
    Friend WithEvents IBInventario As FontAwesome.Sharp.IconButton
    Friend WithEvents IBProveedores As FontAwesome.Sharp.IconButton
    Friend WithEvents IBClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents IBVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents IBSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents IBReportes As FontAwesome.Sharp.IconButton
End Class
