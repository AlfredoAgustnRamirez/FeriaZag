Public Class Reporte

#Region "Variables"
    Dim ven As New DVenta
#End Region

#Region "Reporte Load"
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "Reporte de venta fecha desde hasta"
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        fechaDesde = DateTimePicker1.Value
        fechaHasta = DateTimePicker2.Value
        Dim dtpro = ven.ReporteVenta(fechaDesde, fechaHasta)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte de venta hoy"
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        fechaDesde = DateTime.Today
        fechaHasta = DateTime.Now
        Dim dtpro = ven.ReporteVenta(fechaDesde, fechaHasta)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte venta ultimos 7 dias"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        fechaDesde = DateTime.Today.AddDays(-7)
        fechaHasta = DateTime.Now
        Dim dtpro = ven.ReporteVenta(fechaDesde, fechaHasta)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte venta ultimos 30 dias"
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        fechaDesde = DateTime.Today.AddDays(-30)
        fechaHasta = DateTime.Now
        Dim dtpro = ven.ReporteVenta(fechaDesde, fechaHasta)
        DataGridView1.DataSource = dtpro
    End Sub

    Private Sub BVImprimirVenta_Click(sender As Object, e As EventArgs) Handles BVImprimirVenta.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Debe ingresar las fechas para generar el informe ", MsgBoxStyle.Information)
        Else
            FrmReporteGerente.ShowDialog()
        End If
    End Sub


#End Region

End Class