Imports System.Data.SqlClient
Public Class Login

#Region "Boton Ingresar"
    Private Sub btnIngresar_Click_1(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim pass As String
        varUsuario = tbUsuario.Text
        pass = tbContraseña.Text

        If varUsuario = "Admin" And pass = "1234" Then
            MsgBox("Bienvenido " + varUsuario + " al Sistema de Feria Zag", MsgBoxStyle.Information)
            Administrador.Show()
            Me.Hide()
        ElseIf varUsuario = "Vendedor" And pass = "1234" Then
            MsgBox("Bienvenido " + varUsuario + " al Sistema de Feria Zag", MsgBoxStyle.Information)
            Vendedor.Show()
            Me.Hide()
        ElseIf varUsuario = "Gerente" And pass = "1234" Then
            MsgBox("Bienvenido " + varUsuario + " al Sistema de Feria Zag", MsgBoxStyle.Information)
            Gerente.Show()
            Me.Hide()
        ElseIf tbContraseña.Text = "" Or tbUsuario.Text = "" Then
            MsgBox("Error debe Completar todos los campos", vbCritical, "Error")
        ElseIf varUsuario <> "Admin" Or pass <> "1234" Then
            MsgBox("Error al ingresar usuario o contraseña", vbCritical, "Error")
        End If
        tbContraseña.Text = ""
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

