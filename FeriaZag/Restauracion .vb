Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmRestore

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        restaurarDatos(directorio, nombrebackup)
    End Sub

    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TBDirectorio.Text = "" & OpenFileDialog1.FileName & ""

        End If
    End Sub

    Public Function restaurarDatos(p_nombreResguardo As String, p_direccion As String)
        Try
            Dim conexion As New SqlConnection("Data Source=DESKTOP-2715FLN\SQLEXPRESS;Initial Catalog=FeriaZag;Integrated Security=True")
            Using conexion
                conexion.Open()
                Dim cmd As New SqlCommand("ALTER DATABASE FeriaZag SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE FeriaZag FROM disk='" & p_direccion & p_nombreResguardo & "'", conexion)
                cmd.ExecuteNonQuery()
                conexion.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class