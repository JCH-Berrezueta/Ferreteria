using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    [DataContract]
    public class VCuentaRol
    {
        [DataMember]
        private int id;
        [DataMember]
        private string rol;
        [DataMember]
        private string mail;

        public VCuentaRol(int id, string rol, string mail)
        {
            Id = id;
            Rol = rol;
            Mail = mail;
        }

        public int Id { get => id; set => id = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
