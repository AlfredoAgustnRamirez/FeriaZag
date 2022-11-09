Public Class Vendedor

    Dim obj As New Login


    Private Sub ProductosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproducto2 As New Fecha
        frmproducto2.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproducto2)
        frmproducto2.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Esta Seguro de salir del Sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmclientevendedor As New ClienteVendedor
        frmclientevendedor.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmclientevendedor)
        frmclientevendedor.Show()
    End Sub

    Private Sub ProductoVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoVendedorToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmproductovendedor As New ProductoVendedor
        frmproductovendedor.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmproductovendedor)
        frmproductovendedor.Show()
    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblHora.Text = DateTime.Now.ToLongTimeString()
        LblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmhorafecha As New InicioVendedor
        frmhorafecha.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmhorafecha)
        frmhorafecha.Show()
    End Sub

    Private Sub Vendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = VarUsuario
    End Sub
End Class