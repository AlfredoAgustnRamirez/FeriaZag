Imports System.Data.SqlClient
Public Class DProducto

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "EliminarProducto"
    Public Function EliminarProducto(codigo As String)
        Dim eliminar As New SqlCommand("BajaProducto", cnx)
        eliminar.CommandType = CommandType.StoredProcedure
        eliminar.Parameters.AddWithValue("@Codigo", codigo)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea eliminar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + codigo, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al eliminar producto", MsgBoxStyle.Critical)
            End Try

        End If
        Return resp
    End Function
#End Region

#Region "ModificarProducto"
    Public Function ModificarProducto(codigo As String, idcategoria As String, producto As String, precio As Decimal, stock As Integer, activo As String)
        Dim modificar As New SqlCommand("ModificarProductos", cnx)
        modificar.CommandType = CommandType.StoredProcedure
        modificar.Parameters.AddWithValue("@Codigo", codigo)
        modificar.Parameters.AddWithValue("@IdCategoria", idcategoria)
        modificar.Parameters.AddWithValue("@Producto", producto)
        modificar.Parameters.AddWithValue("@Precio", precio)
        modificar.Parameters.AddWithValue("@Stock", stock)
        modificar.Parameters.AddWithValue("@Activo", activo)
        Conectar()
        Dim resp As Integer
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Seguro que desea modificar el Producto?", 32 + 4, "Eliminar")
        If respuesta = 6 Then
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + codigo, MsgBoxStyle.Information)
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al modificar producto", MsgBoxStyle.Critical)
            End Try
        End If
        Return resp
    End Function
#End Region

#Region "RegistrarProducto"
    Public Function RegistrarProducto(nombreproducto As String, idcategoria As String, precio As Decimal, stock As Integer, activo As String)
        Dim da As New SqlCommand("RegistrarProductos", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Producto", nombreproducto)
        da.Parameters.AddWithValue("@IdCategoria", idcategoria)
        da.Parameters.AddWithValue("@Precio", precio)
        da.Parameters.AddWithValue("@Stock", stock)
        da.Parameters.AddWithValue("@Activo", activo)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            MsgBox("Registrado con exito " + nombreproducto, MsgBoxStyle.Information)
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "Buscar Producto por Codigo"
    Public Function BuscarProductosPorCodigo(codigo As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarProductoPorCodigo", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Codigo", codigo)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Buscar Producto por Categoria"
    Public Function BuscarProductosPorCategoria(categoria As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarProductoPorCategoria", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Categoria", categoria)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Buscar Producto por Categoria"
    Public Function BuscarProductosPorNombre(nombre As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand("BuscarProductoPorNombre", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Producto", nombre)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "listarProductos"
    Public Function ListarProductos() As DataTable
        Dim da As New SqlDataAdapter("select * from Productos", cnx)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function
#End Region

#Region "llenarDataGridView"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SelectProductos", cnx)
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
        Dim da As New SqlDataAdapter("select * from Categoria", cnx)
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function
#End Region

#Region "Sumar Precio Venta"
    Public Function Sumar(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double
        Dim Total As Double = 0
        Try
            If Dgv.RowCount > 0 Then
                For i As Integer = 0 To Dgv.RowCount - 1
                    Total = Total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
                Next
                Return Total
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try
    End Function
#End Region

End Class
