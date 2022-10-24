Imports System.Data.SqlClient
Public Class Login

#Region "Boton Ingresar"
    Private Sub btnIngresar_Click_1(sender As Object, e As EventArgs) Handles btnIngresar.Click
        VarUsuario = tbUsuario.Text
        VarContraseña = tbContraseña.Text
        Conectar()
        Try
            If usuarioRegistrado(VarUsuario) = True Then
                Dim contra As String = Clave(VarContraseña)
                If contra.Equals(VarContraseña) = True Then
                    Me.Hide()
                    If ConsultarTipoUsuario(VarUsuario) = 1 Then
                        MsgBox("Bienvenido " + VarUsuario + " al Sistema de Feria Zag", MsgBoxStyle.Information)
                        Administrador.Show()
                    ElseIf ConsultarTipoUsuario(VarUsuario) = 2 Then
                        MsgBox("Bienvenido " + VarUsuario + " al Sistema de Feria Zag", MsgBoxStyle.Information)
                        Vendedor.Show()
                    ElseIf ConsultarTipoUsuario(VarUsuario) = 3 Then
                        MsgBox("Bienvenido " + VarUsuario + " al Sistema de Feria Zag", MsgBoxStyle.Information)
                        Gerente.Show()
                    End If
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            ElseIf VarUsuario = "" Or VarContraseña = "" Then
                MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical)
            Else
                MsgBox("El Usuario: " + VarUsuario + " no se encuentra registrado")
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Boton Salir"
    Private Sub ICBSalir_Click(sender As Object, e As EventArgs) Handles ICBSalir.Click
        If MsgBox("¿Esta Seguro de salir del Sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
#End Region

End Class

