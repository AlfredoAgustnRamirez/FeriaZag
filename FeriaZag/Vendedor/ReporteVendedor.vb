Public Class ReporteVendedor

#Region "Variables"
    Dim ven As New DVenta
#End Region

#Region "Data Grid"
    Private Sub ReporteVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtpro = ven.ReporteVenta(DateTime.Today, DateTime.Now)
        DataGridView2.DataSource = dtpro
    End Sub

    Private Sub BVImprimirVenta_Click(sender As Object, e As EventArgs) Handles BVImprimirVenta.Click
        Dim dtpro = ven.ReporteVenta(DateTime.Today, DateTime.Now)
        DataGridView2.DataSource = dtpro
        FReporteVendedor.ShowDialog()
    End Sub


#End Region

End Class