using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Rol
    {
        private int idRol;
        private string nombre;

        public Rol(int idRol, string nombre)
        {
            IdRol = idRol;
            Nombre = nombre;
        }

        public int IdRol { get => idRol; set => idRol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
