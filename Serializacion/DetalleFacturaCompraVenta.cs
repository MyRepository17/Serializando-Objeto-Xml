using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion
{
    [Serializable]
    public class DetalleFacturaCompraVenta
    {
        public DetalleFacturaCompraVenta() { }
        //DETALLE
        public string actividadEconomica;
        public int codigoProductoSin;
        public string codigoProducto;
        public string descripcion;
        public int cantidad;
        public int unidadMedida;
        public float precioUnitario;
        [XmlElement(IsNullable = true)]
        public float? montoDescuento;
        public float subTotal;
        [XmlElement(IsNullable = true)]
        public string? numeroSerie;
        [XmlElement(IsNullable = true)]
        public string? numeroImei;
        //[XmlElement(IsNullable = true)]
        //public virtual CabeceraFacturaCompraVenta factura { get; set; } = null!;
    }
}
