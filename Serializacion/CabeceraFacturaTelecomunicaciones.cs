using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion
{
    //[XmlRoot(IsNullable = false)]
    public  class CabeceraFacturaTelecomunicaciones
    {
        public long nitEmisor;
        public string razonSocialEmisor;
        public string municipio;
        public string telefono;
        public long numeroFactura;
        public string cuf;
        public string cufd;
        public int codigoSucursal;
        public string direccion;
        public int codigoPuntoVenta;
        public DateTime fechaEmision;
        public string nombreRazonSocial;
        public int codigoTipoDocumentoIdentidad;
        public string numeroDocumento;
        [XmlElement(IsNullable = true)]
        public string? complemento;
        public string codigoCliente;
        public int codigoMetodoPago;
        //public int numeroTarjeta;
        public float montoTotal;
        public float montoTotalSujetoIva;
        //public float montoGiftCard;
        //public float descuentoAdicional;
        public int codigoExcepcion;
        [XmlElement(IsNullable = true)]
        public string? cafc;
        public int codigoModeda;
        public float tipoCambio;
        public float montoTotalMoneda;
        public string leyenda;
        public string usuario;
        public int codigoDocumentoSector;
    }
}
