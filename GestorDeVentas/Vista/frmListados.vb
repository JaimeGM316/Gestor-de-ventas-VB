Imports System.IO
Public Class frmListados

    Private Sub frmListado_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim objr As New Logica
        For Each obj As Articulos In objr.ListarArticulos.Values
            Me.dgvArticulos.Rows.Add(obj.Codigo, obj.Descripcion, obj.FechaCompra, obj.PrecioCompra, obj.Stock)
        Next
        If File.Exists("Ventas.txt") Then
            For Each obj As Ventas In objr.ListasVentas
                Me.dgvVentas.Rows.Add(obj.Vnif, obj.FechaVenta, obj.Vnombre, obj.Vapellidos, obj.Descripcion, obj.Unidades, obj.PrecioVenta, obj.Iva, obj.TotalCompra)
            Next
        Else
            MessageBox.Show("No se ha realizado ninguna venta")
        End If

    End Sub
End Class