Public Class Categoria

#Region "Variables"
    Dim cat As New DCategoria
#End Region

#Region "Carga de Categoria"
    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cat.Conectar()
        cat.llenarDataGridview(DataGridView1)
        cat.Desconectar()
    End Sub
#End Region





End Class