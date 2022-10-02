Imports System.Data.SqlClient

Public Class DCategoria

#Region "Variables"
    Inherits DConexion
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "llenarDataGridView Categoria"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select Categoria.IdCategoria,Categoria,Cantidad from Categoria", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

End Class
