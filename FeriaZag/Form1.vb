Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Login
    Private conexion As New SqlConnection("Data Source=DESKTOP-2715FLN\SQLEXPRESS;Initial Catalog=FeriaZag;Integrated Security=True")

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim User, pass As String
        User = tbUsuario.Text
        pass = tbContraseña.Text
        If User = "Admin" And pass = "1234" Then
            MsgBox("Bienvenido Administrador al Sistema de Feria Zag")
            Administrador.Show()
            Me.Hide()
        Else

        End If

        Dim User2, pass2 As String
        User2 = tbUsuario.Text
        pass2 = tbContraseña.Text
        If User = "Vendedor" And pass = "56789" Then
            MsgBox("Bienvenido Vendedor al Sistema de Feria Zag")
            Vendedor.Show()
            Me.Hide()
        End If
        tbUsuario.Text = ""
        tbContraseña.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
