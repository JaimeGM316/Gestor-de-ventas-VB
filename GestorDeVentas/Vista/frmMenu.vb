Public Class frmMenu
    Private Sub VENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTASToolStripMenuItem.Click
        Dim unform As New frmPrincipal
        unform.Show()
    End Sub

    Private Sub LISTADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADOSToolStripMenuItem.Click
        Dim unform As New frmListados
        unform.Show()
    End Sub

    Private Sub SALIDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIDAToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Cargar datos
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New Logica
        obj.leerClientes()
        obj.leerArticulos()
        obj.leerVentas()
    End Sub
End Class