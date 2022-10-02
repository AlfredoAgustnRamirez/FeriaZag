Public Class Usuarios

#Region "Carga de Usuarios"
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "Solo letras Nombre Usuario"
    Private Sub TBNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreUsuario.KeyPress
        SoloLetras(e)
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

#Region "Solo numeros Telefono Usuario"
    Private Sub TBTelefonoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoUsuario.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

End Class