using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    [DataContract]
    public class VEntradaProducto
    {
        [DataMember]
        private int id;
        [DataMember]
        private string categoria;
        [DataMember]
        private string producto;
        [DataMember]
        private string proveedor;
        [DataMember]
        private string emailProv;
        [DataMember]
        private string empresa;
        [DataMember]
        private string emailEmp;
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

        public VEntradaProducto(int id, string categoria, string producto, string proveedor, string emailProv, string empresa, string emailEmp, DateTime fechaIngreso, int cantidad, decimal costoUnitario, decimal costoTotal, string observacion)
        {
            Id = id;
            Categoria = categoria;
            Producto = producto;
            Proveedor = proveedor;
            EmailProv = emailProv;
            Empresa = empresa;
            EmailEmp = emailEmp;
            FechaIngreso = fechaIngreso;
            Cantidad = cantidad;
            CostoUnitario = costoUnitario;
            CostoTotal = costoTotal;
            Observacion = observacion;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string EmailProv { get => emailProv; set => emailProv = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string EmailEmp { get => emailEmp; set => emailEmp = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal CostoUnitario { get => costoUnitario; set => costoUnitario = value; }
        public decimal CostoTotal { get => costoTotal; set => costoTotal = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
