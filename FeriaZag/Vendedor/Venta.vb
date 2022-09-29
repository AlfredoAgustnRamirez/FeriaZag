Public Class Venta
    Dim obj As New DConexion
    Dim obj2 As New DProducto
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.Conectar()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Codigo.DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
        Producto.DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)

        Dim respuesta As MsgBoxResult

        Dim cell As DataGridViewButtonCell = TryCast(DataGridView2.CurrentCell, DataGridViewButtonCell)
        Dim bc As DataGridViewButtonColumn = TryCast(DataGridView2.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid

        Dim FilaSeleccionada As Integer
        FilaSeleccionada = DataGridView2.CurrentRow.Index
        If bc IsNot Nothing Then

            If DataGridView2.Rows.Count > 0 Then 'Comprobar que tenga filas
                respuesta = MsgBox("Seguro que desea eliminar el registro?", 32 + 4, "Eliminar")
                If respuesta = 6 Then
                    DataGridView2.Rows.Remove(DataGridView2.Rows(FilaSeleccionada))
                End If
            End If
        End If

        DataGridView2.RowTemplate.Height = 35
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub GBVenta_Enter(sender As Object, e As EventArgs) Handles GBVenta.Enter

    End Sub


End Class