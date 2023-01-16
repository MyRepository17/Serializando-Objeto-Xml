using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public  class FacturaDetalleGral
    {
        public string actividadEconomica;
        public int codigoProductoSin;
        public string codigoProducto;
        public string descripcion;
        public int cantidad;
        public int unidadMedida;
        public float precioUnitario;
        public float? montoDescuento;
        public float subTotal;
        //public string numeroSerie;
        //public string numeroImei;
        public virtual FacturaCompraVenta factura { get; set; } = null!;
    }
}
