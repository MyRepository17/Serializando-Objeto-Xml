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
        //program.GenerarFacturaTelecomunicacionesXml(program.LlenarFacturaTelecomunicaciones());
        //Console.WriteLine();
        //Console.ReadLine();
        program.GenerarFacturaCompraVentaXml(program.LlenarFacturaCompraVenta());

    }
    //serialización del objeto enviado
    public void SerializarObjetoCompraVenta(FacturaCompraVentaXml objet, List<DetalleFacturaCompraVenta>detalles)
    {
        //
        XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
        XmlSerializer x = new XmlSerializer(objet.GetType());
        FileStream fileStream = File.Open("../../../facturaElectronicaCompraVenta.xml", FileMode.Create, FileAccess.Write);
        x.Serialize(fileStream, objet);
        fileStream.Close();
        XElement newDocXML = XElement.Load("../../../facturaElectronicaCompraVenta.xml");
        //newDocXML.Add(new XElement("Element1", 1));
        //newDocXML.Save("../../../facturaElectronicaCompraVenta.xml");
        foreach (var item in detalles)
        {
            
            XElement newTiempo = new XElement("detalle",
            new XElement("actividadEconomica", item.actividadEconomica),
            new XElement("codigoProductoSin", item.codigoProductoSin),
            new XElement("codigoProducto", item.codigoProducto),
            new XElement("descripcion", item.descripcion),
            new XElement("cantidad", item.cantidad),
            new XElement("unidadMedida", item.unidadMedida),
            new XElement("precioUnitario",item.precioUnitario),
            new XElement("montoDescuento", item.montoDescuento, new XAttribute(xsi + "nil", true)),
            new XElement("subTotal", item.subTotal),
            new XElement("numeroSerie", new XAttribute(xsi + "nil", true)),
            new XElement("numeroImei", new XAttribute(xsi + "nil", true)));
            newDocXML.Add(newTiempo);
        }
         
    Console.WriteLine(newDocXML);
        //


        //XmlSerializer x = new XmlSerializer(objet.GetType());
        //FileStream fileStream = File.Open("../../../facturaElectronicaTelecomunicacion.xml", FileMode.Create,FileAccess.Write);
        //x.Serialize(fileStream,objet);
        //x.Serialize(Console.Out, objet);
        //Console.WriteLine();
        Console.ReadLine();
    }
    public void SerializarObjetoTelecomunicaciones(Object objet)
    {
        //
        XmlSerializer x = new XmlSerializer(typeof(FacturaCompraVentaXml), new Type[] { typeof(CabeceraFacturaCompraVenta), typeof(DetalleFacturaCompraVenta) });
        x.Serialize(Console.Out, objet);
        Console.WriteLine();
        //



        //XmlSerializer x = new XmlSerializer(objet.GetType());
        //FileStream fileStream = File.Open("../../../facturaElectronicaTelecomunicacion.xml", FileMode.Create,FileAccess.Write);
        //x.Serialize(fileStream,objet);
        //x.Serialize(Console.Out, objet);
        //Console.WriteLine();
        Console.ReadLine();
    }
    //llenado de datos ficticios en las facturas de telecom y com-ven
    public FacturaTelecomunicaciones LlenarFacturaTelecomunicaciones()
    {
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
        obj.actividadEconomica = "451010";
        obj.codigoProductoSin = 49111;
        obj.codigoProducto = "POST - 131231";
        obj.descripcion = "PAGO DE MES DE ABRIL DE POSTPAGO";
        obj.cantidad = 1;
        obj.unidadMedida = 58;
        obj.precioUnitario = 150;
        obj.montoDescuento = null;
        obj.subTotal = 150;
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
    public DetalleFacturaTelecomunicaciones LlenarDetalleFacturaTelecomunicacionesXml(FacturaTelecomunicaciones factura)
    {
        DetalleFacturaTelecomunicaciones detalle = new DetalleFacturaTelecomunicaciones();
        detalle.actividadEconomica = factura.actividadEconomica;
        detalle.codigoProductoSin = factura.codigoProductoSin;
        detalle.codigoProducto = factura.codigoProducto;
        detalle.descripcion = factura.descripcion;
        detalle.cantidad = factura.cantidad;
        detalle.unidadMedida = factura.unidadMedida;
        detalle.precioUnitario = factura.precioUnitario;
        detalle.montoDescuento = factura.montoDescuento;
        detalle.subTotal = factura.subTotal;
        detalle.numeroSerie = null;
        detalle.numeroImei = null;
        return detalle;
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
    public List<DetalleFacturaCompraVenta> LlenarDetalleFacturaCompraVenta(List<FacturaDetalleGral> detalles)
    {
        List<DetalleFacturaCompraVenta> listaDetalles = new List<DetalleFacturaCompraVenta>();
        foreach (var item in detalles)
        {
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
        obj.cabecera= program.LlenarCabeceraFacturaTelecomunicacionesXml(factura);
        obj.detalle= program.LlenarDetalleFacturaTelecomunicacionesXml(factura);
        program.SerializarObjetoTelecomunicaciones(obj);
    }
    public void GenerarFacturaCompraVentaXml(FacturaCompraVenta factura)
    {
        Program program = new Program();
        FacturaCompraVentaXml obj = new FacturaCompraVentaXml();
        List<DetalleFacturaCompraVenta> detalles = new List<DetalleFacturaCompraVenta>();
        obj.cabecera = program.LlenarCabeceraFacturaCompraVentaXml(factura);
        detalles = program.LlenarDetalleFacturaCompraVenta(factura.detalles);
        program.SerializarObjetoCompraVenta(obj,detalles);
    }
}

