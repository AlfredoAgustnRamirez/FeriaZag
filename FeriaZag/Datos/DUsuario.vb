Imports System.Data.SqlClient
Public Class DUsuario

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "Registrar Usuario"
    Public Function RegistrarUsuario(id_perfil As Integer, nombre As String, apellido As String, dni As Integer, telefono As Long, direccion As String, email As String, usuario As String, contraseña As String, activo As String)
        Dim da As New SqlCommand("RegistrarUsuario", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Id_Perfil", id_perfil)
        da.Parameters.AddWithValue("@Nombre", nombre)
        da.Parameters.AddWithValue("@Apellido", apellido)
        da.Parameters.AddWithValue("@Dni", dni)
        da.Parameters.AddWithValue("@Telefono", telefono)
        da.Parameters.AddWithValue("@Direccion", direccion)
        da.Parameters.AddWithValue("@Email", email)
        da.Parameters.AddWithValue("@Usuario", usuario)
        da.Parameters.AddWithValue("@Contraseña", contraseña)
        da.Parameters.AddWithValue("@Activo", activo)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrado con exito " + nombre, MsgBoxStyle.Information)
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar Usuario")
        End Try
        Return resp
    End Function
#End Region

#Region "llenarDataGridView Usuario"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SelectUsuarios", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Modificar Usuario"
    Public Function ModificarUsuario(id_usuario As Integer, IdPerfil As Integer, Nombre As String, Apellido As String, Dni As Integer, Telefono As Long, Direccion As String, Email As String, Usuario As String, Contraseña As String, activo As String)
        Dim modificar As New SqlCommand("ModificarUsuario", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@Id_Usuario", id_usuario)
        modificar.Parameters.AddWithValue("@Id_Perfil", IdPerfil)
        modificar.Parameters.AddWithValue("@Nombre", Nombre)
        modificar.Parameters.AddWithValue("@Apellido", Apellido)
        modificar.Parameters.AddWithValue("@Dni", Dni)
        modificar.Parameters.AddWithValue("@Telefono", Telefono)
        modificar.Parameters.AddWithValue("@Direccion", Direccion)
        modificar.Parameters.AddWithValue("@Email", Email)
        modificar.Parameters.AddWithValue("@Usuario", Usuario)
        modificar.Parameters.AddWithValue("@Contraseña", Contraseña)
        modificar.Parameters.AddWithValue("@Activo", activo)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea modificar el Usuario?", 32 + 4, "Modificar")
        If respuesta = 6 Then
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + idusuario, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al modificar Usuario", MsgBoxStyle.Critical)
            End Try
        End If
        Return resp
    End Function
#End Region

#Region "Eliminar Usuario"
    Public Function EliminarUsuario(idusuario As String)
        Dim eliminar As New SqlCommand("BajaUsuario", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@Id_Usuario", idusuario)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea eliminar el Usuario?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + idusuario, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al eliminar Usuario", MsgBoxStyle.Critical)
            End Try

        End If
        Return resp
    End Function
#End Region

#Region "Buscar Usuario por Dni"
    Public Function BuscarUsuarioPorDni(Dni As Integer) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarUsuarioPorDni", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Dni", Dni)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Buscar por Usuario"
    Public Function BuscarUsuario(usuario As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarUsuario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Usuario", usuario)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Buscar Usuario codigo"
    Public Function BuscarUsuarioPorCodigo(id_usuario As Integer) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarUsuarioPorCodigo", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_Usuario", id_usuario)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Obtener id del Usuario"
    Public Function ObtenerIdUsuario(Usuario As String)
        Dim id As Integer
        Conectar()
        Try
            Dim cmd As New SqlCommand("ObtenerIdUsuario", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Usuario", Usuario)
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Read()
                id = Convert.ToInt32(lector(0).ToString)
                lector.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return id
    End Function
#End Region

End Class