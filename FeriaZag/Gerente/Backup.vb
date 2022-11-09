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

End Class