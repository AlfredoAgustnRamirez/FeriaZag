<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Me.LbBackup = New System.Windows.Forms.Label()
        Me.GBConsulta = New System.Windows.Forms.GroupBox()
        Me.ICBBuscar = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBDirectorio = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNombreBackup = New System.Windows.Forms.TextBox()
        Me.ICBBase = New FontAwesome.Sharp.IconButton()
        Me.GBConsulta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbBackup
        '
        Me.LbBackup.AutoSize = True
        Me.LbBackup.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbBackup.Location = New System.Drawing.Point(529, 9)
        Me.LbBackup.Name = "LbBackup"
        Me.LbBackup.Size = New System.Drawing.Size(298, 46)
        Me.LbBackup.TabIndex = 19
        Me.LbBackup.Text = "Realizar Backup"
        '
        'GBConsulta
        '
        Me.GBConsulta.Controls.Add(Me.ICBBuscar)
        Me.GBConsulta.Controls.Add(Me.Label3)
        Me.GBConsulta.Controls.Add(Me.TBDirectorio)
        Me.GBConsulta.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBConsulta.Location = New System.Drawing.Point(251, 146)
        Me.GBConsulta.Name = "GBConsulta"
        Me.GBConsulta.Size = New System.Drawing.Size(811, 83)
        Me.GBConsulta.TabIndex = 22
        Me.GBConsulta.TabStop = False
        Me.GBConsulta.Text = "Directorio"
        '
        'ICBBuscar
        '
        Me.ICBBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBuscar.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.ICBBuscar.IconColor = System.Drawing.Color.Black
        Me.ICBBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBBuscar.Location = New System.Drawing.Point(650, 19)
        Me.ICBBuscar.Name = "ICBBuscar"
        Me.ICBBuscar.Size = New System.Drawing.Size(133, 49)
        Me.ICBBuscar.TabIndex = 18
        Me.ICBBuscar.Text = "Examinar"
        Me.ICBBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 22)
        Me.Label3.TabIndex = 18
        '
        'TBDirectorio
        '
        Me.TBDirectorio.Location = New System.Drawing.Point(33, 34)
        Me.TBDirectorio.Name = "TBDirectorio"
        Me.TBDirectorio.Size = New System.Drawing.Size(518, 26)
        Me.TBDirectorio.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBNombreBackup)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(440, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 71)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre del Backup"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 18
        '
        'TBNombreBackup
        '
        Me.TBNombreBackup.Location = New System.Drawing.Point(6, 25)
        Me.TBNombreBackup.Name = "TBNombreBackup"
        Me.TBNombreBackup.Size = New System.Drawing.Size(449, 26)
        Me.TBNombreBackup.TabIndex = 18
        '
        'ICBBase
        '
        Me.ICBBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ICBBase.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICBBase.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.ICBBase.IconColor = System.Drawing.Color.Black
        Me.ICBBase.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ICBBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ICBBase.Location = New System.Drawing.Point(537, 368)
        Me.ICBBase.Name = "ICBBase"
        Me.ICBBase.Size = New System.Drawing.Size(159, 62)
        Me.ICBBase.TabIndex = 19
        Me.ICBBase.Text = "Crear Backup"
        Me.ICBBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ICBBase.UseVisualStyleBackColor = False
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1364, 681)
        Me.Controls.Add(Me.ICBBase)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBConsulta)
        Me.Controls.Add(Me.LbBackup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Backup"
        Me.Text = "Backup"
        Me.GBConsulta.ResumeLayout(False)
        Me.GBConsulta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbBackup As Label
    Friend WithEvents GBConsulta As GroupBox
    Friend WithEvents ICBBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TBDirectorio As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBNombreBackup As TextBox
    Friend WithEvents ICBBase As FontAwesome.Sharp.IconButton
End Class
