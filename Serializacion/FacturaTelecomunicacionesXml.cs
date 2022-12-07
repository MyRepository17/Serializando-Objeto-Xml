using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Serializacion
{
    [XmlRoot("facturaElectronicaTelecomunicacion")]
    [XmlType("NewTypeName")]
    
    public class FacturaTelecomunicacionesXml
    {
        [XmlAttribute("noNamespaceSchemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string attr = "facturaElectronicaTelecomunicacion.xsd";
        public CabeceraFacturaTelecomunicaciones cabecera;
        public DetalleFacturaTelecomunicaciones detalle;
    }
}
