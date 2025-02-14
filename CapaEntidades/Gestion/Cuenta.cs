using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Cuenta
    {
        [DataMember]
        private int idCuenta;
        [DataMember]
        private int idRol;
        [DataMember]
        private string mail;
        [DataMember]
        private string password;

        public Cuenta(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
        }

        public Cuenta(int idCuenta, int idRol, string mail, string password)
        {
            IdCuenta = idCuenta;
            IdRol = idRol;
            Mail = mail;
            Password = password;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
    }
}
