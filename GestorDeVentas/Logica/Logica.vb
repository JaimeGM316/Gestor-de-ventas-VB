Imports System.IO
Public Class Logica


    'Lista clientes
    Public Shared listaClientes As New Dictionary(Of String, Clientes)
    Public Function ListarClientes() As Dictionary(Of String, Clientes)
        Return listaClientes
    End Function

    'Lista articulos
    Public Shared listaArticulos As New Dictionary(Of String, Articulos)
    Public Function ListarArticulos() As Dictionary(Of String, Articulos)
        Return listaArticulos
    End Function

    'Lista ventas
    Public Shared listaVentas As New List(Of Ventas)
    Public Function ListasVentas() As List(Of Ventas)
        Return listaVentas
    End Function

    'Leer clientes
    Public Function leerClientes() As Boolean
        Try
            If File.Exists("Clientes.txt") Then
                Dim sr As New StreamReader("Clientes.txt")
                Dim linea As String = Nothing
                Do While Not sr.EndOfStream
                    Dim obj As New Clientes
                    linea = sr.ReadLine
                    obj.Nif = Split(linea, "-")(0)
                    obj.Nombre = Split(linea, "-")(1)
                    obj.Apellidos = Split(linea, "-")(2)
                    obj.Telefono = CType(Split(linea, "-")(3), Integer)
                    obj.Ciudad = Split(linea, "-")(4)
                    listaClientes.Add(obj.Nif, obj)
                Loop
                sr.Close()
                'MessageBox.Show("Leído")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al leer")
            Return Nothing
        End Try
    End Function

    'Leer articulos
    Public Function leerArticulos() As Boolean
        Try
            If File.Exists("Articulos.txt") Then
                Dim sr As New StreamReader("Articulos.txt")
                Dim linea As String = Nothing
                Do While Not sr.EndOfStream
                    Dim obj As New Articulos
                    linea = sr.ReadLine
                    obj.Codigo = Split(linea, "-")(0)
                    obj.Descripcion = Split(linea, "-")(1)
                    obj.FechaCompra = CType(Split(linea, "-")(2), Date)
                    obj.PrecioCompra = CType(Split(linea, "-")(3), Decimal)
                    obj.Stock = CType(Split(linea, "-")(4), Integer)
                    listaArticulos.Add(obj.Codigo, obj)
                Loop
                sr.Close()
                'MessageBox.Show("Leído")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al leer")
            Return Nothing
        End Try
    End Function

    'Leer ventas
    Public Function leerVentas() As Boolean
        Try
            If File.Exists("Ventas.txt") Then
                Dim sr As New StreamReader("Ventas.txt")
                Dim linea As String = Nothing
                Do While Not sr.EndOfStream
                    Dim obj As New Ventas
                    linea = sr.ReadLine
                    obj.Vnif = Split(linea, "-")(0)
                    obj.FechaVenta = CType(Split(linea, "-")(1), Date)
                    obj.Vnombre = Split(linea, "-")(2)
                    obj.Vapellidos = Split(linea, "-")(3)
                    obj.Descripcion = Split(linea, "-")(4)
                    obj.Unidades = CType(Split(linea, "-")(5), Integer)
                    obj.PrecioVenta = CType(Split(linea, "-")(6), Double)
                    obj.Iva = CType(Split(linea, "-")(7), Double)
                    obj.TotalCompra = CType(Split(linea, "-")(8), Double)
                    listaVentas.Add(obj)
                Loop
                sr.Close()
                'MessageBox.Show("Leído")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al leer")
            Return Nothing
        End Try
    End Function

    'Guardar articulos
    Public Function guardarArticulos() As Boolean
        Try
            Dim sw As New StreamWriter("Articulos.txt")
            For Each socio In listaArticulos
                sw.WriteLine(socio.Value.Codigo & "-" &
                             socio.Value.Descripcion & "-" & socio.Value.FechaCompra & "-" &
                             socio.Value.PrecioCompra & "-" & socio.Value.Stock)
            Next
            sw.Close()
            MessageBox.Show("Archivo guardado")
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar")
            Return False
        End Try
    End Function

    'Guardar ventas
    Public Function guardarVentas() As Boolean
        Try
            Dim sw As New StreamWriter("Ventas.txt")
            For Each socio In listaVentas
                sw.WriteLine(socio.Vnif & "-" &
                             socio.FechaVenta & "-" & socio.Vnombre & "-" &
                             socio.Vapellidos & "-" & socio.Descripcion & "-" &
                             socio.Unidades & "-" & socio.PrecioVenta & "-" &
                             socio.Iva & "-" & socio.TotalCompra)
            Next
            sw.Close()
            MessageBox.Show("Archivo guardado")
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al guardar")
            Return False
        End Try
    End Function

    'Validar NIF
    Public Function ValidarNIF(ByVal NIF As String) As String
        Dim Tabla() As String = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"}
        Dim Result As Double
        Dim numero As Integer
        numero = CType(NIF.Remove(NIF.Length - 1), Integer)
        Result = ((Int(numero / 23)) * 23)
        Result = -Result + numero
        Dim UltCaracter As String
        Dim Caracter As String
        UltCaracter = NIF.Substring(NIF.Length - 1)
        Caracter = Tabla(CType(Result, Integer))
        If UltCaracter = Caracter Then
            NIF = NIF
        Else
            NIF = "MAL"
        End If
        Return NIF
    End Function
    Public Sub New()

    End Sub
End Class
