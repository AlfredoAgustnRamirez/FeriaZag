Public Class Venta

#Region "Variables"
    Dim obj As New DProducto
    Dim cli As New DCliente
    Dim ven As New DVenta
#End Region

#Region "Carga de Ventas"
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
#End Region

#Region "Limpiar"
    Private Sub limpiar()
        TBNombreCventa.Text = ""
        TBApellidoCventa.Text = ""
        TBDniCventa.Text = ""
        TBCodigoPventa.Text = ""
        TBNombreCventa.Text = ""
        CBCategoriaPventa.SelectedIndex = 0
        TBOPrecioPventa.Text = ""
    End Sub
#End Region

#Region "Consumidor final"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            TBNombreCventa.Enabled = False
            TBDniCventa.Enabled = False
            TBApellidoCventa.Enabled = False
            BVBuscar.Enabled = False
            CBTipoDocumento.Enabled = False
        ElseIf (CheckBox1.Checked = False) Then
            TBNombreCventa.Enabled = True
            TBDniCventa.Enabled = True
            TBApellidoCventa.Enabled = True
            BVBuscar.Enabled = True
            CBTipoDocumento.Enabled = True
        End If
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

#Region "Solo letras Nombre Producto Venta"
    Private Sub TBNombrePventa_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo numeros Precio Producto Venta"
    Private Sub TBOPrecioPventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBOPrecioPventa.KeyPress
        SoloNumeros(e)
    End Sub

#End Region

#Region "Boton Agregar"
    Private Sub BVAgregarP_Click(sender As Object, e As EventArgs) Handles BVAgregarP.Click
        DataGridView2.Rows.Add(TBCodigoPventa.Text, TBNombreProducto.Text, CBCategoriaPventa.Text,
        TBOPrecioPventa.Text, NumericUpDown1.Value, (TBOPrecioPventa.Text * NumericUpDown1.Value), "Quitar")
        TBTotalVenta.Text = " $ " & FormatNumber(obj.Sumar("SubTotal", DataGridView2), 2).ToString
    End Sub
#End Region

#Region "DataGridView contenido"
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
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
                    TBTotalVenta.Text = " $ " & FormatNumber(obj.Sumar("SubTotal", DataGridView2), 2).ToString
                End If
            End If
        End If
        DataGridView2.RowTemplate.Height = 35
    End Sub
#End Region

#Region "Buscar Productos por Codigo"
    Private Sub BVBuscarP_Click(sender As Object, e As EventArgs) Handles BVBuscarP.Click
        Dim dtpro2 = obj.BuscarProductosPorCodigo(TBCodigoPventa.Text)
        TBNombreProducto.Text = Convert.ToString(dtpro2.Rows(0)("Producto"))
        CBCategoriaPventa.Text = Convert.ToString(dtpro2.Rows(0)("Categoria"))
        TBOPrecioPventa.Text = Convert.ToString(dtpro2.Rows(0)("Precio"))
        NumericUpDown1.Value = Convert.ToString(dtpro2.Rows(0)("Stock"))
    End Sub
#End Region

#Region "Buscar Clientes por Dni"
    Private Sub BVBuscar_Click(sender As Object, e As EventArgs) Handles BVBuscar.Click
        Dim dtpro1 = cli.BuscarClientePorDni(TBDniCventa.Text)
        TBNombreCventa.Text = Convert.ToString(dtpro1.Rows(0)("Nombre"))
        TBApellidoCventa.Text = Convert.ToString(dtpro1.Rows(0)("Apellido"))
        TBCodigo.Text = Convert.ToString(dtpro1.Rows(0)("Id_Cliente"))
    End Sub
#End Region

#Region "Boton Cobrar"
    Private Sub BVCobrarVenta_Click(sender As Object, e As EventArgs) Handles BVCobrarVenta.Click
        Dim fechaActual As Date = Date.Now
        Dim precio As Decimal
        Dim cantidad As Integer
        Dim idcabecera As Integer
        ven.RegistrarVenta(TBCodigo.Text, fechaActual, TBTotalVenta.Text)
        idcabecera = ven.ObtenerIdCabecera()
        Dim dtpro2 = obj.BuscarProductosPorCodigo(TBCodigoPventa.Text)
        TBCodigo.Text = dtpro2.Rows(0).Item("Codigo")
        precio = Convert.ToDecimal(dtpro2.Rows(0)("Precio"))
        cantidad = Convert.ToInt32(dtpro2.Rows(0)("Stock"))
        ven.RegistrarVentaDetalle(TBCodigo.Text, idcabecera, precio, cantidad, TBTotalVenta.Text)
    End Sub
#End Region

End Class