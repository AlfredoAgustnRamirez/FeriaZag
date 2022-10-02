Public Class proveedor

#Region "Solo Letras Nombre Proveedor"
    Private Sub TBNombreProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreProveedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Letras Apellido Proveedor"
    Private Sub TBApellidoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoProveedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Numeros Telefono Proveedor"
    Private Sub TBTelefonoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoProveedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo Letras Direccion Proveedor"
    Private Sub TBDirecciónProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDirecciónProveedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Letras Observaciones Proveedor"
    Private Sub TBObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBObservaciones.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Letras Nombre2 Proveedor"
    Private Sub TBNombre2Proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre2Proveedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Numeros Codigo Proveedor"
    Private Sub TBCodigo2Proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCodigo2Proveedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

End Class