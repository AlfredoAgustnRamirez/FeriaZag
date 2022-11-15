Public Class FrmReporteGerente
    Private Sub FrmReporteGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FeriaZagDataSetRA.ReporteVenta' Puede moverla o quitarla según sea necesario.
        Me.ReporteVentaTableAdapter.Fill(Me.FeriaZagDataSetRA.ReporteVenta, fechaDesde, fechaHasta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class