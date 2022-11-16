Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Backup

#Region "Solo letras Directorio Backup"
    Private Sub TBDirectorio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDirectorio.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Solo letras Nombre del Backup"
    Private Sub TBNombreBackup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreBackup.KeyPress
        SoloLetras(e)
    End Sub
#End Region

#Region "Realizar backup"
    Private Sub ICBBase_Click(sender As Object, e As EventArgs) Handles ICBBase.Click
        directorio = TBDirectorio.Text
        nombrebackup = TBNombreBackup.Text
        If TBDirectorio.Text <> String.Empty Then
            System.IO.Directory.CreateDirectory(TBDirectorio.Text)
            Dim query As String = "Backup Database FeriaZag To disk='" + TBDirectorio.Text + "\" + TBNombreBackup.Text + ".bak'"
            Dim cmd As New SqlCommand(query, cnx)
            Conectar()
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Backup guardado correctamente")
                Desconectar()
            Catch ex As Exception
                MsgBox("Backup no se ha guardado correctamente")
            End Try

        End If
    End Sub
#End Region

#Region "Buscar ruta para backup"
    Private Sub ICBBuscar_Click(sender As Object, e As EventArgs) Handles ICBBuscar.Click
        Dim examinar As DialogResult
        examinar = FolderBrowserDialog1.ShowDialog
        If examinar = DialogResult.OK Then
            TBDirectorio.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FrmRestore.Show()
    End Sub
#End Region

End Class