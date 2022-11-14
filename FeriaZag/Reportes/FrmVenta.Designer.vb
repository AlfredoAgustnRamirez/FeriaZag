<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FeriaZagDataSet2 = New FeriaZag.FeriaZagDataSet2()
        Me.MostrarVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MostrarVentaTableAdapter = New FeriaZag.FeriaZagDataSet2TableAdapters.MostrarVentaTableAdapter()
        CType(Me.FeriaZagDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DMostrarVentas"
        ReportDataSource1.Value = Me.MostrarVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FeriaZag.RVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'FeriaZagDataSet2
        '
        Me.FeriaZagDataSet2.DataSetName = "FeriaZagDataSet2"
        Me.FeriaZagDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MostrarVentaBindingSource
        '
        Me.MostrarVentaBindingSource.DataMember = "MostrarVenta"
        Me.MostrarVentaBindingSource.DataSource = Me.FeriaZagDataSet2
        '
        'MostrarVentaTableAdapter
        '
        Me.MostrarVentaTableAdapter.ClearBeforeFill = True
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmVenta"
        Me.Text = "Reporte de ventas"
        CType(Me.FeriaZagDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MostrarVentaBindingSource As BindingSource
    Friend WithEvents FeriaZagDataSet2 As FeriaZagDataSet2
    Friend WithEvents MostrarVentaTableAdapter As FeriaZagDataSet2TableAdapters.MostrarVentaTableAdapter
End Class
