Imports System.Data.SqlClient
Module VariableGlobales
    Public VarUsuario As String
    Public VarContraseña As String
    Public VarPerfil As String
    Public idusuario As Integer
    Public idcabecera As Integer
    Public cnx As New SqlConnection("Data Source=DESKTOP-0RGS1RR\SQLEXPRESS01;Initial Catalog=FeriaZag;Integrated Security=True")
End Module
