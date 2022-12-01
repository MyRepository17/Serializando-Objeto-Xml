using Microsoft.VisualBasic;
using Serializacion;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

internal class Program
{
   
    private static void Main(string[] args)
    {
        Program program= new Program();
        Objeto p = new Objeto();
        p.cabecera = new Cabecera();
        p.cabecera.razonSocialEmisor = "leonardo";
        p.cabecera.nitEmisor = "10503823";
        p.detalle = new Detalle();
        p.detalle.actividadEconomica = 1;
        p.detalle.codigoProductoSin = 21231;
        program.SerializarObjeto(p);


        //program.GenerarFacturaTelecomunicacionesXml(program.LlenarFacturaTelecomunicaciones());


        // Create and load the XML document.
        //XmlDocument doc = new XmlDocument();
        //string xmlString = "<book><title>Oberon's Legacy</title></book>";
        //doc.Load(new StringReader(xmlString));

        //// Create an XML declaration.
        //XmlDeclaration xmldecl;
        //xmldecl = doc.CreateXmlDeclaration("1.0", null, null);
        //xmldecl.Encoding = "UTF-8";
        //xmldecl.Standalone = "yes";

        //// Add the new node to the document.
        //XmlElement root = doc.DocumentElement;
        //doc.InsertBefore(xmldecl, root);

        //// Display the modified XML document
        //Console.WriteLine(doc.OuterXml);
    }
    
    public void SerializarObjeto(Object objet)
    {
        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(objet.GetType());
        //FileStream fileStream = File.Open("C:\\Users\\leona\\source\\repos\\Serializacion\\Serializacion\\Xml\\facturaElectronicaTelecomunicacion.xml", FileMode.Create,FileAccess.Write);
        //x.Serialize(fileStream,objet);
        x.Serialize(Console.Out, objet);
        Console.ReadLine();
    }


    //implementado
    public FacturaTelecomunicaciones LlenarFacturaTelecomunicaciones()
    {
       FacturaTelecomunicaciones obj= new FacturaTelecomunicaciones();
        obj.nitEmisor = 1003579028;
        obj.razonSocialEmisor = "Carlos Loza";
        obj.municipio="La Paz";
        obj.telefono = "2846005";
        //< nitConjunto xsi: nil = "true" ></ nitConjunto > no tiene el objeto
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
        //< numeroTarjeta xsi: nil = "true" />
        obj.montoTotal = 150;
        obj.montoTotalSujetoIva = 150;
        obj.codigoModeda = 1;
        obj.tipoCambio = 1;
        obj.montoTotalMoneda = 150;
        //< montoGiftCard xsi: nil = "true" />
        //< descuentoAdicional xsi: nil = "true" />
        //< codigoExcepcion xsi: nil = "true" />
        obj.cafc = null;
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
        //< numeroSerie > 67755FD </ numeroSerie >
        //< numeroImei > 1234AS </ numeroImei >
        return obj;
    }
    //falta
    public FacturaCompraVenta LlenarFacturaCompraVenta()
    {
        return null;
    }



    //CabeceraFacturaTelecomunicacionesXml
    public CabeceraFacturaTelecomunicaciones LlenarCabeceraFacturaTelecomunicacionesXml (FacturaTelecomunicaciones factura)
    {
        CabeceraFacturaTelecomunicaciones cabecera= new CabeceraFacturaTelecomunicaciones();
        cabecera.nitEmisor = factura.nitEmisor ;
        cabecera.razonSocialEmisor = factura.razonSocialEmisor;
        cabecera.municipio = factura.municipio;
        cabecera.telefono = factura.telefono;
        //< nitConjunto xsi: nil = "true" ></ nitConjunto > no tiene el objeto
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
        //< numeroTarjeta xsi: nil = "true" />
        cabecera.montoTotal = factura.montoTotal;
        cabecera.montoTotalSujetoIva = factura.montoTotalSujetoIva;
        cabecera.codigoModeda = factura.codigoModeda;
        cabecera.tipoCambio = factura.tipoCambio;
        cabecera.montoTotalMoneda = factura.montoTotalMoneda;
        //< montoGiftCard xsi: nil = "true" />
        //< descuentoAdicional xsi: nil = "true" />
        //< codigoExcepcion xsi: nil = "true" />
        cabecera.cafc = factura.cafc;
        cabecera.leyenda = factura.leyenda;
        cabecera.usuario = factura.usuario;
        cabecera.codigoDocumentoSector = factura.codigoDocumentoSector;
        return cabecera;
    }
    //DetalleFacturaTelecomunicacionesXml
    public DetalleFacturaTelecomunicaciones LlenarDetalleFacturaTelecomunicacionesXml(FacturaTelecomunicaciones factura)
    {
        DetalleFacturaTelecomunicaciones detalle= new DetalleFacturaTelecomunicaciones();
        detalle.actividadEconomica = factura.actividadEconomica;
        detalle.codigoProductoSin = factura.codigoProductoSin;
        detalle.codigoProducto = factura.codigoProducto;
        detalle.descripcion = factura.descripcion;
        detalle.cantidad = factura.cantidad;
        detalle.unidadMedida = factura.unidadMedida;
        detalle.precioUnitario = factura.precioUnitario;
        detalle.montoDescuento = factura.montoDescuento;
        detalle.subTotal = factura.subTotal;
        //< numeroSerie > 67755FD </ numeroSerie >
        //< numeroImei > 1234AS </ numeroImei >
        return detalle;
    }

    //falta
    public CabeceraFacturaCompraVenta LlenarCabeceraFacturaCompraVentaXml(FacturaTelecomunicaciones factura)
    {
        return null;
    }

    //implementado
    public void GenerarFacturaTelecomunicacionesXml(FacturaTelecomunicaciones factura)
    {
        Program program = new Program();
        
        
        FacturaTelecomunicacionesXml obj=new FacturaTelecomunicacionesXml();
        obj.cabecera= program.LlenarCabeceraFacturaTelecomunicacionesXml(factura);
        obj.detalle= program.LlenarDetalleFacturaTelecomunicacionesXml(factura);
        program.SerializarObjeto(obj);
    }
}

