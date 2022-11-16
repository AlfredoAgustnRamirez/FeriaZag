Public Class Consulta

    Dim obj As New DProducto

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.llenarDataGridview(DGProductos)
    End Sub

#Region "Buscar Productos"
    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        If ComboBox2.Text = "Categoria" Then
            Dim dtpro1 = obj.BuscarProductosPorCategoria(TbBusqueda.Text)
            DGProductos.DataSource = dtpro1
        ElseIf ComboBox2.Text = "Codigo" Then
            Dim dtpro1 = obj.BuscarProductosPorCodigo(TbBusqueda.Text)
            DGProductos.DataSource = dtpro1
        ElseIf ComboBox2.Text = "Descripcion" Then
            Dim dtpro1 = obj.BuscarProductoPorNombre(TbBusqueda.Text)
            DGProductos.DataSource = dtpro1
        Else
            obj.llenarDataGridview(DGProductos)
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim i As Integer
        i = DGProductos.CurrentRow.Index
        cod = DGProductos.Rows(i).Cells(1).Value.ToString
    End Sub

    Private Sub DGProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductos.CellContentClick
        Dim fmr As New Venta()
        Dim FilaActual As Integer
        FilaActual = DGProductos.CurrentRow.Index
        fmr.TBCodigoPventa.Text = DGProductos.Rows(e.RowIndex).Cells(0).Value
    End Sub
#End Region


End Class