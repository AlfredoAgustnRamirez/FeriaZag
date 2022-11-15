Public Class ReporteAdmin

#Region "Variables"
    Dim ven As New DVenta
#End Region

#Region "Mostrar Reportes"
    Private Sub ReporteAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ven.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Reporte de ventas fecha desde, fecha hasta"
    Private Sub BVBuscar_Click(sender As Object, e As EventArgs) Handles BVBuscar.Click
        Dim dtpro = ven.ReporteVenta(DateTimePicker1.Value, DateTimePicker2.Value)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte de ventas hoy"
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim dtpro = ven.ReporteVentaHoy()
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte de venta ultimos 7 dias"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim dtpro = ven.ReporteVentaUltimos7dias()
        DataGridView1.DataSource = dtpro
    End Sub

    Private Sub BVImprimirVenta_Click(sender As Object, e As EventArgs) Handles BVImprimirVenta.Click
        FrmVenta.ShowDialog()
    End Sub


#End Region

End Class