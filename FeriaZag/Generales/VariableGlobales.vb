Imports System.Data.SqlClient
Module VariableGlobales
    Public VarUsuario As String
    Public VarContraseña As String
    Public VarPerfil As String
    Public idusuario As Integer
    Public idcabecera As Integer
    Public fechaDesde As DateTime
    Public fechaHasta As DateTime
    Public nombrebackup As String
    Public directorio As String
    Public cod As String
    Public cnx As New SqlConnection("Data Source=DESKTOP-0RGS1RR\SQLEXPRESS01;Initial Catalog=FeriaZag;Integrated Security=True")
End Module
