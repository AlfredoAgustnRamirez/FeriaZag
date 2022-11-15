<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactura
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FeriaZagDataSet = New FeriaZag.FeriaZagDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New FeriaZag.FeriaZagDataSetTableAdapters.ClientesTableAdapter()
        Me.GenerarComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenerarComprobanteTableAdapter = New FeriaZag.FeriaZagDataSetTableAdapters.GenerarComprobanteTableAdapter()
        Me.FeriaZagDataSet2 = New FeriaZag.FeriaZagDataSet2()
        Me.MostrarVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MostrarVentaTableAdapter = New FeriaZag.FeriaZagDataSet2TableAdapters.MostrarVentaTableAdapter()
        CType(Me.FeriaZagDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeriaZagDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DClientes"
        ReportDataSource1.Value = Me.ClientesBindingSource
        ReportDataSource2.Name = "DGenerarComprobante"
        ReportDataSource2.Value = Me.GenerarComprobanteBindingSource
        ReportDataSource3.Name = "DVenta"
        ReportDataSource3.Value = Me.MostrarVentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FeriaZag.RVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'FeriaZagDataSet
        '
        Me.FeriaZagDataSet.DataSetName = "FeriaZagDataSet"
        Me.FeriaZagDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.FeriaZagDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'GenerarComprobanteBindingSource
        '
        Me.GenerarComprobanteBindingSource.DataMember = "GenerarComprobante"
        Me.GenerarComprobanteBindingSource.DataSource = Me.FeriaZagDataSet
        '
        'GenerarComprobanteTableAdapter
        '
        Me.GenerarComprobanteTableAdapter.ClearBeforeFill = True
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
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmFactura"
        Me.Text = "Imprimir Comprobante"
        CType(Me.FeriaZagDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeriaZagDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents FeriaZagDataSet As FeriaZagDataSet
    Friend WithEvents GenerarComprobanteBindingSource As BindingSource
    Friend WithEvents MostrarVentaBindingSource As BindingSource
    Friend WithEvents FeriaZagDataSet2 As FeriaZagDataSet2
    Friend WithEvents ClientesTableAdapter As FeriaZagDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents GenerarComprobanteTableAdapter As FeriaZagDataSetTableAdapters.GenerarComprobanteTableAdapter
    Friend WithEvents MostrarVentaTableAdapter As FeriaZagDataSet2TableAdapters.MostrarVentaTableAdapter
End Class
