Public Class Reporte

#Region "Variables"
    Dim ven As New DVenta
#End Region

#Region "Reporte Load"
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ven.llenarDataGridview(DataGridView1)
    End Sub
#End Region

#Region "Reporte de venta"
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim dtpro = ven.ReporteVenta(DateTimePicker1.Value, DateTimePicker2.Value)
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte de venta hoy"
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim dtpro = ven.ReporteVentaHoy()
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte venta ultimos 7 dias"
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim dtpro = ven.ReporteVentaUltimos7dias()
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

#Region "Reporte venta ultimos 30 dias"
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Dim dtpro = ven.ReporteVentaUltimos30dias()
        DataGridView1.DataSource = dtpro
    End Sub
#End Region

End Class