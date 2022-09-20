<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.pbFeriaZag = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.lContraseña = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        CType(Me.pbFeriaZag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbFeriaZag
        '
        Me.pbFeriaZag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFeriaZag.Image = Global.FeriaZag.My.Resources.Resources.feriaZag
        Me.pbFeriaZag.Location = New System.Drawing.Point(46, 55)
        Me.pbFeriaZag.Name = "pbFeriaZag"
        Me.pbFeriaZag.Size = New System.Drawing.Size(203, 209)
        Me.pbFeriaZag.TabIndex = 0
        Me.pbFeriaZag.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inicio de Session"
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuario.Location = New System.Drawing.Point(296, 127)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(67, 23)
        Me.lUsuario.TabIndex = 2
        Me.lUsuario.Text = "Usuario"
        '
        'lContraseña
        '
        Me.lContraseña.AutoSize = True
        Me.lContraseña.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContraseña.Location = New System.Drawing.Point(297, 196)
        Me.lContraseña.Name = "lContraseña"
        Me.lContraseña.Size = New System.Drawing.Size(95, 23)
        Me.lContraseña.TabIndex = 3
        Me.lContraseña.Text = "Contraseña"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(441, 131)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(154, 20)
        Me.tbUsuario.TabIndex = 4
        '
        'tbContraseña
        '
        Me.tbContraseña.Location = New System.Drawing.Point(441, 196)
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.Size = New System.Drawing.Size(154, 20)
        Me.tbContraseña.TabIndex = 5
        Me.tbContraseña.UseSystemPasswordChar = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(300, 268)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(92, 44)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(483, 268)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(93, 44)
        Me.btnIngresar.TabIndex = 7
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 362)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.tbContraseña)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lContraseña)
        Me.Controls.Add(Me.lUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbFeriaZag)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.pbFeriaZag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbFeriaZag As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lUsuario As Label
    Friend WithEvents lContraseña As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnIngresar As Button
End Class
