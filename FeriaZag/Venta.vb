Public Class Venta
    Dim obj As New Conexion
    Dim obj2 As New DProducto
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.Conectar()
        ComboBox1.DataSource = obj2.ListarProductos()
        ComboBox1.ValueMember = "Codigo"
        ComboBox1.DisplayMember = "Producto"
    End Sub

End Class