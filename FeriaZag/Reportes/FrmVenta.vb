Public Class FrmVenta
    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FeriaZagDataSet2.MostrarVenta' Puede moverla o quitarla según sea necesario.
        Me.MostrarVentaTableAdapter.Fill(Me.FeriaZagDataSet2.MostrarVenta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class