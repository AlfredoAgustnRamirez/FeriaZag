Public Class InicioVendedor
    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblFecha.Text = DateTime.Now.ToLongDateString()
        LblHora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub InicioVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = varUsuario
    End Sub
End Class