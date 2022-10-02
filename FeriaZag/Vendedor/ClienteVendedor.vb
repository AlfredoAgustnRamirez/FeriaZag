Public Class ClienteVendedor
#Region "Carga de Cliente Vendedor"
    Private Sub ClienteVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "Solo letras Nombre Cliente Vendedor"
    Private Sub TBNombreCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Apellido Cliente Vendedor"
    Private Sub TBApellidoCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoCvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Dni Cliente Vendedor"
    Private Sub TBDniCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniCvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo letras Telefono Cliente Vendedor"
    Private Sub TBTelefonoCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoCvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo letras Nombre2 Cliente Vendedor"
    Private Sub TBNombre2Cvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre2Cvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Dni2 Cliente Vendedor"
    Private Sub TBDni2Cvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDni2Cvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

End Class