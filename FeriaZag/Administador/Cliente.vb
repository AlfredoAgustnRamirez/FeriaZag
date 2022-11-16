Public Class Cliente

#Region "Variables"
    Dim cli As New DCliente
#End Region

#Region "Limpiar"
    Private Sub limpiar()
        TBCodigoCliente.Text = ""
        TBApellidoCliente.Text = ""
        TBNombreCliente.Text = ""
        TBDirecciónCliente.Text = ""
        TBDniCliente.Text = ""
        TBTelefonoCliente.Text = ""
        TBEmail.Text = ""
        TBActivo.Text = ""
    End Sub
#End Region

#Region "Solo Letras Nombre Cliente"
    Private Sub TBNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCliente.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Letras Apellido Cliente"
    Private Sub TBApellidoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoCliente.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Numeros Dni Cliente"
    Private Sub TBDniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDniCliente.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo Numeros Telefono Cliente"
    Private Sub TBTelefonoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelefonoCliente.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Solo Letras Nombre2 Cliente"
    Private Sub TBNombre2Cliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Numeros Dni2 Cliente"
    Private Sub TBDni2Cliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub
#End Region

#Region "Carga de Cliente"
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cli.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "DataGridView Contenido por fila"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim FilaActual As Integer
        FilaActual = DataGridView1.CurrentRow.Index
        TBCodigoCliente.Text = DataGridView1.Rows(FilaActual).Cells(0).Value
        TBNombreCliente.Text = DataGridView1.Rows(FilaActual).Cells(1).Value
        TBApellidoCliente.Text = DataGridView1.Rows(FilaActual).Cells(2).Value
        TBDniCliente.Text = DataGridView1.Rows(FilaActual).Cells(3).Value
        TBTelefonoCliente.Text = DataGridView1.Rows(FilaActual).Cells(4).Value
        TBEmail.Text = DataGridView1.Rows(FilaActual).Cells(5).Value
        TBDirecciónCliente.Text = DataGridView1.Rows(FilaActual).Cells(5).Value
        TBActivo.Text = DataGridView1.Rows(FilaActual).Cells(6).Value
        ICBAgregarCliente.Enabled = False
        ICBModificarCliente.Enabled = True
        ICBEliminarCliente.Enabled = True
    End Sub
#End Region

#Region "Agregar Cliente"
    Private Sub ICBAgregarCliente_Click(sender As Object, e As EventArgs) Handles ICBAgregarCliente.Click
        If TBNombreCliente.Text = "" Or TBApellidoCliente.Text = "" Or TBDniCliente.Text = "" Or TBDirecciónCliente.Text = "" Or TBEmail.Text = "" Or TBTelefonoCliente.Text = "" Or TBActivo.Text = "" Then
            MsgBox("Error debe Completar todos los campos", vbCritical, "Error")
        Else
            cli.RegistrarCliente(TBNombreCliente.Text, TBApellidoCliente.Text, TBDniCliente.Text, TBTelefonoCliente.Text, TBEmail.Text, TBDirecciónCliente.Text, TBActivo.Text)
            cli.llenarDataGridview(DataGridView1)
        End If
        limpiar()
    End Sub
#End Region

#Region "Eliminar Cliente"
    Private Sub ICBEliminarCliente_Click(sender As Object, e As EventArgs) Handles ICBEliminarCliente.Click
        cli.EliminarCliente(TBCodigoCliente.Text)
        cli.llenarDataGridview(DataGridView1)
        limpiar()
    End Sub
#End Region

#Region "Modificar Cliente"
    Private Sub ICBModificarCliente_Click(sender As Object, e As EventArgs) Handles ICBModificarCliente.Click
        cli.ModificarCliente(TBCodigoCliente.Text, TBNombreCliente.Text, TBApellidoCliente.Text, TBDniCliente.Text, TBTelefonoCliente.Text, TBEmail.Text, TBDirecciónCliente.Text, TBActivo.Text)
        cli.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Nuevo Cliente"
    Private Sub ICBNuevoCliente_Click(sender As Object, e As EventArgs) Handles ICBNuevoCliente.Click
        'limpia los campos para ingresar un nuevo producto y desabilita los botones correspondientes
        ICBAgregarCliente.Enabled = True
        ICBEliminarCliente.Enabled = False
        ICBModificarCliente.Enabled = False
        limpiar()
    End Sub
#End Region

#Region "Buscar Clientes por Dni"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If ComboBox2.Text = "Todos" Then
            cli.llenarDataGridview(DataGridView1)
        ElseIf ComboBox2.Text = "Dni" Then
            Dim dtpro1 = cli.BuscarClientePorDni(TbBusqueda.Text)
            DataGridView1.DataSource = dtpro1
        Else
            Dim dtpro1 = cli.BuscarClientePorNombre(TbBusqueda.Text)
            DataGridView1.DataSource = dtpro1
        End If
    End Sub
#End Region

End Class