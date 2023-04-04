<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agregarFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbProductos = New System.Windows.Forms.ListBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarFactura = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbIVA = New System.Windows.Forms.Label()
        Me.lbSubtotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbClientes = New System.Windows.Forms.ListBox()
        Me.cbTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExportarXML = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnImportarXML = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.dgFacturas = New System.Windows.Forms.DataGridView()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevaFactura = New System.Windows.Forms.Button()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de facturación "
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(173, 33)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(200, 21)
        Me.cbProducto.TabIndex = 5
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(173, 132)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha.TabIndex = 6
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(173, 66)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(199, 20)
        Me.nudCantidad.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbProductos)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.cbProducto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.nudCantidad)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(710, 201)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'lbProductos
        '
        Me.lbProductos.FormattingEnabled = True
        Me.lbProductos.Location = New System.Drawing.Point(398, 33)
        Me.lbProductos.MultiColumn = True
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Size = New System.Drawing.Size(218, 121)
        Me.lbProductos.TabIndex = 11
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(26, 154)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(123, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregarFactura
        '
        Me.btnAgregarFactura.Location = New System.Drawing.Point(239, 553)
        Me.btnAgregarFactura.Name = "btnAgregarFactura"
        Me.btnAgregarFactura.Size = New System.Drawing.Size(147, 23)
        Me.btnAgregarFactura.TabIndex = 10
        Me.btnAgregarFactura.Text = "Agregar Factura"
        Me.btnAgregarFactura.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbCantidad)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lbTotal)
        Me.GroupBox3.Controls.Add(Me.lbIVA)
        Me.GroupBox3.Controls.Add(Me.lbSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 514)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 150)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resumen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Productos"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(111, 118)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(0, 13)
        Me.lbTotal.TabIndex = 5
        '
        'lbIVA
        '
        Me.lbIVA.AutoSize = True
        Me.lbIVA.Location = New System.Drawing.Point(111, 90)
        Me.lbIVA.Name = "lbIVA"
        Me.lbIVA.Size = New System.Drawing.Size(0, 13)
        Me.lbIVA.TabIndex = 4
        '
        'lbSubtotal
        '
        Me.lbSubtotal.AutoSize = True
        Me.lbSubtotal.Location = New System.Drawing.Point(111, 60)
        Me.lbSubtotal.Name = "lbSubtotal"
        Me.lbSubtotal.Size = New System.Drawing.Size(0, 13)
        Me.lbSubtotal.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Subtotal"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnActualizar)
        Me.GroupBox4.Controls.Add(Me.lbClientes)
        Me.GroupBox4.Controls.Add(Me.cbTipoIdentificacion)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.dtFecha)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnAgregarCliente)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtIdentificacion)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(710, 240)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Agregar Cliente"
        '
        'lbClientes
        '
        Me.lbClientes.FormattingEnabled = True
        Me.lbClientes.Location = New System.Drawing.Point(398, 33)
        Me.lbClientes.MultiColumn = True
        Me.lbClientes.Name = "lbClientes"
        Me.lbClientes.Size = New System.Drawing.Size(218, 121)
        Me.lbClientes.TabIndex = 10
        '
        'cbTipoIdentificacion
        '
        Me.cbTipoIdentificacion.FormattingEnabled = True
        Me.cbTipoIdentificacion.Location = New System.Drawing.Point(173, 33)
        Me.cbTipoIdentificacion.Name = "cbTipoIdentificacion"
        Me.cbTipoIdentificacion.Size = New System.Drawing.Size(200, 21)
        Me.cbTipoIdentificacion.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tipo de Identificación"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(26, 184)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(123, 23)
        Me.btnAgregarCliente.TabIndex = 6
        Me.btnAgregarCliente.Text = "Agregar Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(173, 99)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nombre"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(173, 64)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(200, 20)
        Me.txtIdentificacion.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Identificación"
        '
        'btnExportarXML
        '
        Me.btnExportarXML.Location = New System.Drawing.Point(239, 607)
        Me.btnExportarXML.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportarXML.Name = "btnExportarXML"
        Me.btnExportarXML.Size = New System.Drawing.Size(147, 23)
        Me.btnExportarXML.TabIndex = 13
        Me.btnExportarXML.Text = "Exportar Facturas a XML"
        Me.btnExportarXML.UseVisualStyleBackColor = True
        '
        'btnImportarXML
        '
        Me.btnImportarXML.Location = New System.Drawing.Point(239, 581)
        Me.btnImportarXML.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImportarXML.Name = "btnImportarXML"
        Me.btnImportarXML.Size = New System.Drawing.Size(147, 23)
        Me.btnImportarXML.TabIndex = 14
        Me.btnImportarXML.Text = "Importar Facturas a XML"
        Me.btnImportarXML.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'dgFacturas
        '
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturas.Location = New System.Drawing.Point(410, 514)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.Size = New System.Drawing.Size(327, 141)
        Me.dgFacturas.TabIndex = 15
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(111, 30)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(31, 13)
        Me.lbCantidad.TabIndex = 7
        Me.lbCantidad.Text = "Total"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(173, 184)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(123, 23)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar Cliente"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnNuevaFactura
        '
        Me.btnNuevaFactura.Location = New System.Drawing.Point(239, 524)
        Me.btnNuevaFactura.Name = "btnNuevaFactura"
        Me.btnNuevaFactura.Size = New System.Drawing.Size(147, 23)
        Me.btnNuevaFactura.TabIndex = 16
        Me.btnNuevaFactura.Text = "Iniciar nueva Factura"
        Me.btnNuevaFactura.UseVisualStyleBackColor = True
        '
        'agregarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 705)
        Me.Controls.Add(Me.btnNuevaFactura)
        Me.Controls.Add(Me.dgFacturas)
        Me.Controls.Add(Me.btnImportarXML)
        Me.Controls.Add(Me.btnExportarXML)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAgregarFactura)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "agregarFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarFactura"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAgregarFactura As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbTotal As Label
    Friend WithEvents lbIVA As Label
    Friend WithEvents lbSubtotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbTipoIdentificacion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbProductos As ListBox
    Friend WithEvents lbClientes As ListBox
    Friend WithEvents btnExportarXML As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnImportarXML As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents dgFacturas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCantidad As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnNuevaFactura As Button
End Class
