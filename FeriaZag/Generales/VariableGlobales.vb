Imports System.Data.SqlClient
Module VariableGlobales
    Public VarUsuario As String
    Public VarContraseña As String
    Public VarPerfil As String
    Public idusuario As Integer
    Public idcabecera As Integer
<<<<<<< HEAD
<<<<<<< HEAD
    Public cod As String
    Public cat As String
    Public descripcion As String
    Public precio As String
    Public cantidad As String
    Public stock As String
    Public activo As String
    Public cnx As New SqlConnection("Data Source=DESKTOP-2715FLN\SQLEXPRESS;Initial Catalog=FeriaZag;Integrated Security=True")
=======
    Public fechaDesde As DateTime
    Public fechaHasta As DateTime
    Public cnx As New SqlConnection("Data Source=DESKTOP-0RGS1RR\SQLEXPRESS01;Initial Catalog=FeriaZag;Integrated Security=True")
>>>>>>> 9cc4cad1b3440e3e632c590a41221d82df2a53fa
=======
    Public fechaDesde As DateTime
    Public fechaHasta As DateTime
    Public cnx As New SqlConnection("Data Source=DESKTOP-0RGS1RR\SQLEXPRESS01;Initial Catalog=FeriaZag;Integrated Security=True")
>>>>>>> 9cc4cad1b3440e3e632c590a41221d82df2a53fa
End Module
