using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class FacturaCompraVenta
    {
        public long nitEmisor;
        public string razonSocialEmisor;
        public string municipio;
        public string? telefono;
        public long numeroFactura;
        public string cuf;
        public string cufd;
        public int codigoSucursal;
        public string direccion;
        public int? codigoPuntoVenta;
        public DateTime fechaEmision;
        public string? nombreRazonSocial;
        public int codigoTipoDocumentoIdentidad;
        public string numeroDocumento;
        public string? complemento;
        public string codigoCliente;
        public int codigoMetodoPago;
        //public int numeroTarjeta;
        public float montoTotal;
        public float montoTotalSujetoIva;
        public int codigoModeda;
        public float tipoCambio;
        public float montoTotalMoneda;
        //public float montoGiftCard;
        //public float descuentoAdicional;
        public int? codigoExcepcion;
        public string? cafc;
        public string leyenda;
        public string usuario;
        public int codigoDocumentoSector;
        //DETALLE
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
    }
}
