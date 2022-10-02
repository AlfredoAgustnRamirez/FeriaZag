Public Class Venta

#Region "Variables"
    Dim obj As New DConexion
    Dim obj2 As New DProducto
#End Region

#Region "Carga de Ventas"
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.Conectar()
    End Sub
#End Region

#Region "Consumidor final"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TBNombreCventa.Enabled = False
        TBDniCventa.Enabled = False
        TBApellidoCventa.Enabled = False
        BVBuscar.Enabled = False
        CBTipoDocumento.Enabled = False
    End Sub
#End Region

#Region "Solo letras Nombre Cliente Venta"
    Private Sub TBNombreCventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCventa.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Apellido Cliente Venta"
    Private Sub TBApellidoCventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoCventa.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo numeros Dni Cliente Venta"
    Private Sub TBDniCventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniCventa.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo numeros codigo producto Venta"
    Private Sub TBCodigoPventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCodigoPventa.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo letras Nombre Producto Venta"
    Private Sub TBNombrePventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombrePventa.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo numeros Precio Producto Venta"
    Private Sub TBOPrecioPventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBOPrecioPventa.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo numeros total Producto Venta"
    Private Sub TBTotalVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTotalVenta.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

End Class