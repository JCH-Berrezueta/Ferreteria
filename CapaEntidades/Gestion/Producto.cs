using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class Producto
    {
        [DataMember]
        private int idProducto;
        [DataMember]
        private int idCategoriaProducto;
        [DataMember]
        private string nombre;
        [DataMember]
        private decimal precio;
        [DataMember]
        private int stock;
        [DataMember]
        private string estado;
        [DataMember]
        private string icono;
        [DataMember]
        private string descripcion;

        public Producto(int idProducto, int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            IdProducto = idProducto;
            IdCategoriaProducto = idCategoriaProducto;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Estado = estado;
            Icono = icono;
            Descripcion = descripcion;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdCategoriaProducto { get => idCategoriaProducto; set => idCategoriaProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Icono { get => icono; set => icono = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
