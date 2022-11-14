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
        Me.GenerarComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenerarComprobanteTableAdapter = New FeriaZag.FeriaZagDataSetTableAdapters.GenerarComprobanteTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New FeriaZag.FeriaZagDataSetTableAdapters.ClientesTableAdapter()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New FeriaZag.FeriaZagDataSetTableAdapters.UsuarioTableAdapter()
        CType(Me.FeriaZagDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DGenerarComprobante"
        ReportDataSource1.Value = Me.GenerarComprobanteBindingSource
        ReportDataSource2.Name = "DClientes"
        ReportDataSource2.Value = Me.ClientesBindingSource
        ReportDataSource3.Name = "DUsuario"
        ReportDataSource3.Value = Me.UsuarioBindingSource
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
        'GenerarComprobanteBindingSource
        '
        Me.GenerarComprobanteBindingSource.DataMember = "GenerarComprobante"
        Me.GenerarComprobanteBindingSource.DataSource = Me.FeriaZagDataSet
        '
        'GenerarComprobanteTableAdapter
        '
        Me.GenerarComprobanteTableAdapter.ClearBeforeFill = True
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
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.FeriaZagDataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmVenta"
        Me.Text = "Comprobante de Venta"
        CType(Me.FeriaZagDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GenerarComprobanteBindingSource As BindingSource
    Friend WithEvents FeriaZagDataSet As FeriaZagDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents GenerarComprobanteTableAdapter As FeriaZagDataSetTableAdapters.GenerarComprobanteTableAdapter
    Friend WithEvents ClientesTableAdapter As FeriaZagDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents UsuarioTableAdapter As FeriaZagDataSetTableAdapters.UsuarioTableAdapter
End Class
