using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    [DataContract]
    public class VFacturaCliente
    {
        [DataMember]
        private int numFactura;
        [DataMember]
        private string cliente;
        [DataMember]
        private string mail;
        [DataMember]
        private DateTime fechaEmision;
        [DataMember]
        private string metodoPago;
        [DataMember]
        private int iva;
        [DataMember]
        private decimal total;

        public VFacturaCliente(int numFactura, string cliente, string mail, DateTime fechaEmision, string metodoPago, int iva, decimal total)
        {
            NumFactura = numFactura;
            Cliente = cliente;
            Mail = mail;
            FechaEmision = fechaEmision;
            MetodoPago = metodoPago;
            Iva = iva;
            Total = total;
        }

        public int NumFactura { get => numFactura; set => numFactura = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Mail { get => mail; set => mail = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public int Iva { get => iva; set => iva = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
