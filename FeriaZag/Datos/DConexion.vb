Public Class DConexion

#Region "Conectar"
    Public Sub Conectar()
        Try
            cnx.Open()
        Catch ex As Exception
            MsgBox("No conectado" + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Desconectar"
    Public Sub Desconectar()
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class
