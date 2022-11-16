Public Class Proveedor

#Region "Variables"
    Dim pro As New DProveedor
#End Region

#Region "Limpiar"
    Private Sub limpiar()
        TBCodigoProveedor.Text = ""
        TBNombreProveedor.Text = ""
        TBApellidoProveedor.Text = ""
        TBTelefonoProveedor.Text = ""
        TBDirecciónProveedor.Text = ""
        TBCbuProveedor.Text = ""
        TBObservaciones.Text = ""
    End Sub
#End Region

#Region "Solo Letras Nombre Proveedor"
    Private Sub TBNombreProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreProveedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Letras Apellido Proveedor"
    Private Sub TBApellidoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoProveedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Numeros Telefono Proveedor"
    Private Sub TBTelefonoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoProveedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo Letras Observaciones Proveedor"
    Private Sub TBObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBObservaciones.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Letras Nombre2 Proveedor"
    Private Sub TBNombre2Proveedor_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Numeros Codigo Proveedor"
    Private Sub TBCodigo2Proveedor_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub
#End Region

#Region "Load Proveedor"
    Private Sub proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pro.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Agregar Proveedor"
    Private Sub ICBAgregarProveedor_Click(sender As Object, e As EventArgs) Handles ICBAgregarProveedor.Click
        If TBNombreProveedor.Text = "" Or TBApellidoProveedor.Text = "" Or TBTelefonoProveedor.Text = "" Or TBDirecciónProveedor.Text = "" Or TBCbuProveedor.Text = "" Or TBObservaciones.Text = "" Then
            MsgBox("Error debe Completar todos los campos", vbCritical, "Error")
        Else
            pro.RegistrarProveedor(TBNombreProveedor.Text, TBApellidoProveedor.Text, TBTelefonoProveedor.Text, TBDirecciónProveedor.Text, TBCbuProveedor.Text, TBObservaciones.Text, TBActivo.Text)
            pro.llenarDataGridview(DataGridView1)
        End If
        limpiar()
    End Sub
#End Region

#Region "Boton Nuevo Proveedor"
    Private Sub ICBNuevoProveedor_Click(sender As Object, e As EventArgs) Handles ICBNuevoProveedor.Click
        'limpia los campos para ingresar un nuevo producto y desabilita los botones correspondientes
        ICBAgregarProveedor.Enabled = True
        ICBEliminarProveedor.Enabled = False
        ICBModificarProveedor.Enabled = False
        limpiar()
    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TBCodigoProveedor.Text = DataGridView1.Item(0, e.RowIndex).Value
        TBNombreProveedor.Text = DataGridView1.Item(1, e.RowIndex).Value
        TBApellidoProveedor.Text = DataGridView1.Item(2, e.RowIndex).Value
        TBTelefonoProveedor.Text = DataGridView1.Item(3, e.RowIndex).Value
        TBDirecciónProveedor.Text = DataGridView1.Item(4, e.RowIndex).Value
        TBCbuProveedor.Text = DataGridView1.Item(5, e.RowIndex).Value
        TBObservaciones.Text = DataGridView1.Item(6, e.RowIndex).Value
        TBActivo.Text = DataGridView1.Item(7, e.RowIndex).Value
        ICBAgregarProveedor.Enabled = False
        ICBModificarProveedor.Enabled = True
        ICBEliminarProveedor.Enabled = True
    End Sub
#End Region

#Region "Modificar Proveedor"
    Private Sub ICBModificarProveedor_Click(sender As Object, e As EventArgs) Handles ICBModificarProveedor.Click
        pro.ModificarProveedor(TBCodigoProveedor.Text, TBNombreProveedor.Text, TBApellidoProveedor.Text, TBTelefonoProveedor.Text, TBDirecciónProveedor.Text, TBCbuProveedor.Text, TBObservaciones.Text, TBActivo.Text)
        pro.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Buscar proveedor por nombre"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If ComboBox2.Text = "Nombre" Then
            Dim dtpro1 = pro.BuscarProveedorPorNombre(TbBusqueda.Text)
            DataGridView1.DataSource = dtpro1
        Else
            pro.llenarDataGridview(DataGridView1)
        End If
    End Sub
#End Region

#Region "Eliminar proveedor"
    Private Sub ICBEliminarProveedor_Click(sender As Object, e As EventArgs) Handles ICBEliminarProveedor.Click
        pro.EliminarProveedor(TBCodigoProveedor.Text)
        pro.llenarDataGridview(DataGridView1)
        limpiar()
    End Sub
#End Region

End Class