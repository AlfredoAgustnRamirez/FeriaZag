Public Class Cliente

#Region "Variables"
    Dim cli As New DCliente
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
    Private Sub TBNombre2Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombre2Cliente.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo Numeros Dni2 Cliente"
    Private Sub TBDni2Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDni2Cliente.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "Carga de Cliente"
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cli.Conectar()
        cli.llenarDataGridview(DataGridView1)
        cli.Desconectar()
    End Sub
#End Region

End Class