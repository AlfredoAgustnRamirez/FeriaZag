Imports System.Data.SqlClient
Public Class DProveedor

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "Registrar Proveedor"
    Public Function RegistrarProveedor(Nombre As String, Apellido As String, Telefono As Long, Direccion As String, CbuAlias As String, Observacion As String, Activo As String)
        Dim da As New SqlCommand("RegistrarProveedor", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Nombre", Nombre)
        da.Parameters.AddWithValue("@Apellido", Apellido)
        da.Parameters.AddWithValue("@Telefono", Telefono)
        da.Parameters.AddWithValue("@Direccion", Direccion)
        da.Parameters.AddWithValue("@CbuAlias", CbuAlias)
        da.Parameters.AddWithValue("@Observacion", Observacion)
        da.Parameters.AddWithValue("@Activo", Activo)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrado con exito " + Nombre, MsgBoxStyle.Information)
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar Proveedor")
        End Try
        Return resp
    End Function
#End Region

#Region "Eliminar Proveedor"
    Public Function EliminarProveedor(cod_proveedor As String)
        Dim eliminar As New SqlCommand("BajaProveedor", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@cod_proveedor", cod_proveedor)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea eliminar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + cod_proveedor, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al eliminar Proveedor", MsgBoxStyle.Critical)
            End Try

        End If
        Return resp
    End Function
#End Region

#Region "Modificar Proveedor"
    Public Function ModificarProveedor(Cod_Proveedor As String, Nombre As String, Apellido As String, Telefono As Long, Direccion As String, CbuAlias As String, Observacion As String, Activo As String)
        Dim modificar As New SqlCommand("ModificarProveedor", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@cod_proveedor", Cod_Proveedor)
        modificar.Parameters.AddWithValue("@Nombre", Nombre)
        modificar.Parameters.AddWithValue("@Apellido", Apellido)
        modificar.Parameters.AddWithValue("@Telefono", Telefono)
        modificar.Parameters.AddWithValue("@Direccion", Direccion)
        modificar.Parameters.AddWithValue("@CbuAlias", CbuAlias)
        modificar.Parameters.AddWithValue("@Observacion", Observacion)
        modificar.Parameters.AddWithValue("@Activo", Activo)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea modificar el Proveedor?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + Cod_Proveedor, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al modificar Proveedor", MsgBoxStyle.Critical)
            End Try
        End If
        Return resp
    End Function
#End Region

#Region "llenarDataGridView"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from Proveedores", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Buscar Cliente por nombre"
    Public Function BuscarProveedorPorNombre(nombre As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarProveedorPorNombre", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Nombre", nombre)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

End Class
