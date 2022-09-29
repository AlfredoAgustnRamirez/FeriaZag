Public Class Gerente
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmusuario As New Usuarios
        frmusuario.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmusuario)
        frmusuario.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmbackup As New Backup
        frmbackup.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmbackup)
        frmbackup.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmreporte As New Reportes
        frmreporte.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmreporte)
        frmreporte.Show()
    End Sub
End Class