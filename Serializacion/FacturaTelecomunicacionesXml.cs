using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    [XmlRoot("facturaElectronicaTelecomunicacion")]
    [XmlType("NewTypeName")]
    public class FacturaTelecomunicacionesXml
    {
        public CabeceraFacturaTelecomunicaciones cabecera;
        public DetalleFacturaTelecomunicaciones detalle;
    }
}
