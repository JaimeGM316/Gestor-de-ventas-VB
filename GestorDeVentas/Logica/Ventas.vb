Public Class Ventas
    Dim _Vnif As String
    Dim _fechaVenta As Date
    Dim _Vnombre As String
    Dim _Vapellidos As String
    Dim _descripcion As String
    Dim _unidades As Integer
    Dim _precioVenta As Double
    Dim _iva As Double
    Dim _totalCompra As Double

    Public Property Vnif As String
        Get
            Return _Vnif
        End Get
        Set(value As String)
            _Vnif = value
        End Set
    End Property

    Public Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
        Set(value As Date)
            _fechaVenta = value
        End Set
    End Property

    Public Property Vnombre As String
        Get
            Return _Vnombre
        End Get
        Set(value As String)
            _Vnombre = value
        End Set
    End Property

    Public Property Vapellidos As String
        Get
            Return _Vapellidos
        End Get
        Set(value As String)
            _Vapellidos = value
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

    Public Property Unidades As Integer
        Get
            Return _unidades
        End Get
        Set(value As Integer)
            _unidades = value
        End Set
    End Property

    Public Property PrecioVenta As Double
        Get
            Return _precioVenta
        End Get
        Set(value As Double)
            _precioVenta = value
        End Set
    End Property

    Public Property Iva As Double
        Get
            Return _iva
        End Get
        Set(value As Double)
            _iva = value
        End Set
    End Property

    Public Property TotalCompra As Double
        Get
            Return _totalCompra
        End Get
        Set(value As Double)
            _totalCompra = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(_Vnif As String, _fechaVenta As Date, _Vnombre As String, _Vapellidos As String, _descripcion As String, _unidades As Integer, _precioVenta As Double, _iva As Double, _totalCompra As Double)
        Me._Vnif = _Vnif
        Me._fechaVenta = _fechaVenta
        Me._Vnombre = _Vnombre
        Me._Vapellidos = _Vapellidos
        Me._descripcion = _descripcion
        Me._unidades = _unidades
        Me._precioVenta = _precioVenta
        Me._iva = _iva
        Me._totalCompra = _totalCompra
    End Sub
End Class
