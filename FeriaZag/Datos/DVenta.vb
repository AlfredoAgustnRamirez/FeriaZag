Imports System.Data.SqlClient
Public Class DVenta

#Region "Variables"
    Private cmb As SqlCommandBuilder
    Dim adaptador As New SqlDataAdapter
    Public dt As DataTable
#End Region

#Region "Registrar Venta"
    Public Function RegistrarVenta(idcliente As String, fecha As Date, totalventa As Decimal)
        Dim da As New SqlCommand("RegistrarVenta", cnx)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@Id_Cliente", idcliente)
        da.Parameters.AddWithValue("@Fecha", fecha)
        da.Parameters.AddWithValue("@TotalVenta", totalventa)
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
            MsgBox("Registrado con exito ", MsgBoxStyle.Information)
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

End Class
