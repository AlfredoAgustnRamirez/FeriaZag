Imports System.Data.SqlClient

Public Class DCliente

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "llenarDataGridView Cliente"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from Clientes", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Registrar Cliente"
    Public Function RegistrarCliente(nombre As String, apellido As String, dni As Integer, telefono As Long, email As String, domicilio As String)
        Dim da As New SqlCommand("RegistrarCliente", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Nombre", nombre)
        da.Parameters.AddWithValue("@Apellido", apellido)
        da.Parameters.AddWithValue("@Dni", dni)
        da.Parameters.AddWithValue("@Telefono", telefono)
        da.Parameters.AddWithValue("@Email", email)
        da.Parameters.AddWithValue("@Domicilio", domicilio)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrado con exito " + nombre, MsgBoxStyle.Information)
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "Eliminar Cliente"
    Public Function EliminarCliente(Id_Cliente As String)
        Dim eliminar As New SqlCommand("EliminarCliente", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@Id_Cliente", Id_Cliente)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea eliminar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + Id_Cliente, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al eliminar producto", MsgBoxStyle.Critical)
            End Try

        End If
        Return resp
    End Function
#End Region

#Region "Modificar Cliente"
    Public Function ModificarCliente(Id_Cliente As String, Nombre As String, Apellido As String, Dni As Integer, Telefono As Long, Email As String, Domicilio As String)
        Dim modificar As New SqlCommand("ModificarCliente", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@Id_Cliente", Id_Cliente)
        modificar.Parameters.AddWithValue("@Nombre", Nombre)
        modificar.Parameters.AddWithValue("@Apellido", Apellido)
        modificar.Parameters.AddWithValue("@Dni", Dni)
        modificar.Parameters.AddWithValue("@Telefono", Telefono)
        modificar.Parameters.AddWithValue("@Email", Email)
        modificar.Parameters.AddWithValue("@Domicilio", Domicilio)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea modificar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + Id_Cliente, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al modificar producto", MsgBoxStyle.Critical)
            End Try
        End If
        Return resp
    End Function
#End Region

#Region "Buscar Cliente"
    Public Function BuscarClientePorDni(dni As Integer) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarClientePorDni", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Dni", dni)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function

#End Region

End Class
