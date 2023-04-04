Public Class Objetos

End Class

Public Class Producto

    Public codigoProducto As Integer
    Public nombreProducto As String
    Public precioProducto As Decimal

End Class

Public Class Factura
    Public codigoCliente As Integer
    Public identificacionCliente As String
    Public nombreCliente As String
    Public fechaFacturacin As Date
    'Public codigoProducto As Integer
    Public listaProductosAgregados As New List(Of ProductosFactura)
    'Public nombreProducto As String
    Public cantidadLineas As Integer
    Public precioTotalSinIVA As Decimal
    Public subTotalFactura As Decimal
    Public montoIVA As Decimal
    Public totalFactura As Decimal
End Class

Public Class ProductosFactura
    Public codigoProductoFactura As Integer
    Public nombreProductoFactura As String
    Public cantidadProductoFactura As Integer
    Public precioTotalSinIVA As Decimal
End Class
