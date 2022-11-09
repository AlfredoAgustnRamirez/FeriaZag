Public Class Usuarios

    Dim usu As New DGerente

#Region "Carga de Usuarios"
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usu.llenarDataGridview(DGUsuario)
    End Sub
#End Region


#Region "Solo letras Apeliido Usuario"
    Private Sub TBApellidoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoUsuario.KeyPress
        SoloLetras(e)
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
            usu.RegistrarUsuario(TBNombreUsuario.Text, TBApellidoUsuario.Text, TBDniUsuario.Text, TBTelefonoUsuario.Text, TBDirecciónUsuario.Text, TBEmail.Text, CBPrefilUsuario.SelectedIndex, TBUsuario.Text, TBContraseña.Text)
            usu.llenarDataGridview(DGUsuario)
        End If
        limpiar()
    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuario.CellContentClick
        TBCodigoUsuario.Text = DGUsuario.Item(0, e.RowIndex).Value
        TBNombreUsuario.Text = DGUsuario.Item(1, e.RowIndex).Value
        TBApellidoUsuario.Text = DGUsuario.Item(2, e.RowIndex).Value
        TBDniUsuario.Text = DGUsuario.Item(3, e.RowIndex).Value
        TBTelefonoUsuario.Text = DGUsuario.Item(4, e.RowIndex).Value
        TBDirecciónUsuario.Text = DGUsuario.Item(5, e.RowIndex).Value
        TBEmail.Text = DGUsuario.Item(6, e.RowIndex).Value
        CBPrefilUsuario.Text = DGUsuario.Item(7, e.RowIndex).Value
        TBUsuario.Text = DGUsuario.Item(8, e.RowIndex).Value
        TBContraseña.Text = DGUsuario.Item(9, e.RowIndex).Value
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
        usu.ModificarUsuario(TBCodigoUsuario.Text, TBNombreUsuario.Text, TBApellidoUsuario.Text, TBDniUsuario.Text, TBTelefonoUsuario.Text, TBDirecciónUsuario.Text, TBEmail.Text, CBPrefilUsuario.SelectedIndex, TBUsuario.Text, TBContraseña.Text)
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

End Class