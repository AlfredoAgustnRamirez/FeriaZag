Imports System.Data.SqlClient
Public Class DCategoria

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "RegistrarCategorias"
    Public Function RegistrarCategoria(Categoria As String, activo As String)
        Dim da As New SqlCommand("RegistrarCategoria", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Categoria", Categoria)
        da.Parameters.AddWithValue("@Activos", activo)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrado con exito " + Categoria, MsgBoxStyle.Information)
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar Categoria")
        End Try
        Return resp
    End Function
#End Region

#Region "EliminarCategoria"
    Public Function EliminarCategoria(IdCategoria As String)
        Dim eliminar As New SqlCommand("BajaCategoria", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@IdCategoria", IdCategoria)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea eliminar la Categoria?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + IdCategoria, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al eliminar Categoria", MsgBoxStyle.Critical)
            End Try

        End If
        Return resp
    End Function
#End Region

#Region "llenarDataGridView Categoria"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SelectCategorias", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Modificar Categoria"
    Public Function ModificarCategoria(idcategoria As String, categoria As String, activo As String)
        Dim modificar As New SqlCommand("ModificarCategoria", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@IdCategoria", idcategoria)
        modificar.Parameters.AddWithValue("@Categoria", categoria)
        modificar.Parameters.AddWithValue("@Activos", activo)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea modificar la Categoria?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + idcategoria, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al modificar Categoria", MsgBoxStyle.Critical)
            End Try
        End If
        Return resp
    End Function
#End Region

#Region "Buscar por categoria"
    Public Function BuscarCategoria(codigo As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarCategoria", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Categoria", codigo)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

End Class
