'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Productos
    Public Property Codigo As String
    Public Property Producto As String
    Public Property IdCategoria As String
    Public Property Precio As Nullable(Of Decimal)
    Public Property stock As Nullable(Of Integer)
    Public Property Activo As String

    Public Overridable Property Categoria As Categoria
    Public Overridable Property Venta_Detalle As ICollection(Of Venta_Detalle) = New HashSet(Of Venta_Detalle)

End Class