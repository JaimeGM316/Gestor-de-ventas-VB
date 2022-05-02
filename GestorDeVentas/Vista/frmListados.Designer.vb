<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.NIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_VENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvArticulos
        '
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.DESCRIPCION, Me.FECHA_COMPRA, Me.PRECIO, Me.STOCK})
        Me.dgvArticulos.Location = New System.Drawing.Point(245, 26)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.RowTemplate.Height = 24
        Me.dgvArticulos.Size = New System.Drawing.Size(723, 195)
        Me.dgvArticulos.TabIndex = 0
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'FECHA_COMPRA
        '
        Me.FECHA_COMPRA.HeaderText = "FECHA_COMPRA"
        Me.FECHA_COMPRA.Name = "FECHA_COMPRA"
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        '
        'STOCK
        '
        Me.STOCK.HeaderText = "STOCK"
        Me.STOCK.Name = "STOCK"
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIF, Me.FECHA_VENTA, Me.NOMBRE, Me.APELLIDOS, Me.ARTICULO, Me.UNIDADES, Me.DataGridViewTextBoxColumn1, Me.IVA, Me.TOTAL_COMPRA})
        Me.dgvVentas.Location = New System.Drawing.Point(12, 291)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.Size = New System.Drawing.Size(1254, 323)
        Me.dgvVentas.TabIndex = 1
        '
        'NIF
        '
        Me.NIF.HeaderText = "NIF"
        Me.NIF.Name = "NIF"
        '
        'FECHA_VENTA
        '
        Me.FECHA_VENTA.HeaderText = "FECHA_VENTA"
        Me.FECHA_VENTA.Name = "FECHA_VENTA"
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'APELLIDOS
        '
        Me.APELLIDOS.HeaderText = "APELLIDOS"
        Me.APELLIDOS.Name = "APELLIDOS"
        '
        'ARTICULO
        '
        Me.ARTICULO.HeaderText = "ARTICULO"
        Me.ARTICULO.Name = "ARTICULO"
        '
        'UNIDADES
        '
        Me.UNIDADES.HeaderText = "UNIDADES"
        Me.UNIDADES.Name = "UNIDADES"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        '
        'TOTAL_COMPRA
        '
        Me.TOTAL_COMPRA.HeaderText = "TOTAL_COMPRA"
        Me.TOTAL_COMPRA.Name = "TOTAL_COMPRA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LISTADO DE VENTAS A CLIENTES DE LA EMPRESA SALVADOR"
        '
        'frmListados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 626)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListados"
        Me.Text = "frmListados"
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_COMPRA As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents STOCK As DataGridViewTextBoxColumn
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents NIF As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_VENTA As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As DataGridViewTextBoxColumn
    Friend WithEvents ARTICULO As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADES As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_COMPRA As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
