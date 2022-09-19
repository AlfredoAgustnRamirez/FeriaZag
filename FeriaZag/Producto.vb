Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Producto
    Private cnx As New SqlConnection("Data Source=DESKTOP-2715FLN\SQLEXPRESS;Initial Catalog=FeriaZag;Integrated Security=True")
    
    Public Function listarProductos()
        Dim da As New SqlDataAdapter("p_listar", "cnx")
        Dim tbl As New DataTable
        da.Fill(tbl)
        Return tbl
    End Function

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Vendedor.Show()
        Close()
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        listarProductos()
    End Sub
End Class