using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class EntradaProducto
    {
        [DataMember]
        private int idEntradaProducto;
        [DataMember]
        private int idProducto;
        [DataMember]
        private int idProveedor;
        [DataMember]
        private DateTime fechaIngreso;
        [DataMember]
        private int cantidad;
        [DataMember]
        private decimal costoUnitario;
        [DataMember]
        private decimal costoTotal;
        [DataMember]
        private string observacion;

        public EntradaProducto(int idEntradaProducto, int idProducto, int idProveedor, DateTime fechaIngreso, int cantidad, decimal costoUnitario, decimal costoTotal, string observacion)
        {
            IdEntradaProducto = idEntradaProducto;
            IdProducto = idProducto;
            IdProveedor = idProveedor;
            FechaIngreso = fechaIngreso;
            Cantidad = cantidad;
            CostoUnitario = costoUnitario;
            CostoTotal = costoTotal;
            Observacion = observacion;
        }

        public int IdEntradaProducto { get => idEntradaProducto; set => idEntradaProducto = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public decimal CostoTotal { get => costoTotal; set => costoTotal = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
