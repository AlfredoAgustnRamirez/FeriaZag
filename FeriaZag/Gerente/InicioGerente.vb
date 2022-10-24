Public Class InicioGerente
    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblFecha.Text = DateTime.Now.ToLongDateString()
        LblHora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub InicioGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = VarUsuario
    End Sub
End Class