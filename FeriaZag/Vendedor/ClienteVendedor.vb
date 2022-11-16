Public Class ClienteVendedor

#Region "Carga de Cliente Vendedor"
    Dim cli As New DCliente

    Private Sub ClienteVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cli.llenarDataGridview(DataGridView2)
    End Sub
#End Region

#Region "Limpiar"
    Private Sub limpiar()
        TBCodigoCvendedor.Text = ""
        TBApellidoCvendedor.Text = ""
        TBNombreCvendedor.Text = ""
        TBDirecciónCvendedor.Text = ""
        TBDniCvendedor.Text = ""
        TBTelefonoCvendedor.Text = ""
        TBEmail.Text = ""
    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        TBCodigoCvendedor.Text = DataGridView2.Item(0, e.RowIndex).Value
        TBNombreCvendedor.Text = DataGridView2.Item(1, e.RowIndex).Value
        TBApellidoCvendedor.Text = DataGridView2.Item(2, e.RowIndex).Value
        TBDniCvendedor.Text = DataGridView2.Item(3, e.RowIndex).Value
        TBTelefonoCvendedor.Text = DataGridView2.Item(4, e.RowIndex).Value
        TBEmail.Text = DataGridView2.Item(5, e.RowIndex).Value
        TBDirecciónCvendedor.Text = DataGridView2.Item(6, e.RowIndex).Value
        TBActivo.Text = DataGridView2.Item(7, e.RowIndex).Value
        ICBAgregarCvendedor.Enabled = False
        ICBModificarCvendedor.Enabled = True
    End Sub
#End Region

#Region "Solo letras Nombre Cliente Vendedor"
    Private Sub TBNombreCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Apellido Cliente Vendedor"
    Private Sub TBApellidoCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoCvendedor.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Dni Cliente Vendedor"
    Private Sub TBDniCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniCvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo letras Telefono Cliente Vendedor"
    Private Sub TBTelefonoCvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoCvendedor.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo letras Nombre2 Cliente Vendedor"
    Private Sub TBNombre2Cvendedor_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Dni2 Cliente Vendedor"
    Private Sub TBDni2Cvendedor_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub
#End Region

#Region "Agragr Cliente Vendedor"
    Private Sub ICBAgregarCvendedor_Click(sender As Object, e As EventArgs) Handles ICBAgregarCvendedor.Click
        If TBNombreCvendedor.Text = "" Or TBApellidoCvendedor.Text = "" Or TBDniCvendedor.Text = "" Or TBDirecciónCvendedor.Text = "" Or TBEmail.Text = "" Or TBTelefonoCvendedor.Text = "" Then
            MsgBox("Error debe Completar todos los campos", vbCritical, "Error")
        Else
            cli.RegistrarCliente(TBNombreCvendedor.Text, TBApellidoCvendedor.Text, TBDniCvendedor.Text, TBTelefonoCvendedor.Text, TBEmail.Text, TBDirecciónCvendedor.Text, TBActivo.Text)
            cli.llenarDataGridview(DataGridView2)
        End If
        limpiar()
    End Sub
#End Region

#Region "Nuevo Cliente Vendedor"
    Private Sub ICBNuevoCvendedor_Click(sender As Object, e As EventArgs) Handles ICBNuevoCvendedor.Click
        'limpia los campos para ingresar un nuevo producto y desabilita los botones correspondientes
        ICBAgregarCvendedor.Enabled = True
        ICBModificarCvendedor.Enabled = False
        limpiar()
    End Sub
#End Region

#Region "Modificar Cliente Vendedor"
    Private Sub ICBModificarCvendedor_Click(sender As Object, e As EventArgs) Handles ICBModificarCvendedor.Click
        cli.ModificarCliente(TBCodigoCvendedor.Text, TBNombreCvendedor.Text, TBApellidoCvendedor.Text, TBDniCvendedor.Text, TBTelefonoCvendedor.Text, TBEmail.Text, TBDirecciónCvendedor.Text, TBActivo.Text)
        cli.llenarDataGridview(DataGridView2)
    End Sub
#End Region

#Region "Buscar Clientes por Dni"
    Private Sub ICBBuscarCvendedor_Click(sender As Object, e As EventArgs) Handles ICBBuscarCvendedor.Click
        If ComboBox2.Text = "Todos" Then
            cli.llenarDataGridview(DataGridView2)
        ElseIf ComboBox2.Text = "Dni" Then
            Dim dtpro1 = cli.BuscarClientePorDni(TBCodigo2.Text)
            DataGridView2.DataSource = dtpro1
        Else
            Dim dtpro1 = cli.BuscarClientePorNombre(TBCodigo2.Text)
            DataGridView2.DataSource = dtpro1
        End If
    End Sub
#End Region

End Class