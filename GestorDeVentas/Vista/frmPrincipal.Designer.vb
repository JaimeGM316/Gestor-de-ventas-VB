<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.tbNif = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lbApellidos = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbSubtotal = New System.Windows.Forms.Label()
        Me.lbIVA = New System.Windows.Forms.Label()
        Me.lbStock = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.cbArticulos = New System.Windows.Forms.ComboBox()
        Me.tbUnidades = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btGrabar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNif
        '
        Me.tbNif.Location = New System.Drawing.Point(57, 12)
        Me.tbNif.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNif.MaxLength = 9
        Me.tbNif.Name = "tbNif"
        Me.tbNif.Size = New System.Drawing.Size(132, 22)
        Me.tbNif.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FECHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "APELLIDOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DESCRIPCIÓN ARTICULO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.lbApellidos)
        Me.Panel1.Controls.Add(Me.lbNombre)
        Me.Panel1.Controls.Add(Me.tbNif)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 101)
        Me.Panel1.TabIndex = 6
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(297, 12)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(299, 22)
        Me.dtpFecha.TabIndex = 17
        '
        'lbApellidos
        '
        Me.lbApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbApellidos.Location = New System.Drawing.Point(408, 59)
        Me.lbApellidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbApellidos.Name = "lbApellidos"
        Me.lbApellidos.Size = New System.Drawing.Size(257, 25)
        Me.lbApellidos.TabIndex = 16
        Me.lbApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbNombre
        '
        Me.lbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbNombre.Location = New System.Drawing.Point(97, 59)
        Me.lbNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(192, 25)
        Me.lbNombre.TabIndex = 15
        Me.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbTotal)
        Me.Panel2.Controls.Add(Me.lbSubtotal)
        Me.Panel2.Controls.Add(Me.lbIVA)
        Me.Panel2.Controls.Add(Me.lbStock)
        Me.Panel2.Controls.Add(Me.lbCodigo)
        Me.Panel2.Controls.Add(Me.lbPrecio)
        Me.Panel2.Controls.Add(Me.cbArticulos)
        Me.Panel2.Controls.Add(Me.tbUnidades)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(16, 123)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 287)
        Me.Panel2.TabIndex = 7
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbTotal.Location = New System.Drawing.Point(791, 106)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(148, 25)
        Me.lbTotal.TabIndex = 23
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSubtotal
        '
        Me.lbSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbSubtotal.Location = New System.Drawing.Point(607, 50)
        Me.lbSubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSubtotal.Name = "lbSubtotal"
        Me.lbSubtotal.Size = New System.Drawing.Size(148, 25)
        Me.lbSubtotal.TabIndex = 22
        Me.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbIVA
        '
        Me.lbIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbIVA.Location = New System.Drawing.Point(855, 50)
        Me.lbIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbIVA.Name = "lbIVA"
        Me.lbIVA.Size = New System.Drawing.Size(84, 25)
        Me.lbIVA.TabIndex = 21
        Me.lbIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbStock
        '
        Me.lbStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbStock.Location = New System.Drawing.Point(932, 11)
        Me.lbStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStock.Name = "lbStock"
        Me.lbStock.Size = New System.Drawing.Size(84, 25)
        Me.lbStock.TabIndex = 20
        Me.lbStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCodigo
        '
        Me.lbCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbCodigo.Location = New System.Drawing.Point(763, 11)
        Me.lbCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(84, 25)
        Me.lbCodigo.TabIndex = 19
        Me.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbPrecio
        '
        Me.lbPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbPrecio.Location = New System.Drawing.Point(584, 11)
        Me.lbPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(84, 25)
        Me.lbPrecio.TabIndex = 18
        Me.lbPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbArticulos
        '
        Me.cbArticulos.FormattingEnabled = True
        Me.cbArticulos.Location = New System.Drawing.Point(21, 47)
        Me.cbArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.cbArticulos.Name = "cbArticulos"
        Me.cbArticulos.Size = New System.Drawing.Size(469, 24)
        Me.cbArticulos.TabIndex = 14
        '
        'tbUnidades
        '
        Me.tbUnidades.Location = New System.Drawing.Point(412, 11)
        Me.tbUnidades.Margin = New System.Windows.Forms.Padding(4)
        Me.tbUnidades.Name = "tbUnidades"
        Me.tbUnidades.Size = New System.Drawing.Size(79, 22)
        Me.tbUnidades.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(661, 114)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "TOTAL COMPRA"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(784, 59)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "IVA 21%"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(513, 57)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "SUBTOTAL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(867, 15)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "STOCK"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(689, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "CÓDIGO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(513, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "PRECIO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "UNIDADES"
        '
        'btGrabar
        '
        Me.btGrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btGrabar.Location = New System.Drawing.Point(739, 15)
        Me.btGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btGrabar.Name = "btGrabar"
        Me.btGrabar.Size = New System.Drawing.Size(124, 101)
        Me.btGrabar.TabIndex = 8
        Me.btGrabar.Text = "GRABAR VENTA"
        Me.btGrabar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(887, 15)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 101)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1060, 423)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btGrabar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbNif As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lbApellidos As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbTotal As Label
    Friend WithEvents lbSubtotal As Label
    Friend WithEvents lbIVA As Label
    Friend WithEvents lbStock As Label
    Friend WithEvents lbCodigo As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents cbArticulos As ComboBox
    Friend WithEvents tbUnidades As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btGrabar As Button
    Friend WithEvents Button2 As Button
End Class
