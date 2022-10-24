<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.lContraseña = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnIngresar = New FontAwesome.Sharp.IconButton()
        Me.ICBSalir = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(146, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inicio de Sesión"
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lUsuario.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lUsuario.Location = New System.Drawing.Point(158, 173)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(91, 27)
        Me.lUsuario.TabIndex = 2
        Me.lUsuario.Text = "Usuario:"
        '
        'lContraseña
        '
        Me.lContraseña.AutoSize = True
        Me.lContraseña.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContraseña.Location = New System.Drawing.Point(148, 261)
        Me.lContraseña.Name = "lContraseña"
        Me.lContraseña.Size = New System.Drawing.Size(125, 27)
        Me.lContraseña.TabIndex = 3
        Me.lContraseña.Text = "Contraseña:"
        '
        'tbUsuario
        '
        Me.tbUsuario.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUsuario.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(79, 206)
        Me.tbUsuario.Multiline = True
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(233, 20)
        Me.tbUsuario.TabIndex = 4
        Me.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbContraseña
        '
        Me.tbContraseña.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbContraseña.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContraseña.Location = New System.Drawing.Point(79, 294)
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.Size = New System.Drawing.Size(233, 22)
        Me.tbContraseña.TabIndex = 5
        Me.tbContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbContraseña.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.FeriaZag.My.Resources.Resources.key
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(117, 251)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.FeriaZag.My.Resources.Resources.user1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(127, 173)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 27)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(15, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 114)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnIngresar.IconColor = System.Drawing.Color.Black
        Me.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIngresar.IconSize = 32
        Me.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresar.Location = New System.Drawing.Point(207, 340)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(113, 48)
        Me.btnIngresar.TabIndex = 11
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'ICBSalir
        '
        Me.ICBSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ICBSalir.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICBSalir.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.ICBSalir.IconColor = System.Drawing.Color.Black
        Me.ICBSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBSalir.IconSize = 32
        Me.ICBSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBSalir.Location = New System.Drawing.Point(66, 340)
        Me.ICBSalir.Name = "ICBSalir"
        Me.ICBSalir.Size = New System.Drawing.Size(113, 48)
        Me.ICBSalir.TabIndex = 11
        Me.ICBSalir.Text = "Cancelar"
        Me.ICBSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBSalir.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AcceptButton = Me.btnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.ICBSalir
        Me.ClientSize = New System.Drawing.Size(398, 439)
        Me.Controls.Add(Me.ICBSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbContraseña)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lContraseña)
        Me.Controls.Add(Me.lUsuario)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lUsuario As Label
    Friend WithEvents lContraseña As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnIngresar As FontAwesome.Sharp.IconButton
    Friend WithEvents ICBSalir As FontAwesome.Sharp.IconButton
End Class
