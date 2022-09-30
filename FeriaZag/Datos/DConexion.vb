Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class DConexion
#Region "Variables"

    Public cnx As New SqlConnection("Data Source=DESKTOP-0RGS1RR\SQLEXPRESS01;Initial Catalog=FeriaZag;Integrated Security=True")

#End Region
#Region "Base de datos"
    Public Sub Conectar()
        Try
            cnx.Open()
        Catch ex As Exception
            MsgBox("No conectado" + ex.ToString)
        End Try
    End Sub

#End Region
End Class
