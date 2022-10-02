Imports System.Data.SqlClient
Public Class DCliente

#Region "Variables"
    Inherits DConexion
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "llenarDataGridView Cliente"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select Clientes.Id_Cliente,Nombre,Apellido,Dni,Domicilio,Email,Telefono from Clientes", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

End Class
