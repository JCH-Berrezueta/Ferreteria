using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class DetalleFactura
    {
        [DataMember]
        private int idDetalleFactura;
        [DataMember]
        private int idProducto;
        [DataMember]
        private int idFactura;
        [DataMember]
        private int cantidad;
        [DataMember]
        private decimal subtotal;

        public DetalleFactura(int idDetalleFactura, int idProducto, int idFactura, int cantidad, decimal subtotal)
        {
            IdDetalleFactura = idDetalleFactura;
            IdProducto = idProducto;
            IdFactura = idFactura;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }

        public int IdDetalleFactura { get => idDetalleFactura; set => idDetalleFactura = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
    }
}
