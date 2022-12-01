using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion
{
    public  class DetalleFacturaTelecomunicaciones
    {
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
    }
}
