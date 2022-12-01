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
        [XmlElement(IsNullable = true)]
        public string? telefono;
        [XmlElement(IsNullable = true)]
        public string? nitConjunto;
        public long numeroFactura;
        public string cuf;
        public string cufd;
        public int codigoSucursal;
        public string direccion;
        [XmlElement(IsNullable = true)]
        public int? codigoPuntoVenta;
        public DateTime fechaEmision;
        public string nombreRazonSocial;
        public int codigoTipoDocumentoIdentidad;
        public string numeroDocumento;
        [XmlElement(IsNullable = true)]
        public string? complemento;
        public string codigoCliente;
        public int codigoMetodoPago;
        [XmlElement(IsNullable = true)]
        public int? numeroTarjeta;
        public float montoTotal;
        public float montoTotalSujetoIva;
        public int codigoModeda;
        public int tipoCambio;
        public int montoTotalMoneda;
        [XmlElement(IsNullable = true)]
        public float? montoGiftCard;
        [XmlElement(IsNullable = true)]
        public float? descuentoAdicional;
        [XmlElement(IsNullable = true)]
        public int? codigoExcepcion;
        [XmlElement(IsNullable = true)]
        public string? cafc;
        public string leyenda;
        public string usuario;
        public int codigoDocumentoSector;
    }
}
