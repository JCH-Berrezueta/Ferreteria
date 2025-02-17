using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class Categoria
    {
        [DataMember]
        private int idCategoria;
        [DataMember]
        private string nombre;
        [DataMember]
        private string descripcion;

        public Categoria()
        {
        }

        public Categoria(int idCategoria)
        {
            IdCategoria = idCategoria;
        }

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
