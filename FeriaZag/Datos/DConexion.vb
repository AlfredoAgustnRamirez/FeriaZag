Imports System.Data.SqlClient
Module DConexion
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

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

#Region "Usuario Registrado"
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuario where Usuario='" & nombreUsuario & "'", cnx)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
#End Region

#Region "Clave"
    Function Clave(ByVal nombreUsuario As String) As String
        Dim resultado As String = " "
        Try
            enunciado = New SqlCommand("Select Contraseña from Usuario where Contraseña='" & nombreUsuario & "'", cnx)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
#End Region

#Region "Tipo de Usuario"
    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select Id_Perfil from Usuario where Usuario='" & nombreUsuario & "'", cnx)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("Id_Perfil"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
#End Region

End Module
