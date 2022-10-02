Public Class ProductoVendedor

#Region "Cargar Producto Vendedor"
    Private Sub ProductoVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "Solo letras Nombre Producto Vendedor"
    Private Sub TBNombrePvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombrePvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo numeros Precio Vendedor"
    Private Sub TBPrecioPvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrecioPvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo numeros Stock Producto Vendedor"
    Private Sub TBStockPvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStockPvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo letras Nombre2 Producto Vendedor"
    Private Sub TBNombre2Pvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre2Pvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

End Class