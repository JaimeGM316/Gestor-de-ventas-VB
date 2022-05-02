Public Class frmPrincipal
    'Load
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar combobox
        Dim objL As New Logica
        For Each objA As Articulos In objL.ListarArticulos.Values
            cbArticulos.Items.Add(objA.Descripcion)
        Next
    End Sub
    'Boton salir
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    'Mostrar cliente
    Private Sub mostrarCliente(ByVal sender As Object, ByVal e As EventArgs) Handles tbNif.KeyPress
        Dim objL As New Logica
        For Each obj As Clientes In objL.ListarClientes.Values
            If obj.Nif = tbNif.Text Then
                lbNombre.Text = obj.Nombre
                lbApellidos.Text = obj.Apellidos
            End If
        Next
    End Sub

    'Mostrar articulo
    Private Sub cbArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbArticulos.SelectedIndexChanged, tbUnidades.KeyPress
        Dim objL As New Logica
        For Each objC As Articulos In objL.ListarArticulos.Values
            If objC.Descripcion = cbArticulos.Text Then
                Dim precioVenta As Double = objC.PrecioCompra * 0.05 + objC.PrecioCompra
                lbPrecio.Text = CType(precioVenta, String)
                lbCodigo.Text = CType(objC.Codigo, String)
                lbStock.Text = CType(objC.Stock, String)
                If tbUnidades.Text <> "" Then
                    lbSubtotal.Text = CType(CType(tbUnidades.Text, Double) * precioVenta, String)
                    lbIVA.Text = CType(CType(lbSubtotal.Text, Double) * 0.21, String)
                    lbTotal.Text = CType(CType(lbIVA.Text, Double) + CType(lbSubtotal.Text, Double), String)
                    'Cambio de stock
                    objC.Stock = objC.Stock - CType(tbUnidades.Text, Integer)
                End If
            End If
        Next
    End Sub

    'Guardamos la venta y los cambios en el stock
    Private Sub btGrabar_Click(sender As Object, e As EventArgs) Handles btGrabar.Click
        Dim nif As String = tbNif.Text
        Dim fechaVenta As Date = dtpFecha.Value
        Dim nombre As String = lbNombre.Text
        Dim apellidos As String = lbApellidos.Text
        Dim descripcion As String = cbArticulos.Text
        Dim unidades As Integer = CType(tbUnidades.Text, Integer)
        Dim precioVenta As Double = CType(lbPrecio.Text, Double)
        Dim iva As Double = CType(lbIVA.Text, Double)
        Dim totalCompra As Double = CType(lbTotal.Text, Double)
        Dim vent As New Ventas(nif, fechaVenta, nombre, apellidos, descripcion, unidades, precioVenta, iva, totalCompra)
        Logica.listaVentas.Add(vent)
        Dim obj As New Logica
        obj.guardarVentas()
        obj.guardarArticulos()
    End Sub

    'Validar NIF
    Dim existeBase As Boolean
    Private Sub tbNif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNif.KeyPress

        If tbNif.Text.Length < 8 Then
            If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf tbNif.Text.Length = 8 Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        ElseIf tbNif.Text.Length > 8 Then
            If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If


    End Sub
    Private Sub tbNif_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles tbNif.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim objL As New Logica
            Dim objc As New Clientes

            If tbNif.TextLength <> 9 Then
                MessageBox.Show("Termina de escribir el NIF")
            ElseIf objL.ValidarNIF(tbNif.Text) = "MAL" Then
                MessageBox.Show("Este NIF no existe")
            End If
        End If
    End Sub

    'Validar unidades
    Private Sub tbUnidades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUnidades.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Activar boton grabar
    Private Sub ActivarBoton(ByVal sender As Object, ByVal e As EventArgs) Handles tbNif.TextChanged, lbNombre.TextChanged, lbApellidos.TextChanged, tbUnidades.TextChanged, lbPrecio.TextChanged, lbTotal.TextChanged
        Dim cont As Integer = 0
        If tbNif.TextLength = 9 Then
            cont = cont + 1
        End If
        If lbNombre.Text <> "" Then
            cont = cont + 1
        End If
        If lbApellidos.Text <> "" Then
            cont = cont + 1
        End If
        If tbUnidades.Text <> "" Then
            cont = cont + 1
        End If
        If lbPrecio.Text <> "" Then
            cont = cont + 1
        End If
        If lbTotal.Text <> "" Then
            cont = cont + 1
        End If
        If cont = 6 Then
            btGrabar.Enabled = True
        Else
            btGrabar.Enabled = False
        End If
    End Sub


End Class