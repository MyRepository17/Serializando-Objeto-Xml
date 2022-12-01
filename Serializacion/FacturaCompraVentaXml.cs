using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion
{
    [XmlRoot("facturaElectronicaCompraVenta")]
    [XmlType("NewTypeName")]
    public class FacturaCompraVentaXml
    {
        public CabeceraFacturaCompraVenta cabecera;
        public DetalleFacturaCompraVenta detalle;
    }
}
