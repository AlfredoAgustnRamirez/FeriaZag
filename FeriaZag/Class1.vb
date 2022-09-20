
Imports System.Data.SqlClient
    Public Class Class1
    'No te olvides visitar Vaidrollteam.blogspot.com para encontrar más proyectos.
    Private cnx As New SqlConnection("Data Source=DESKTOP-2715FLN\SQLEXPRESS;Initial Catalog=FeriaZag;Integrated Security=True")



    Public Function BuscarProductos(nombreproducto As String, idcategoria As String) As DataTable
            Dim cmd As SqlCommand = New SqlCommand("vai_buscar_productos", cnx)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nombreproducto)
            cmd.Parameters.AddWithValue("@idcategoria", idcategoria)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dtable1 As DataTable = New DataTable()
            da.Fill(dtable1)
            Return dtable1
        End Function
        'No te olvides de suscribirte al canal VaidrollTeam
        Public Function ListarCategoria() As DataTable
            Dim da As New SqlDataAdapter("vai_listar_categoria", cnx)
            Dim tbl As New DataTable
            da.Fill(tbl)
            Return tbl
        End Function

        Public Function RegistrarProducto(nombreproducto As String, idcategoria As String, precio As Decimal, stock As Integer)
            Dim da As New SqlCommand("vai_nuevo_producto", cnx)
            da.CommandType = CommandType.StoredProcedure
            da.Parameters.AddWithValue("@nombre", nombreproducto)
            da.Parameters.AddWithValue("@idcategoria", idcategoria)
            da.Parameters.AddWithValue("@precio", precio)
            da.Parameters.AddWithValue("@stock", stock)
            cnx.Open()
            Dim resp As Integer
            Try
                resp = da.ExecuteNonQuery
                MsgBox("Registrador con exito " + nombreproducto)
                cnx.Close()
            Catch ex As Exception
                MsgBox("Error al registrar producto")
            End Try
            Return resp
        End Function

        Public Function EliminarProducto(codigo As String)
            Dim eliminar As New SqlCommand("vai_eliminar_producto", cnx)
            eliminar.CommandType = CommandType.StoredProcedure
            eliminar.Parameters.AddWithValue("@codigo", codigo)
            cnx.Open()
            Dim resp As Integer
            Try
                resp = eliminar.ExecuteNonQuery
                MsgBox("Eliminado con exito " + codigo)
                cnx.Close()
            Catch ex As Exception
                MsgBox("Error al eliminar producto")
            End Try
            Return resp
        End Function

        Public Function ModificarProducto(codigo As String, nombreproducto As String, idcategoria As String, precio As Decimal, stock As Integer)
            Dim modificar As New SqlCommand("vai_modificar_producto", cnx)
            modificar.CommandType = CommandType.StoredProcedure
            modificar.Parameters.AddWithValue("@codigo", codigo)
            modificar.Parameters.AddWithValue("@nombre", nombreproducto)
            modificar.Parameters.AddWithValue("@idcategoria", idcategoria)
            modificar.Parameters.AddWithValue("@precio", precio)
            modificar.Parameters.AddWithValue("@stock", stock)
            cnx.Open()
            Dim resp As Integer
            Try
                resp = modificar.ExecuteNonQuery
                MsgBox("Modificado con exito " + codigo)
                cnx.Close()
            Catch ex As Exception
                MsgBox("Error al modificar producto")
            End Try
            Return resp
        End Function
    End Class
