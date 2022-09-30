Public Class Gerente
    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblHora.Text = DateTime.Now.ToLongTimeString()
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub InicioVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioVendedorToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmhorafecha As New InicioGerente
        frmhorafecha.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmhorafecha)
        frmhorafecha.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmbackup As New Backup
        frmbackup.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmbackup)
        frmbackup.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmusuarios As New Usuarios
        frmusuarios.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmusuarios)
        frmusuarios.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmreporte As New Reporte
        frmreporte.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmreporte)
        frmreporte.Show()
    End Sub

    Private Sub Gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = varUsuario
    End Sub
End Class