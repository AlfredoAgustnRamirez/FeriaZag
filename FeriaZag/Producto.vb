Imports System.Data.SqlClient

Public Class Producto
    Dim obj As New DProducto

    Private Sub limpiar()
        TBCodigo.Text = ""
        TBNombre.Text = ""
        TBPrecio.Text = ""
        TBStock.Text = ""
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.Conectar()
        ComboBox1.DataSource = obj.ListarCategoria()
        ComboBox1.ValueMember = "IdCategoria"
        ComboBox1.DisplayMember = "Nombre"

        ComboBox2.DataSource = obj.ListarCategoria()
        ComboBox2.ValueMember = "IdCategoria"

        obj.llenarDataGridview(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TBCodigo.Text = DataGridView1.Item(0, e.RowIndex).Value
        TBNombre.Text = DataGridView1.Item(1, e.RowIndex).Value
        ComboBox1.SelectedValue = DataGridView1.Item(2, e.RowIndex).Value
        TBPrecio.Text = DataGridView1.Item(3, e.RowIndex).Value
        TBStock.Text = DataGridView1.Item(4, e.RowIndex).Value
    End Sub


    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        obj.EliminarProducto(TBCodigo.Text)
        obj.llenarDataGridview(DataGridView1)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        obj.ModificarProducto(TBCodigo.Text, TBNombre.Text, ComboBox1.SelectedValue, TBPrecio.Text, TBStock.Text)
        obj.llenarDataGridview(DataGridView1)

    End Sub

    Private Sub ICBAgregar_Click(sender As Object, e As EventArgs) Handles ICBAgregar.Click
        obj.RegistrarProducto(TBNombre.Text, ComboBox1.SelectedValue, TBPrecio.Text, TBStock.Text)
        obj.llenarDataGridview(DataGridView1)
        limpiar()

    End Sub

    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        obj.BuscarProductos(TBNombre.Text)
        obj.llenarDataGridview(DataGridView1)

    End Sub


End Class