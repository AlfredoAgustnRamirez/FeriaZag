Imports System.Data.SqlClient
Public Class Login

#Region "Boton Ingresar"
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim pass As String
        varUsuario = tbUsuario.Text
        pass = tbContraseña.Text
        If varUsuario = "Admin" And pass = "1234" Then
            MsgBox("Bienvenido Administrador al Sistema de Feria Zag")
            Administrador.Show()
            Me.Hide()
        Else

        End If

        If varUsuario = "Vendedor" And pass = "1234" Then
            MsgBox("Bienvenido Vendedor al Sistema de Feria Zag")
            Vendedor.Show()
            Me.Hide()
        End If
        tbUsuario.Text = ""
        tbContraseña.Text = ""

        If varUsuario = "Gerente" And pass = "1234" Then
            MsgBox("Bienvenido Vendedor al Sistema de Feria Zag")
            Gerente.Show()
            Me.Hide()
        End If
        tbUsuario.Text = ""
        tbContraseña.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class

