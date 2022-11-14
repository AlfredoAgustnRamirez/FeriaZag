Imports System.Data.SqlClient
Public Class DVenta

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "Registrar Venta"
    Public Function RegistrarVenta(id_cliente As String, id_usuario As Integer, fecha As Date, total As Decimal, comprobante As String, mediopago As String)
        Dim da As New SqlCommand("RegistrarVenta", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Id_Cliente", id_cliente)
        da.Parameters.AddWithValue("@Id_Usuario", id_usuario)
        da.Parameters.AddWithValue("@Fecha", fecha)
        da.Parameters.AddWithValue("@Total", total)
        da.Parameters.AddWithValue("@Comprobante", comprobante)
        da.Parameters.AddWithValue("@MedioPago", mediopago)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "Registrar Venta Detalle"
    Public Function RegistrarVentaDetalle(codigo As String, id_cabecera As Integer, precio As Decimal, cantidad As Integer, total As Decimal)
        Dim da As New SqlCommand("RegistrarVentaDetalle", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Codigo", codigo)
        da.Parameters.AddWithValue("@Id_Cabecera", id_cabecera)
        da.Parameters.AddWithValue("@precio", precio)
        da.Parameters.AddWithValue("@Cantidad", cantidad)
        da.Parameters.AddWithValue("@Total", total)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "Obtener IdCabecera"
    Public Function ObtenerIdCabecera() As Integer
        Dim id As Integer
        Conectar()
        Try
            Dim cmd As New SqlCommand("ObtenerIdCabecera", cnx)
            cmd.CommandType = CommandType.StoredProcedure

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Read()
                id = Convert.ToInt32(lector(0).ToString)
                lector.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return id
    End Function
#End Region

#Region "Obetenet IdVenta"
    Public Function ObtenerIdVenta() As Integer
        Dim id As Integer
        Conectar()
        Try
            Dim cmd As New SqlCommand("ObtenerIdVenta", cnx)
            cmd.CommandType = CommandType.StoredProcedure

            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                lector.Read()
                id = Convert.ToInt32(lector(0).ToString)
                lector.Close()
                Return id
            Else
                Return Nothing
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
#End Region

#Region "Disminuir Stock"
    Public Function Disminuirstock(codigo As String, cantidad As Integer)

        Try
            Conectar()
            Dim cmd As New SqlCommand("Disminuirstock", cnx)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@Codigo", codigo)
                .AddWithValue("@Cantidad", cantidad)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function
#End Region

#Region "Aumentar Stock"
    Public Function Aumentarstock(codigo As String, cantidad As Integer)

        Try
            Conectar()
            Dim cmd As New SqlCommand("Aumentarstock", cnx)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@Codigo", codigo)
                .AddWithValue("@Cantidad", cantidad)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function
#End Region

#Region "Generar comprobante Venta"
    Public Function GenerarComprobante(id_cabecera As Integer)
        Dim da As New SqlCommand("GenerarComprobante", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Id_Cabecera", id_cabecera)
        Conectar()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al registrar producto")
        End Try
        Return resp
    End Function
#End Region

#Region "Mostrar Ventas"
    Sub llenarDataGridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("MostrarVenta", cnx)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("No se lleno el DataGridView debido a: " + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Reporte de Ventas fecha desda fecha hasta "
    Public Function ReporteVenta(fechadesde As String, fechahasta As String) As DataTable
        Dim cmd As New SqlCommand("ReporteVenta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@fechaDesde", fechadesde)
        cmd.Parameters.AddWithValue("@fechaHasta", fechahasta)
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Reporte de Ventas hoy"
    Public Function ReporteVentaHoy() As DataTable
        Dim cmd As New SqlCommand("ReporteVentaHoy", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Reporte de Ventas ultimos 7 dias "
    Public Function ReporteVentaUltimos7dias() As DataTable
        Dim cmd As New SqlCommand("ReporteVentaUltimos7dias", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

#Region "Reporte de Ventas ultimos 30 dias "
    Public Function ReporteVentaUltimos30dias() As DataTable
        Dim cmd As New SqlCommand("ReporteVentaUltimos30dias", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dtable1 As DataTable = New DataTable()
        da.Fill(dtable1)
        Return dtable1
    End Function
#End Region

End Class
