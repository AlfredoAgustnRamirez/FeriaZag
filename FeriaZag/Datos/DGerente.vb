Imports System.Data.SqlClient
Public Class DGerente

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "Registrar Usuario"
    Public Function RegistrarUsuario(nombre As String, apellido As String, dni As Integer, telefono As Long, direccion As String, email As String, id_perfil As Integer, usuario As String, contraseña As String)
        Dim da As New SqlCommand("RegistrarUsuario", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Nombre", nombre)
        da.Parameters.AddWithValue("@Apellido", apellido)
        da.Parameters.AddWithValue("@Dni", dni)
        da.Parameters.AddWithValue("@Telefono", telefono)
        da.Parameters.AddWithValue("@Direccion", direccion)
        da.Parameters.AddWithValue("@Email", email)
        da.Parameters.AddWithValue("@Id_Perfil", id_perfil)
        da.Parameters.AddWithValue("@Usuario", usuario)
        da.Parameters.AddWithValue("@Contraseña", contraseña)
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

#Region "llenarDataGridView Usuario"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select Usuario.Codigo,nombre,Apellido,Dni,Telefono,Direccion,Email,Perfil,Usuario,Contraseña from Usuario inner join Perfil on Usuario.Id_Perfil = Perfil.Id_Perfil", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Modificar Usuario"
    Public Function ModificarUsuario(Codigo As String, Nombre As String, Apellido As String, Dni As Integer, Telefono As Long, Direccion As String, Email As String, Id_Perfil As Integer, Usuario As String, Contraseña As String)
        Dim modificar As New SqlCommand("ModificarUsuario", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@Codigo", Codigo)
        modificar.Parameters.AddWithValue("@Nombre", Nombre)
        modificar.Parameters.AddWithValue("@Apellido", Apellido)
        modificar.Parameters.AddWithValue("@Dni", Dni)
        modificar.Parameters.AddWithValue("@Telefono", Telefono)
        modificar.Parameters.AddWithValue("@Direccion", Direccion)
        modificar.Parameters.AddWithValue("@Email", Email)
        modificar.Parameters.AddWithValue("@Id_Perfil", Id_Perfil)
        modificar.Parameters.AddWithValue("@Usuario", Usuario)
        modificar.Parameters.AddWithValue("@Contraseña", Contraseña)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea modificar el Producto?", 32 + 4, "Modificar")
        If respuesta = 6 Then
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + Codigo, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al modificar producto", MsgBoxStyle.Critical)
            End Try
        End If
        Return resp
    End Function
#End Region

#Region "Eliminar Usuario"
    Public Function EliminarUsuario(Codigo As String)
        Dim eliminar As New SqlCommand("EliminarUsuario", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@Codigo", Codigo)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea eliminar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + Codigo, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al eliminar producto", MsgBoxStyle.Critical)
            End Try

        End If
        Return resp
    End Function
#End Region

End Class
