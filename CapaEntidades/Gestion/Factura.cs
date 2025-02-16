using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class Factura
    {
        [DataMember]
        private int idFactura;
        [DataMember]
        private int idCliente;
        [DataMember]
        private DateTime fechaEmision;
        [DataMember]
        private string metodoPago;
        [DataMember]
        private decimal total;
        [DataMember]
        private int iva;

        public Factura(int idFactura, int idCliente, DateTime fechaEmision, string metodoPago, decimal total, int iva)
        {
            IdFactura = idFactura;
            IdCliente = idCliente;
            FechaEmision = fechaEmision;
            MetodoPago = metodoPago;
            Total = total;
            Iva = iva;
        }

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public decimal Total { get => total; set => total = value; }
        public int Iva { get => iva; set => iva = value; }
    }
}
