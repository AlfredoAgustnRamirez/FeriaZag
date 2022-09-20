Imports FeriaZag

Public Class Producto
    Dim obj As New Class1

    Private Sub listarproductos()
        Dim dtpro = obj.BuscarProductos("", "")
        DataGridView1.DataSource = dtpro
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        listarproductos()
    End Sub
End Class