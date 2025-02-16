using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    [DataContract]
    public class VProductoCategoria
    {
        [DataMember]
        private int id;
        [DataMember]
        private string categoria;
        [DataMember]
        private string producto;
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

        public VProductoCategoria(int id, string categoria, string producto, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            Id = id;
            Categoria = categoria;
            Producto = producto;
            Precio = precio;
            Stock = stock;
            Estado = estado;
            Icono = icono;
            Descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Producto { get => producto; set => producto = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Icono { get => icono; set => icono = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
