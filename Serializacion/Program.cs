using Microsoft.VisualBasic;
using Serializacion;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {

        Program program = new Program();
        program.GenerarFacturaTelecomunicacionesXml(program.LlenarFacturaTelecomunicaciones());
        //Console.WriteLine();
        //Console.ReadLine();
        program.GenerarFacturaCompraVentaXml(program.LlenarFacturaCompraVenta());

    }
    //serialización del objeto enviado
    public void SerializarObjetoCompraVenta(FacturaCompraVentaXml objet, List<DetalleFacturaCompraVenta>detalles)
    {
        XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
        XmlSerializer x = new XmlSerializer(objet.GetType());
        FileStream fileStream = File.Open("../../../facturaElectronicaCompraVenta.xml", FileMode.Create, FileAccess.Write);
        x.Serialize(fileStream, objet);
        fileStream.Close();
        XElement newDocXML = XElement.Load("../../../facturaElectronicaCompraVenta.xml");
        foreach (var item in detalles)
        {
            
            XElement newElement = new XElement("detalle",
            new XElement("actividadEconomica", item.actividadEconomica),
            new XElement("codigoProductoSin", item.codigoProductoSin),
            new XElement("codigoProducto", item.codigoProducto),
            new XElement("descripcion", item.descripcion),
            new XElement("cantidad", item.cantidad),
            new XElement("unidadMedida", item.unidadMedida),
            new XElement("precioUnitario",item.precioUnitario),
            new XElement("montoDescuento", item.montoDescuento),
            new XElement("subTotal", item.subTotal),
            new XElement("numeroSerie", new XAttribute(xsi + "nil", true)),
            new XElement("numeroImei", new XAttribute(xsi + "nil", true)));
            newDocXML.Add(newElement);
        }
        newDocXML.Save("../../../facturaElectronicaCompraVenta.xml");
        Console.WriteLine(newDocXML);
        Console.ReadLine();
    }
    public void SerializarObjetoTelecomunicaciones(FacturaTelecomunicacionesXml objet, List<DetalleFacturaTelecomunicaciones> detalles)
    {
        XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
        XmlSerializer x = new XmlSerializer(objet.GetType());
        FileStream fileStream = File.Open("../../../facturaElectronicaTelecomunicacion.xml", FileMode.Create, FileAccess.Write);
        x.Serialize(fileStream, objet);
        fileStream.Close();
        XElement newDocXML = XElement.Load("../../../facturaElectronicaTelecomunicacion.xml");
        foreach (var item in detalles)
        {

            XElement newElement = new XElement("detalle",
            new XElement("actividadEconomica", item.actividadEconomica),
            new XElement("codigoProductoSin", item.codigoProductoSin),
            new XElement("codigoProducto", item.codigoProducto),
            new XElement("descripcion", item.descripcion),
            new XElement("cantidad", item.cantidad),
            new XElement("unidadMedida", item.unidadMedida),
            new XElement("precioUnitario", item.precioUnitario),
            new XElement("montoDescuento", item.montoDescuento),
            new XElement("subTotal", item.subTotal),
            new XElement("numeroSerie", new XAttribute(xsi + "nil", true)),
            new XElement("numeroImei", new XAttribute(xsi + "nil", true)));
            newDocXML.Add(newElement);
        }
        newDocXML.Save("../../../facturaElectronicaTelecomunicacion.xml");
        Console.WriteLine(newDocXML);
        Console.ReadLine();
    }
    //llenado de datos ficticios en las facturas de telecom y com-ven
    public FacturaTelecomunicaciones LlenarFacturaTelecomunicaciones()
    {
        //lista de detalles factura
        List<FacturaDetalleGral> listaDetalles = new List<FacturaDetalleGral>();
        FacturaDetalleGral facturaDetalleGral = new FacturaDetalleGral();
        facturaDetalleGral.actividadEconomica = "451010";
        facturaDetalleGral.codigoProductoSin = 49711;
        facturaDetalleGral.codigoProducto = "POST - 137231";
        facturaDetalleGral.descripcion = "PAGO DE MES DE ABRIL DE FIBRA OPTICA";
        facturaDetalleGral.cantidad = 1;
        facturaDetalleGral.unidadMedida = 58;
        facturaDetalleGral.precioUnitario = 150;
        facturaDetalleGral.montoDescuento = null;
        facturaDetalleGral.subTotal = 150;
        listaDetalles.Add(facturaDetalleGral);
        //
        FacturaDetalleGral facturaDetalleGral1 = new FacturaDetalleGral();
        facturaDetalleGral1.actividadEconomica = "451010";
        facturaDetalleGral1.codigoProductoSin = 49111;
        facturaDetalleGral1.codigoProducto = "POST - 131231";
        facturaDetalleGral1.descripcion = "PAGO DE MES DE ABRIL DE POSTPAGO";
        facturaDetalleGral1.cantidad = 1;
        facturaDetalleGral1.unidadMedida = 58;
        facturaDetalleGral1.precioUnitario = 150;
        facturaDetalleGral1.montoDescuento = null;
        facturaDetalleGral1.subTotal = 150;
        listaDetalles.Add(facturaDetalleGral1);
        //
        FacturaTelecomunicaciones obj = new FacturaTelecomunicaciones();
        obj.nitEmisor = 1003579028;
        obj.razonSocialEmisor = "Carlos Loza";
        obj.municipio = "La Paz";
        obj.telefono = "2846005";
        obj.nitConjunto =null;
        obj.numeroFactura = 1;
        obj.cuf = "44AAEC00DBD34C81DFBDAB7C52067B9DA7A5E686A267A75AC82F24C74";
        obj.cufd = "BQUE+QytqQUDBKVUFOSVRPQkxVRFZNVFVJBMDAwMDAwM";
        obj.codigoSucursal = 0;
        obj.direccion = "AV.JORGE LOPEZ #123";
        obj.codigoPuntoVenta = 0;
        obj.fechaEmision = Convert.ToDateTime("2021 - 10 - 07T09: 55:46.414");
        obj.nombreRazonSocial = "Mi razon social";
        obj.codigoTipoDocumentoIdentidad = 1;
        obj.numeroDocumento = "5115889";
        obj.complemento = null;
        obj.codigoCliente = "51158891";
        obj.codigoMetodoPago = 1;
        obj.montoTotal = 150;
        obj.montoTotalSujetoIva = 150;
        obj.codigoModeda = 1;
        obj.tipoCambio = 1;
        obj.montoTotalMoneda = 150;
        obj.leyenda = "Ley N° 453: Tienes derecho a recibir información sobre las características y contenidos de los servicios que utilices.";
        obj.usuario = "Ricardo Mendez";
        obj.codigoDocumentoSector = 22;
        obj.detalles = listaDetalles;
        return obj;
    }
    
    //llenado de datos ficticios en las cabeceras de del xml de telecom y com-ven
    public CabeceraFacturaTelecomunicaciones LlenarCabeceraFacturaTelecomunicacionesXml (FacturaTelecomunicaciones factura)
    {
        CabeceraFacturaTelecomunicaciones cabecera = new CabeceraFacturaTelecomunicaciones();
        cabecera.nitEmisor = factura.nitEmisor;
        cabecera.razonSocialEmisor = factura.razonSocialEmisor;
        cabecera.municipio = factura.municipio;
        cabecera.telefono = factura.telefono;
        cabecera.nitConjunto = factura.nitConjunto;
        cabecera.numeroFactura = factura.numeroFactura;
        cabecera.cuf = factura.cuf;
        cabecera.cufd = factura.cufd;
        cabecera.codigoSucursal = factura.codigoSucursal;
        cabecera.direccion = factura.direccion;
        cabecera.codigoPuntoVenta = factura.codigoPuntoVenta;
        cabecera.fechaEmision = factura.fechaEmision;
        cabecera.nombreRazonSocial = factura.nombreRazonSocial;
        cabecera.codigoTipoDocumentoIdentidad = factura.codigoTipoDocumentoIdentidad;
        cabecera.numeroDocumento = factura.numeroDocumento;
        cabecera.complemento = factura.complemento;
        cabecera.codigoCliente = factura.codigoCliente;
        cabecera.codigoMetodoPago = factura.codigoMetodoPago;
        cabecera.numeroTarjeta = null;
        cabecera.montoTotal = factura.montoTotal;
        cabecera.montoTotalSujetoIva = factura.montoTotalSujetoIva;
        cabecera.codigoModeda = factura.codigoModeda;
        cabecera.tipoCambio = factura.tipoCambio;
        cabecera.montoTotalMoneda = factura.montoTotalMoneda;
        cabecera.montoGiftCard = null;
        cabecera.descuentoAdicional = null;
        cabecera.codigoExcepcion = null;
        cabecera.cafc = null;
        cabecera.leyenda = factura.leyenda;
        cabecera.usuario = factura.usuario;
        cabecera.codigoDocumentoSector = factura.codigoDocumentoSector;
        return cabecera;
    }
    
    
    //llenado de datos ficticios en los detalles de del xml de telecom y com-ven
    public List<DetalleFacturaTelecomunicaciones> LlenarDetalleFacturaTelecomunicacionesXml(List<FacturaDetalleGral> detalles)
    {
        List<DetalleFacturaTelecomunicaciones> listaDetalles = new List<DetalleFacturaTelecomunicaciones>();
        foreach (var item in detalles)
        {
            if (item.montoDescuento==null)
            {
                item.montoDescuento = 0;
            }
            DetalleFacturaTelecomunicaciones detalle = new DetalleFacturaTelecomunicaciones();
            detalle.actividadEconomica = item.actividadEconomica;
            detalle.codigoProductoSin = item.codigoProductoSin;
            detalle.codigoProducto = item.codigoProducto;
            detalle.descripcion = item.descripcion;
            detalle.cantidad = item.cantidad;
            detalle.unidadMedida = item.unidadMedida;
            detalle.precioUnitario = item.precioUnitario;
            detalle.montoDescuento = item.montoDescuento;
            detalle.subTotal = item.subTotal;
            detalle.numeroSerie = null;
            detalle.numeroImei = null;
            listaDetalles.Add(detalle);
        }
        return listaDetalles;
    }

    public CabeceraFacturaCompraVenta LlenarCabeceraFacturaCompraVentaXml(FacturaCompraVenta factura)
    {
        CabeceraFacturaCompraVenta cabecera = new CabeceraFacturaCompraVenta();
        cabecera.nitEmisor = factura.nitEmisor;
        cabecera.razonSocialEmisor = factura.razonSocialEmisor;
        cabecera.municipio = factura.municipio;
        cabecera.telefono = factura.telefono;
        cabecera.numeroFactura = factura.numeroFactura;
        cabecera.cuf = factura.cuf;
        cabecera.cufd = factura.cufd;
        cabecera.codigoSucursal = factura.codigoSucursal;
        cabecera.direccion = factura.direccion;
        cabecera.codigoPuntoVenta = factura.codigoPuntoVenta;
        cabecera.fechaEmision = factura.fechaEmision;
        cabecera.nombreRazonSocial = factura.nombreRazonSocial;
        cabecera.codigoTipoDocumentoIdentidad = factura.codigoTipoDocumentoIdentidad;
        cabecera.numeroDocumento = factura.numeroDocumento;
        cabecera.complemento = factura.complemento;
        cabecera.codigoCliente = factura.codigoCliente;
        cabecera.codigoMetodoPago = factura.codigoMetodoPago;
        cabecera.numeroTarjeta = null;
        cabecera.montoTotal = factura.montoTotal;
        cabecera.montoTotalSujetoIva = factura.montoTotalSujetoIva;
        cabecera.codigoModeda = factura.codigoModeda;
        cabecera.tipoCambio = factura.tipoCambio;
        cabecera.montoTotalMoneda = factura.montoTotalMoneda;
        cabecera.montoGiftCard = null;
        cabecera.descuentoAdicional = null;
        cabecera.codigoExcepcion = null;
        cabecera.cafc = factura.cafc;
        cabecera.leyenda = factura.leyenda;
        cabecera.usuario = factura.usuario;
        cabecera.codigoDocumentoSector = factura.codigoDocumentoSector;
        return cabecera;
    }
    public List<DetalleFacturaCompraVenta> LlenarDetalleFacturaCompraVentaXml(List<FacturaDetalleGral> detalles)
    {
        List<DetalleFacturaCompraVenta> listaDetalles = new List<DetalleFacturaCompraVenta>();
        foreach (var item in detalles)
        {
            if (item.montoDescuento == null)
            {
                item.montoDescuento = 0;
            }
            DetalleFacturaCompraVenta detalle = new DetalleFacturaCompraVenta();
            detalle.actividadEconomica = item.actividadEconomica;
            detalle.codigoProductoSin = item.codigoProductoSin;
            detalle.codigoProducto = item.codigoProducto;
            detalle.descripcion = item.descripcion;
            detalle.cantidad = item.cantidad;
            detalle.unidadMedida = item.unidadMedida;
            detalle.precioUnitario = item.precioUnitario;
            detalle.montoDescuento = item.montoDescuento;
            detalle.subTotal = item.subTotal;
            detalle.numeroSerie = null;
            detalle.numeroImei = null;
            listaDetalles.Add(detalle);
        }
        
        return listaDetalles;
    }
    public FacturaCompraVenta LlenarFacturaCompraVenta()
    {
        //lista de detalles factura
        List<FacturaDetalleGral> listaDetalles= new List<FacturaDetalleGral>();
        FacturaDetalleGral facturaDetalleGral= new FacturaDetalleGral();
        facturaDetalleGral.actividadEconomica = "451010";
        facturaDetalleGral.codigoProductoSin = 49111;
        facturaDetalleGral.codigoProducto = "JN-131231";
        facturaDetalleGral.descripcion = "JUGO DE NARANJA EN VASO";
        facturaDetalleGral.cantidad = 1;
        facturaDetalleGral.unidadMedida = 1;
        facturaDetalleGral.precioUnitario = 100;
        facturaDetalleGral.montoDescuento = null;
        facturaDetalleGral.subTotal = 100;
        listaDetalles.Add(facturaDetalleGral);
        //
        FacturaDetalleGral facturaDetalleGral1 = new FacturaDetalleGral();
        facturaDetalleGral1.actividadEconomica = "12345";
        facturaDetalleGral1.codigoProductoSin = 49856;
        facturaDetalleGral1.codigoProducto = "JN-131313";
        facturaDetalleGral1.descripcion = "JUGO DE NARANJA EN CAJA";
        facturaDetalleGral1.cantidad = 1;
        facturaDetalleGral1.unidadMedida = 1;
        facturaDetalleGral1.precioUnitario = 100;
        facturaDetalleGral1.montoDescuento = 20;
        facturaDetalleGral1.subTotal = 100;
        listaDetalles.Add(facturaDetalleGral1);
        //

        FacturaCompraVenta obj = new FacturaCompraVenta();
        obj.nitEmisor = 1003579028;
        obj.razonSocialEmisor = "Carlos Loza";
        obj.municipio = "La Paz";
        obj.telefono = "2846005";
        obj.numeroFactura = 1;
        obj.cuf = "44AAEC00DBD34C81DFBDAB7C52067B9DA7A5E686A267A75AC82F24C74";
        obj.cufd = "BQUE+QytqQUDBKVUFOSVRPQkxVRFZNVFVJBMDAwMDAwM";
        obj.codigoSucursal = 0;
        obj.direccion = "AV.JORGE LOPEZ #123";
        obj.codigoPuntoVenta = 0;
        obj.fechaEmision = Convert.ToDateTime("2021 - 10 - 07T09: 55:46.414");
        obj.nombreRazonSocial = "Mi razon social";
        obj.codigoTipoDocumentoIdentidad = 1;
        obj.numeroDocumento = "5115889";
        obj.complemento = null;
        obj.codigoCliente = "51158891";
        obj.codigoMetodoPago = 1;
        obj.montoTotal = 99;
        obj.montoTotalSujetoIva = 99;
        obj.codigoModeda = 1;
        obj.tipoCambio = 1;
        obj.montoTotalMoneda = 99;
        obj.cafc = null;
        obj.leyenda = "Ley N° 453: Tienes derecho a recibir información sobre las características y contenidos de los servicios que utilices.";
        obj.usuario = "pperez";
        obj.codigoDocumentoSector = 22;
        obj.detalles = listaDetalles;
        return obj;
    }
    //generando las facturas en formato xml de telecom y com-ven
    public void GenerarFacturaTelecomunicacionesXml(FacturaTelecomunicaciones factura)
    {
        Program program = new Program();
        FacturaTelecomunicacionesXml obj=new FacturaTelecomunicacionesXml();
        List<DetalleFacturaTelecomunicaciones> detalles = new List<DetalleFacturaTelecomunicaciones>();
        obj.cabecera= program.LlenarCabeceraFacturaTelecomunicacionesXml(factura);
        detalles = program.LlenarDetalleFacturaTelecomunicacionesXml(factura.detalles);
        program.SerializarObjetoTelecomunicaciones(obj, detalles);
    }
    public void GenerarFacturaCompraVentaXml(FacturaCompraVenta factura)
    {
        Program program = new Program();
        FacturaCompraVentaXml obj = new FacturaCompraVentaXml();
        List<DetalleFacturaCompraVenta> detalles = new List<DetalleFacturaCompraVenta>();
        obj.cabecera = program.LlenarCabeceraFacturaCompraVentaXml(factura);
        detalles = program.LlenarDetalleFacturaCompraVentaXml(factura.detalles);
        program.SerializarObjetoCompraVenta(obj,detalles);
    }
}

