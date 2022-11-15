<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FeriaZagDataSetRA = New FeriaZag.FeriaZagDataSetRA()
        Me.ReporteVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteVentaTableAdapter = New FeriaZag.FeriaZagDataSetRATableAdapters.ReporteVentaTableAdapter()
        CType(Me.FeriaZagDataSetRA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DReporteAdmin"
        ReportDataSource1.Value = Me.ReporteVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FeriaZag.RVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'FeriaZagDataSetRA
        '
        Me.FeriaZagDataSetRA.DataSetName = "FeriaZagDataSetRA"
        Me.FeriaZagDataSetRA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteVentaBindingSource
        '
        Me.ReporteVentaBindingSource.DataMember = "ReporteVenta"
        Me.ReporteVentaBindingSource.DataSource = Me.FeriaZagDataSetRA
        '
        'ReporteVentaTableAdapter
        '
        Me.ReporteVentaTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteAdmin"
        Me.Text = "Reporte de Ventas"
        CType(Me.FeriaZagDataSetRA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteVentaBindingSource As BindingSource
    Friend WithEvents FeriaZagDataSetRA As FeriaZagDataSetRA
    Friend WithEvents ReporteVentaTableAdapter As FeriaZagDataSetRATableAdapters.ReporteVentaTableAdapter
End Class
