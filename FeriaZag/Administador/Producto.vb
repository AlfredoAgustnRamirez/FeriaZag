Imports System.Data.SqlClient
Public Class Producto

#Region "Variables"
    Dim obj As New DProducto
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

        ComboBox1.DataSource = obj.ListarCategoria()
        ComboBox1.ValueMember = "IdCategoria"
        ComboBox1.DisplayMember = "Categoria"

        obj.llenarDataGridview(DataGridView1)

    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim FilaActual As Integer
        FilaActual = DataGridView1.CurrentRow.Index
        TBCodigo.Text = DataGridView1.Rows(FilaActual).Cells(0).Value
        ComboBox1.Text = DataGridView1.Rows(FilaActual).Cells(1).Value
        TBNombre.Text = DataGridView1.Rows(FilaActual).Cells(2).Value
        TBPrecio.Text = DataGridView1.Rows(FilaActual).Cells(3).Value
        TBStock.Text = DataGridView1.Rows(FilaActual).Cells(4).Value
        TBActivo.Text = DataGridView1.Rows(FilaActual).Cells(5).Value
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
            obj.RegistrarProducto(TBNombre.Text, ComboBox1.SelectedValue, TBPrecio.Text, TBStock.Text, TBActivo.Text)
            obj.llenarDataGridview(DataGridView1)
        End If
        limpiar()
    End Sub
#End Region

#Region "Boton Nuevo"
    Private Sub ICBNuevo_Click(sender As Object, e As EventArgs) Handles ICBNuevo.Click
        'limpia los campos para ingresar un nuevo producto y desabilita los botones correspondientes
        ICBAgregar.Enabled = True
        ICBEliminar.Enabled = False
        ICBModificar.Enabled = False
        limpiar()
    End Sub
#End Region

#Region "Boton Modificar"
    Private Sub ICBModificar_Click(sender As Object, e As EventArgs) Handles ICBModificar.Click
        obj.ModificarProducto(TBCodigo.Text, ComboBox1.SelectedValue, TBNombre.Text, TBPrecio.Text, TBStock.Text, TBActivo.Text)
        obj.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Boton Eliminar"
    Private Sub ICBEliminar_Click(sender As Object, e As EventArgs) Handles ICBEliminar.Click
        obj.EliminarProducto(TBCodigo.Text)
        obj.llenarDataGridview(DataGridView1)
        limpiar()
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

#Region "Buscar Productos "
    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        If ComboBox2.Text = "Todos" Then
            obj.llenarDataGridview(DataGridView1)
        ElseIf ComboBox2.Text = "Categoria" Then
            Dim dtpro1 = obj.BuscarProductosPorCategoria(TBCodigo2.Text)
            DataGridView1.DataSource = dtpro1
        ElseIf ComboBox2.Text = "Codigo" Then
            Dim dtpro1 = obj.BuscarProductosPorCodigo(TBCodigo2.Text)
            DataGridView1.DataSource = dtpro1
        Else
            Dim dtpro1 = obj.BuscarProductosPorNombre(TBCodigo2.Text)
            DataGridView1.DataSource = dtpro1
        End If
    End Sub
#End Region

End Class