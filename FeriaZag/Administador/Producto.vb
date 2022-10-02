Imports System.Data.SqlClient

Public Class Producto

#Region "Variables"
    Dim obj As New DProducto
    Dim obj3 As New DProducto
#End Region

#Region "Limpiar"
    Private Sub limpiar()
        TBCodigo.Text = ""
        TBNombre.Text = ""
        TBPrecio.Text = ""
        TBStock.Text = ""
        ComboBox1.SelectedIndex = 0
    End Sub
#End Region

#Region "Carga de Producto"
    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.Conectar()

        ComboBox1.DataSource = obj.ListarCategoria()
        ComboBox1.ValueMember = "IdCategoria"
        ComboBox1.DisplayMember = "Categoria"

        ComboBox2.DataSource = obj.ListarCategoria()
        ComboBox2.ValueMember = "IdCategoria"
        ComboBox2.DisplayMember = "Categoria"

        obj.llenarDataGridview(DataGridView1)
        obj.Desconectar()
    End Sub
#End Region

#Region "DataGridView Contenido"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TBCodigo.Text = DataGridView1.Item(0, e.RowIndex).Value
        ComboBox1.Text = DataGridView1.Item(1, e.RowIndex).Value
        TBNombre.Text = DataGridView1.Item(2, e.RowIndex).Value
        TBPrecio.Text = DataGridView1.Item(3, e.RowIndex).Value
        TBStock.Text = DataGridView1.Item(4, e.RowIndex).Value
        ICBAgregar.Enabled = False
        ICBModificar.Enabled = True
        ICBEliminar.Enabled = True
    End Sub
#End Region

#Region "Boton Agregar"
    Private Sub ICBAgregar_Click(sender As Object, e As EventArgs) Handles ICBAgregar.Click
        If TBNombre.Text = "" Or TBPrecio.Text = "" Or TBStock.Text = "" Then
            MsgBox("Error debe Completar todos los campos", vbCritical, "Error")
        Else
            obj.RegistrarProducto(TBNombre.Text, ComboBox1.SelectedValue, TBPrecio.Text, TBStock.Text)
            obj.llenarDataGridview(DataGridView1)
        End If
        limpiar()
    End Sub
#End Region

#Region "Boton Agregar"
    Private Sub ICBNuevo_Click(sender As Object, e As EventArgs) Handles ICBNuevo.Click
        ICBAgregar.Enabled = True
        ICBEliminar.Enabled = False
        ICBModificar.Enabled = False
        limpiar()
    End Sub
#End Region

#Region "Boton Modificar"
    Private Sub ICBModificar_Click(sender As Object, e As EventArgs) Handles ICBModificar.Click
        obj.ModificarProducto(TBCodigo.Text, ComboBox1.SelectedValue, TBNombre.Text, TBPrecio.Text, TBStock.Text)
        obj.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Boton Eliminar"
    Private Sub ICBEliminar_Click(sender As Object, e As EventArgs) Handles ICBEliminar.Click
        obj.EliminarProducto(TBCodigo.Text)
        obj.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "TextBox Nombre Solo Letras"
    Private Sub TBNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "TextBox Precio Solo Numeros"
    Private Sub TBPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPrecio.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "TextBox Stock Solo Numeros"
    Private Sub TBStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStock.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "TextBox Nombre2 Solo Letras"
    Private Sub TBNombre2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre2.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Buscar Producato por TextBox"
    Private Sub TBNombre2_TextChanged(sender As Object, e As EventArgs) Handles TBNombre2.TextChanged
        Dim dtpro = obj.BuscarProductos(TBNombre2.Text)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

End Class