using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class Rol
    {
        [DataMember]
        private int idRol;
        [DataMember]
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
