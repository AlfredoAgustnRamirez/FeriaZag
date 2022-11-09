Imports System.Drawing.Printing
Imports System.Data.SqlClient
Public Class ImprimirFactura

    Private Sub ImprimirFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs)
        LbCliente.Text = "hola"
    End Sub
End Class