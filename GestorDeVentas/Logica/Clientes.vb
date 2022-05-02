Public Class Clientes
    Dim _nif As String
    Dim _nombre As String
    Dim _apellidos As String
    Dim _telefono As Integer
    Dim _ciudad As String

    Public Sub New()

    End Sub
    Public Sub New(_nif As String, _nombre As String, _apellidos As String, _telefono As Integer, _ciudad As String)
        Me._nif = _nif
        Me._nombre = _nombre
        Me._apellidos = _apellidos
        Me._telefono = _telefono
        Me._ciudad = _ciudad
    End Sub

    Public Property Nif As String
        Get
            Return _nif
        End Get
        Set(value As String)
            _nif = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _ciudad
        End Get
        Set(value As String)
            _ciudad = value
        End Set
    End Property
End Class
