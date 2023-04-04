Module Data

    'Definimos la lista de productos la cual va a estar llena de una vez
    Public listaProductos As New List(Of Producto) From {
        New Producto With {.codigoProducto = 1, .nombreProducto = "Arroz", .precioProducto = 2500},
        New Producto With {.codigoProducto = 2, .nombreProducto = "Frijoles", .precioProducto = 1500},
        New Producto With {.codigoProducto = 3, .nombreProducto = "Galletas", .precioProducto = 2000},
        New Producto With {.codigoProducto = 4, .nombreProducto = "Cereal", .precioProducto = 2700},
        New Producto With {.codigoProducto = 5, .nombreProducto = "Queso", .precioProducto = 3200}
    }

    'Definimos la lista de productosFactura
    Public listaProductoFactura As New List(Of ProductosFactura)

    'Definimos la lista de facturas
    Public listaFacturas As New List(Of Factura)

End Module
