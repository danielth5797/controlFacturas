Imports System.Xml
Imports System.IO


Public Class agregarFactura

    Dim arTipoIdentificacion = {"Nacional", "DIMEX", "Pasaporte"}

    'Clientes
    Dim codigoCliente As Integer = 0
    Dim tipoIdentificacion As String
    Dim identificacionCliente As String
    Dim nombreCliente As String
    Dim fechaFacturacin As Date

    'Productos
    Dim linea As Integer = 0
    Dim codigoProducto As Integer
    'Public listaProductosFactura()
    Dim nombreProducto As String
    Dim cantidadProducto As Integer
    Dim precioProducto As Decimal
    Dim precioTotalSinIVA As Decimal

    'Resumen
    Dim cantidadLineas As Integer
    Dim subTotalFactura As Decimal
    Dim montoIVA As Decimal
    Dim totalFactura As Decimal

    'En el boton de agregar factura es donde voy a crear el objeto y meter todas las variables en 'el

    Private Sub agregarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'Limitamos el NumericUpDown
            nudCantidad.Maximum = 5

            'El boton de agregar productos se va a habilitar hasta que se anada un cliente
            btnAgregar.Enabled = False
            'El boton actualizar cliente se va a habilitar hasta que se anada un cliente
            btnActualizar.Enabled = False

            For Each objProducto As Producto In listaProductos
                cbProducto.Items.Add(objProducto.nombreProducto.ToString())
            Next
            cbProducto.SelectedIndex = 0

            cbTipoIdentificacion.Items.AddRange(arTipoIdentificacion)
            cbTipoIdentificacion.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("No hay clientes en el sistema para generar una factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cbTipoIdentificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoIdentificacion.SelectedIndexChanged
        If cbTipoIdentificacion.SelectedIndex = 0 Then
            txtIdentificacion.MaxLength = 9
        ElseIf cbTipoIdentificacion.SelectedIndex = 1 Then
            txtIdentificacion.MaxLength = 13
        ElseIf cbTipoIdentificacion.SelectedIndex = 2 Then
            txtIdentificacion.MaxLength = 9
        End If

    End Sub

    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Digite solamente números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click

        Try

            If txtIdentificacion.TextLength = 0 Or txtNombre.TextLength = 0 Then
                MessageBox.Show("Debe ingresar documento de identificación y nombre válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbTipoIdentificacion.SelectedIndex = 0 And txtIdentificacion.TextLength < 9 Then
                MessageBox.Show("Ingrese un número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbTipoIdentificacion.SelectedIndex = 1 And txtIdentificacion.TextLength < 13 Then
                MessageBox.Show("Ingrese un número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbTipoIdentificacion.SelectedIndex = 2 And txtIdentificacion.TextLength < 9 Then
                MessageBox.Show("Ingrese un número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                codigoCliente = codigoCliente + 1
                tipoIdentificacion = cbTipoIdentificacion.Text
                identificacionCliente = txtIdentificacion.Text
                nombreCliente = txtNombre.Text
                fechaFacturacin = dtFecha.Value

                btnAgregarCliente.Enabled = False 'Se habilitan nuevamente al momento de apretar en agregar factura
                'cbTipoIdentificacion.Enabled = False
                'txtIdentificacion.Enabled = False
                'txtNombre.Enabled = False
                'dtFecha.Enabled = False

                btnAgregar.Enabled = True
                btnActualizar.Enabled = True

                lbClientes.Items.Add(codigoCliente)
                lbClientes.Items.Add(tipoIdentificacion)
                lbClientes.Items.Add(identificacionCliente)
                lbClientes.Items.Add(nombreCliente)
                lbClientes.Items.Add(fechaFacturacin.ToString())

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If cbProducto.Text = "" Or nudCantidad.Value.ToString() = "0" Then
                MessageBox.Show("Debe elegir un producto y una cantidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                linea = linea + 1

                For Each objProducto As Producto In listaProductos
                    If objProducto.nombreProducto = cbProducto.Text Then
                        codigoProducto = objProducto.codigoProducto
                        nombreProducto = objProducto.nombreProducto
                        precioProducto = objProducto.precioProducto
                        Exit For
                    End If
                Next

                cantidadProducto = nudCantidad.Value

                precioTotalSinIVA = precioProducto * cantidadProducto

                'Instanciamos un productoFactura
                'Cada vez que agregamos un producto, este se agrega a la lista de productosfactura
                'La lista de productofactura se va a limpiar al agregar una factura a la listafacturas, sin embargo dentro de listafactura ya va 
                'aparecer la lista de productosfactura

                Dim prodFactura As New ProductosFactura

                prodFactura.codigoProductoFactura = codigoProducto
                prodFactura.nombreProductoFactura = nombreProducto
                prodFactura.cantidadProductoFactura = cantidadProducto
                prodFactura.precioTotalSinIVA = precioTotalSinIVA

                listaProductoFactura.Add(prodFactura)

                'Agregamos la informacion en el listbox
                lbProductos.Items.Add(linea)
                lbProductos.Items.Add(codigoProducto)
                lbProductos.Items.Add(nombreProducto)
                lbProductos.Items.Add(cantidadProducto)
                lbProductos.Items.Add(precioTotalSinIVA)

                'Aqui calculamos y actualizamos los valores del Resumen
                subTotalFactura = CalcularSubTotal()
                montoIVA = CalcularIVA(subTotalFactura)
                totalFactura = CalcularTotalFactura(subTotalFactura, montoIVA)

                nudCantidad.Value = 0

                lbCantidad.Text = listaProductoFactura.Count.ToString
                lbSubtotal.Text = subTotalFactura.ToString()
                lbIVA.Text = montoIVA.ToString()
                lbTotal.Text = totalFactura.ToString()

            End If



        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function CalcularSubTotal()

        Dim subTotal As Decimal

        For Each objProdFac As ProductosFactura In listaProductoFactura
            subTotal = subTotal + objProdFac.precioTotalSinIVA
        Next

        Return subTotal

    End Function

    Function CalcularIVA(subTotal As Decimal)

        Dim iva As Decimal
        iva = subTotal * 0.13
        Return iva

    End Function

    Function CalcularTotalFactura(subtotal As Decimal, iva As Decimal)

        Dim total As Decimal
        total = subtotal + iva
        Return total

    End Function

    Private Sub btnAgregarFactura_Click(sender As Object, e As EventArgs) Handles btnAgregarFactura.Click

        Try

            Dim nuevaFactura As New Factura

            nuevaFactura.codigoCliente = codigoCliente
            nuevaFactura.identificacionCliente = identificacionCliente
            nuevaFactura.nombreCliente = nombreCliente
            nuevaFactura.fechaFacturacin = fechaFacturacin

            For Each objProdFact As ProductosFactura In listaProductoFactura
                nuevaFactura.listaProductosAgregados.Add(objProdFact)
            Next

            nuevaFactura.cantidadLineas = listaProductoFactura.Count 'El n'umero de lineas que haya en la lista de productos agregados
            nuevaFactura.precioTotalSinIVA = precioTotalSinIVA
            nuevaFactura.subTotalFactura = subTotalFactura
            nuevaFactura.montoIVA = montoIVA
            nuevaFactura.totalFactura = totalFactura

            listaFacturas.Add(nuevaFactura)

            CargaTabla()

            'Ahora vaciamos todos los campos del formulario
            cbTipoIdentificacion.SelectedIndex = 0
            txtIdentificacion.Text = ""
            txtNombre.Text = ""
            dtFecha.Value = Date.Today
            cbProducto.SelectedIndex = 0
            nudCantidad.Value = 0
            lbSubtotal.Text = ""
            lbIVA.Text = ""
            lbTotal.Text = ""
            btnAgregarCliente.Enabled = True
            lbClientes.Items.Clear()
            lbProductos.Items.Clear()
            listaProductoFactura.Clear()

            btnAgregarCliente.Enabled = True 'Se habilitan nuevamente al momento de apretar en agregar factura

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportarXML_Click(sender As Object, e As EventArgs) Handles btnExportarXML.Click
        Try

            If listaFacturas.Count > 2 Then

                SaveFileDialog1.Title = "Exportar archivo XML"
                SaveFileDialog1.Filter = "XML|*.xml"

                If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    Dim urlArchivo = SaveFileDialog1.FileName

                    Dim config As New XmlWriterSettings()

                    config.Indent = True

                    Using writer As XmlWriter = XmlWriter.Create(urlArchivo, config)

                        'Iniciamos el documento
                        writer.WriteStartDocument()

                        'El primer elemento: Lista de Facturas
                        writer.WriteStartElement("ListaFacturas")

                        'Recorremos la lista de las facturas
                        For Each objFactura As Factura In listaFacturas

                            'Escribo el Tag Factura
                            writer.WriteStartElement("Factura")
                            'Los atributos
                            writer.WriteElementString("codigoCliente", objFactura.codigoCliente)
                            writer.WriteElementString("identificacionCliente", objFactura.identificacionCliente)
                            writer.WriteElementString("nombreCliente", objFactura.nombreCliente)
                            writer.WriteElementString("fechaFacturacin", objFactura.fechaFacturacin)

                            writer.WriteStartElement("ListaProductosAgregados")
                            If objFactura.listaProductosAgregados.Count > 0 Then
                                For Each objProd As ProductosFactura In objFactura.listaProductosAgregados
                                    writer.WriteStartElement("Productos")
                                    writer.WriteElementString("codigoProductoFactura", objProd.codigoProductoFactura)
                                    writer.WriteElementString("nombreProductoFactura", objProd.nombreProductoFactura)
                                    writer.WriteElementString("cantidadProductoFactura", objProd.cantidadProductoFactura)
                                    writer.WriteElementString("precioTotalSinIVA", objProd.precioTotalSinIVA)
                                    writer.WriteEndElement()
                                Next
                            End If
                            'Cierro el Tag ListaProductosAgregados
                            writer.WriteEndElement()

                            'Demas atributos faltantes
                            writer.WriteElementString("cantidadLineas", objFactura.cantidadLineas)
                            writer.WriteElementString("precioTotalSinIVA", objFactura.precioTotalSinIVA)
                            writer.WriteElementString("subTotalFactura", objFactura.subTotalFactura)
                            writer.WriteElementString("montoIVA", objFactura.montoIVA)
                            writer.WriteElementString("totalFactura", objFactura.totalFactura)

                            'Cierro el Tag Factura
                            writer.WriteEndElement()

                        Next

                        'Cierro el elemento de ListaFacturas
                        writer.WriteEndElement()

                        'Cierro el documento
                        writer.WriteEndDocument()

                    End Using

                End If


                MessageBox.Show("La exportación ha sido exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Se requiere un mínimo de 3 facturas para exportar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show("Debe colocar al menos el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImportarXML_Click(sender As Object, e As EventArgs) Handles btnImportarXML.Click

        Try

            OpenFileDialog1.Title = "Seleccione un archivo XML"
            OpenFileDialog1.Filter = "XML|*.xml"

            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                listaFacturas.Clear()

                Dim urlArchivo = OpenFileDialog1.FileName

                Dim data As New FileStream(urlArchivo, FileMode.Open, FileAccess.Read)

                Dim documentoXML As New XmlDataDocument()
                documentoXML.Load(data)

                Dim listaNodoXML As XmlNodeList

                listaNodoXML = documentoXML.GetElementsByTagName("Factura")

                For Each nodo As XmlNode In listaNodoXML

                    Dim obj As New Factura

                    'Agregamos los atributos
                    obj.codigoCliente = nodo.SelectSingleNode("codigoCliente").InnerText
                    obj.identificacionCliente = nodo.SelectSingleNode("identificacionCliente").InnerText
                    obj.nombreCliente = nodo.SelectSingleNode("nombreCliente").InnerText
                    obj.fechaFacturacin = nodo.SelectSingleNode("fechaFacturacin").InnerText

                    'Agregamos los productosFactura
                    Dim listaProductosXML = nodo.SelectNodes("listaProductosAgregados/ProductosFactura")


                    For Each nodoProducto As XmlNode In listaProductosXML

                        Dim objProd As New ProductosFactura
                        objProd.codigoProductoFactura = nodoProducto.SelectSingleNode("codigoProductoFactura").InnerText
                        objProd.nombreProductoFactura = nodoProducto.SelectSingleNode("nombreProductoFactura").InnerText
                        objProd.cantidadProductoFactura = nodoProducto.SelectSingleNode("cantidadProductoFactura").InnerText
                        objProd.precioTotalSinIVA = Decimal.Parse(nodoProducto.SelectSingleNode("precioTotalSinIVA").InnerText)

                        obj.listaProductosAgregados.Add(objProd)

                    Next

                    obj.cantidadLineas = Decimal.Parse(nodo.SelectSingleNode("cantidadLineas").InnerText)
                    obj.precioTotalSinIVA = Decimal.Parse(nodo.SelectSingleNode("precioTotalSinIVA").InnerText)
                    obj.subTotalFactura = Decimal.Parse(nodo.SelectSingleNode("subTotalFactura").InnerText)
                    obj.montoIVA = Decimal.Parse(nodo.SelectSingleNode("montoIVA").InnerText)
                    obj.totalFactura = Decimal.Parse(nodo.SelectSingleNode("totalFactura").InnerText)

                    listaFacturas.Add(obj)

                Next

                CargaTabla()

                MessageBox.Show("La importación ha sido exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        Catch ex As Exception
            MessageBox.Show("Debe colocar al menos el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CargaTabla()
        Try
            'instanciar una datatable
            Dim tabla As New DataTable

            'definimos las columnas
            tabla.Columns.Add("Código Cliente")
            tabla.Columns.Add("Identificación cliente")
            tabla.Columns.Add("Nombre")
            tabla.Columns.Add("Fecha de facturación")
            'Aqui tengo que meter la cantidad de lineas, suma de la cantidad de productos
            tabla.Columns.Add("cantidadLineas")
            tabla.Columns.Add("Subtotal")
            tabla.Columns.Add("IVA")
            tabla.Columns.Add("Total")

            If listaFacturas.Count > 0 Then
                For Each objFactura As Factura In listaFacturas
                    tabla.Rows.Add(objFactura.codigoCliente, objFactura.identificacionCliente, objFactura.nombreCliente, objFactura.fechaFacturacin.ToString("dd/MM/yyyy"), objFactura.cantidadLineas, objFactura.subTotalFactura, objFactura.montoIVA, objFactura.totalFactura)
                Next

                dgFacturas.Columns.Clear()

                'asingar los valores al dataGridView
                dgFacturas.DataSource = tabla

            Else
                MessageBox.Show("No hay elementos que mostrar en la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Este boton permite cambiar los valores del cliente sin necesidad de hacer una nueva factura
    'no cambia el codigo cliente para la factura que se vaya a agregar en el momento
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try

            If txtIdentificacion.TextLength = 0 Or txtNombre.TextLength = 0 Then
                MessageBox.Show("Debe ingresar documento de identificación y nombre válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbTipoIdentificacion.SelectedIndex = 0 And txtIdentificacion.TextLength < 9 Then
                MessageBox.Show("Ingrese un número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbTipoIdentificacion.SelectedIndex = 1 And txtIdentificacion.TextLength < 13 Then
                MessageBox.Show("Ingrese un número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbTipoIdentificacion.SelectedIndex = 2 And txtIdentificacion.TextLength < 9 Then
                MessageBox.Show("Ingrese un número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                tipoIdentificacion = cbTipoIdentificacion.Text
                identificacionCliente = txtIdentificacion.Text
                nombreCliente = txtNombre.Text
                fechaFacturacin = dtFecha.Value

                'cbTipoIdentificacion.Enabled = False
                'txtIdentificacion.Enabled = False
                'txtNombre.Enabled = False
                'dtFecha.Enabled = False

                btnAgregar.Enabled = True

                lbClientes.Items.Clear()

                lbClientes.Items.Add(codigoCliente)
                lbClientes.Items.Add(tipoIdentificacion)
                lbClientes.Items.Add(identificacionCliente)
                lbClientes.Items.Add(nombreCliente)
                lbClientes.Items.Add(fechaFacturacin.ToString())

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNuevaFactura_Click(sender As Object, e As EventArgs) Handles btnNuevaFactura.Click

        cbTipoIdentificacion.SelectedIndex = 0
        txtIdentificacion.Text = ""
        txtNombre.Text = ""
        dtFecha.Value = Date.Today
        cbProducto.SelectedIndex = 0
        nudCantidad.Value = 0
        lbCantidad.Text = ""
        lbSubtotal.Text = ""
        lbIVA.Text = ""
        lbTotal.Text = ""
        btnAgregarCliente.Enabled = True
        lbClientes.Items.Clear()
        lbProductos.Items.Clear()
        listaProductoFactura.Clear()

        btnAgregarCliente.Enabled = True
        btnActualizar.Enabled = False

    End Sub


End Class
