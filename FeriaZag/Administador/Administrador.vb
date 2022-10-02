Public Class Administrador

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Esta Seguro de salir del Sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        'muestra el formulario producto en el evento
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproducto As New Producto
        frmproducto.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproducto)
        frmproducto.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmcliente As New Cliente
        frmcliente.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmcliente)
        frmcliente.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmhora As New InicioAdmin
        frmhora.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmhora)
        frmhora.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproveedor As New proveedor
        frmproveedor.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproveedor)
        frmproveedor.Show()
    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        'Asigna fecha y hora a los labels
        LblHora.Text = DateTime.Now.ToLongTimeString()
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmcategoria As New Categoria
        frmcategoria.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmcategoria)
        frmcategoria.Show()
    End Sub

    Private Sub IconMenuItem1_Click(sender As Object, e As EventArgs) Handles IconMenuItem1.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmreporteadmin As New ReporteAdmin
        frmreporteadmin.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmreporteadmin)
        frmreporteadmin.Show()
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load
        'muestra y asigna el nombre del usuario 
        Label2.Text = varUsuario
    End Sub


End Class