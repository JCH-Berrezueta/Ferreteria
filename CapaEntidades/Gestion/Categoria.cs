using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Categoria
    {
        private int idCategoria;
        private string nombre;
        private string descripcion;

        public Categoria(int idCategoria, string nombre, string descripcion)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
