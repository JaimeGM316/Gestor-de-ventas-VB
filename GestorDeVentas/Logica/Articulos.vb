Public Class Articulos
    Dim _codigo As String
    Dim _descripcion As String
    Dim _fechaCompra As Date
    Dim _precioCompra As Decimal
    Dim _stock As Integer

    Public Sub New()

    End Sub
    Public Sub New(_codigo As String, _descripcion As String, _fechaCompra As Date, _precioCompra As Decimal, _stock As Integer)
        Me._codigo = _codigo
        Me._descripcion = _descripcion
        Me._fechaCompra = _fechaCompra
        Me._precioCompra = _precioCompra
        Me._stock = _stock
    End Sub

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property FechaCompra As Date
        Get
            Return _fechaCompra
        End Get
        Set(value As Date)
            _fechaCompra = value
        End Set
    End Property

    Public Property PrecioCompra As Decimal
        Get
            Return _precioCompra
        End Get
        Set(value As Decimal)
            _precioCompra = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property
End Class
