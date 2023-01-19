using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Serializacion
{
    [Serializable]
    [XmlRoot("facturaElectronicaCompraVenta")]
    [XmlType("NewTypeName")]
    public class FacturaCompraVentaXml
    {
        [XmlAttribute("noNamespaceSchemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string attr = "facturaElectronicaCompraVenta.xsd";

        public FacturaCompraVentaXml() { }
        public CabeceraFacturaCompraVenta cabecera;

        //public DetalleFacturaCompraVenta detalle;

        //public List<DetalleFacturaCompraVenta> detalle= new List<DetalleFacturaCompraVenta>();
    }
}
