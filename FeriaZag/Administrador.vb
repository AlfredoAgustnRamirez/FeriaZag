Public Class Administrador
    Private Sub Fadministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproducto As New Producto
        frmproducto.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproducto)
        frmproducto.Show()
    End Sub
End Class