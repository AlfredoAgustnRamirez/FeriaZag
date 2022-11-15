Public Class ReporteAdmin

#Region "Variables"
    Dim ven As New DVenta
#End Region

#Region "Mostrar Reportes"
    Private Sub ReporteAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
#End Region

#Region "Reporte de ventas fecha desde, fecha hasta"
    Private Sub BVBuscar_Click(sender As Object, e As EventArgs) Handles BVBuscar.Click
        fechaDesde = DateTimePicker1.Value
        fechaHasta = DateTimePicker2.Value
        Dim dtpro = ven.ReporteVenta(fechaDesde, fechaHasta)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte de ventas hoy"
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        fechaDesde = DateTime.Today
        fechaHasta = DateTime.Now
        Dim dtpro = ven.ReporteVenta(fechaDesde, fechaHasta)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte de venta ultimos 7 dias"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        fechaDesde = DateTime.Today.AddDays(-7)
        fechaHasta = DateTime.Now
        Dim dtpro = ven.ReporteVenta(fechaDesde, fechaHasta)
        DataGridView1.DataSource = dtpro
    End Sub

    Private Sub BVImprimirVenta_Click(sender As Object, e As EventArgs) Handles BVImprimirVenta.Click
        FrmReporteAdmin.ShowDialog()
    End Sub



#End Region

End Class