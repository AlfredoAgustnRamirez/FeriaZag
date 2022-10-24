Imports System.Data.SqlClient

Public Class DCategoria

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "RegistrarCategorias"
    Public Function RegistrarCategoria(Categoria As String)
        Dim da As New SqlCommand("RegistrarCategoria", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Categoria", Categoria)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrado con exito " + Categoria, MsgBoxStyle.Information)
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "EliminarCategoria"
    Public Function EliminarCategoria(IdCategoria As String)
        Dim eliminar As New SqlCommand("EliminarCategoria", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@IdCategoria", IdCategoria)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea eliminar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + IdCategoria, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al eliminar producto", MsgBoxStyle.Critical)
            End Try

        End If
        Return resp
    End Function
#End Region

#Region "llenarDataGridView Categoria"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from Categoria", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Modificar Categoria"
    Public Function ModificarCategoria(idcategoria As String, categoria As String)
        Dim modificar As New SqlCommand("ModificarProductos", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@IdCategoria", idcategoria)
        modificar.Parameters.AddWithValue("@Categoria", categoria)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea modificar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + idcategoria, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al modificar producto", MsgBoxStyle.Critical)
            End Try
        End If
        Return resp
    End Function
#End Region

End Class
