Public Class LVenta
    Dim Id_Empleado, id_Cliente As Integer
    Dim Fecha As String

    Public Property _idempleado
        Set(value)
            Id_Empleado = value

        End Set
        Get
            Return Id_Empleado
        End Get
    End Property

    Public Property _idcliente
        Set(value)
            id_Cliente = value
        End Set
        Get
            Return id_Cliente
        End Get
    End Property

    Public Property _fechaventa
        Set(value)
            Fecha = value
        End Set
        Get
            Return Fecha
        End Get
    End Property
End Class
