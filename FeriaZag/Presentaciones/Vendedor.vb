Public Class Vendedor

    Dim obj As New Login


    Private Sub ProductosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproducto2 As New Venta
        frmproducto2.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproducto2)
        frmproducto2.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class