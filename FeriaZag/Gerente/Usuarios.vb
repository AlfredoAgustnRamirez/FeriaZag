Public Class Usuarios

    Dim usu As New DUsuario

#Region "Carga de Usuarios"
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usu.llenarDataGridview(DGUsuario)
    End Sub
#End Region

#Region "Solo numeros Dni Usuario"
    Private Sub TBDniUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniUsuario.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Limpiar"
    Private Sub limpiar()
        TBCodigoUsuario.Text = ""
        TBApellidoUsuario.Text = ""
        TBNombreUsuario.Text = ""
        TBDirecciónUsuario.Text = ""
        TBDniUsuario.Text = ""
        TBTelefonoUsuario.Text = ""
        TBEmail.Text = ""
        TBUsuario.Text = ""
        TBContraseña.Text = ""
        CBPrefilUsuario.Text = ""
    End Sub
#End Region

#Region "Solo numeros Telefono Usuario"
    Private Sub TBTelefonoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoUsuario.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Agregar Usuario"
    Private Sub ICBAgregar_Click(sender As Object, e As EventArgs) Handles ICBAgregar.Click
        If TBNombreUsuario.Text = "" Or TBApellidoUsuario.Text = "" Or TBDniUsuario.Text = "" Or TBTelefonoUsuario.Text = "" Or TBDirecciónUsuario.Text = "" Or TBEmail.Text = "" Or CBPrefilUsuario.Text = "" Or TBUsuario.Text = "" Or TBContraseña.Text = "" Then
            MsgBox("Error debe Completar todos los campos", vbCritical, "Error")
        Else
            Dim dtpro1 = usu.RegistrarUsuario(CBPrefilUsuario.SelectedIndex, TBNombreUsuario.Text, TBApellidoUsuario.Text, TBDniUsuario.Text, TBTelefonoUsuario.Text, TBDirecciónUsuario.Text, TBEmail.Text, TBUsuario.Text, TBContraseña.Text, TBActivo.Text)
            usu.llenarDataGridview(DGUsuario)
        End If
        limpiar()
    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuario.CellContentClick
        Dim FilaActual As Integer
        FilaActual = DGUsuario.CurrentRow.Index
        TBCodigoUsuario.Text = DGUsuario.Rows(FilaActual).Cells(0).Value
        CBPrefilUsuario.Text = DGUsuario.Rows(FilaActual).Cells(1).Value
        TBNombreUsuario.Text = DGUsuario.Rows(FilaActual).Cells(2).Value
        TBApellidoUsuario.Text = DGUsuario.Rows(FilaActual).Cells(3).Value
        TBDniUsuario.Text = DGUsuario.Rows(FilaActual).Cells(4).Value
        TBTelefonoUsuario.Text = DGUsuario.Rows(FilaActual).Cells(5).Value
        TBDirecciónUsuario.Text = DGUsuario.Rows(FilaActual).Cells(6).Value
        TBEmail.Text = DGUsuario.Rows(FilaActual).Cells(7).Value
        TBUsuario.Text = DGUsuario.Rows(FilaActual).Cells(8).Value
        TBContraseña.Text = DGUsuario.Rows(FilaActual).Cells(9).Value
        TBActivo.Text = DGUsuario.Rows(FilaActual).Cells(10).Value
        ICBAgregar.Enabled = False
        ICBModificar.Enabled = True
        ICBEliminar.Enabled = True
    End Sub
#End Region

#Region "Nuevo Usuario"
    Private Sub ICBNuevo_Click(sender As Object, e As EventArgs) Handles ICBNuevo.Click
        'limpia los campos para ingresar un nuevo producto y desabilita los botones correspondientes
        ICBAgregar.Enabled = True
        ICBEliminar.Enabled = False
        ICBModificar.Enabled = False
        limpiar()
    End Sub
#End Region

#Region "Modificar Usuario"
    Private Sub ICBModificar_Click(sender As Object, e As EventArgs) Handles ICBModificar.Click
        usu.ModificarUsuario(TBCodigoUsuario.Text, CBPrefilUsuario.SelectedIndex, TBNombreUsuario.Text, TBApellidoUsuario.Text, TBDniUsuario.Text, TBTelefonoUsuario.Text, TBDirecciónUsuario.Text, TBEmail.Text, TBUsuario.Text, TBContraseña.Text, TBActivo.Text)
        usu.llenarDataGridview(DGUsuario)
    End Sub
#End Region

#Region "Eliminar Usuario"
    Private Sub ICBEliminar_Click(sender As Object, e As EventArgs) Handles ICBEliminar.Click
        usu.EliminarUsuario(TBCodigoUsuario.Text)
        usu.llenarDataGridview(DGUsuario)
        limpiar()
    End Sub
#End Region

#Region "Buscar Usuario"
    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        If ComboBox2.Text = "Todos" Then
            usu.llenarDataGridview(DGUsuario)
        ElseIf ComboBox2.Text = "Dni" Then
            Dim dtpro1 = usu.BuscarUsuarioPorDni(TBCodigo2.Text)
            DGUsuario.DataSource = dtpro1
        ElseIf ComboBox2.Text = "Codigo" Then
            Dim dtpro1 = usu.BuscarUsuarioPorCodigo(TBCodigo2.Text)
            DGUsuario.DataSource = dtpro1
        Else
            Dim dtpro1 = usu.BuscarUsuario(TBCodigo2.Text)
            DGUsuario.DataSource = dtpro1
        End If
    End Sub
#End Region

End Class