Public Class InicioAdmin
    Private Sub InicioAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = varUsuario
    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblFecha.Text = DateTime.Now.ToLongDateString()
        LblHora.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class