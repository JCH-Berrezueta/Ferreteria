using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    public class VDetalleFactura
    {
        private int id;
        private string categoria;
        private string producto;
        private decimal precio;
        private int cantidad;
        private decimal subtotal;

        public VDetalleFactura(int id, string categoria, string producto, decimal precio, int cantidad, decimal subtotal)
        {
            Id = id;
            Categoria = categoria;
            Producto = producto;
            Precio = precio;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Producto { get => producto; set => producto = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
    }
}
