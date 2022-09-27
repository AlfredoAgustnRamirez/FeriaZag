Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DProducto
    Inherits Conexion
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#Region "EliminarProducto"
    Public Function EliminarProducto(codigo As String)
        Dim eliminar As New SqlCommand("EliminarProductos", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@Codigo", codigo)
        Dim resp As Integer
        Try
            resp = eliminar.ExecuteNonQuery
            MsgBox("Eliminado con exito " + codigo)
        Catch ex As Exception
            MsgBox("Error al eliminar producto")
        End Try
        Return resp
    End Function
#End Region
#Region "ModificarProducto"
    Public Function ModificarProducto(codigo As String, producto As String, idcategoria As String, precio As Decimal, stock As Integer)
        Dim modificar As New SqlCommand("ModificarProductos", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@Codigo", codigo)
        modificar.Parameters.AddWithValue("@Producto", producto)
        modificar.Parameters.AddWithValue("@IdCategoria", idcategoria)
        modificar.Parameters.AddWithValue("@Precio", precio)
        modificar.Parameters.AddWithValue("@Stock", stock)
        Dim resp As Integer
        Try
            resp = modificar.ExecuteNonQuery
            MsgBox("Modificado con exito " + codigo)
        Catch ex As Exception
            MsgBox("Error al modificar producto")
        End Try
        Return resp
    End Function
#End Region
#Region "RegistrarProducto"
    Public Function RegistrarProducto(nombreproducto As String, idcategoria As String, precio As Decimal, stock As Integer)
        Dim da As New SqlCommand("RegistrarProductos", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Producto", nombreproducto)
        da.Parameters.AddWithValue("@IdCategoria", idcategoria)
        da.Parameters.AddWithValue("@Precio", precio)
        da.Parameters.AddWithValue("@Stock", stock)
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrador con exito " + nombreproducto)
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "BuscarProducto"
    Public Function BuscarProductos(nombreproducto As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarProductos", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Producto", nombreproducto)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function

#End Region

#Region "listarProductos"
    Public Function ListarProductos() As DataTable
        Dim da As New SqlDataAdapter("select Productos.Codigo,Producto,IdCategoria,Precio,Stock from Productos", cnx)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function
#End Region
#Region "llenarDataGridView"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select Productos.Codigo,Producto,IdCategoria, Precio,Stock from Productos", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "listarCategoria"
    Public Function ListarCategoria() As DataTable
        Dim da As New SqlDataAdapter("select Categoria.IdCategoria,Categoria from Categoria", cnx)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function
#End Region
End Class
