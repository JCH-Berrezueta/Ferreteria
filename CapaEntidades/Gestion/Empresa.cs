using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class Empresa
    {
        [DataMember]
        private int idEmpresa;
        [DataMember]
        private string nombre;
        [DataMember]
        private string ruc;
        [DataMember]
        private string direccion;
        [DataMember]
        private string representante;
        [DataMember]
        private string telefono;
        [DataMember]
        private string mail;
        [DataMember]
        private string descripcion;
        [DataMember]
        private string observacion;

        public Empresa()
        {
        }

        public Empresa(int idEmpresa)
        {
            IdEmpresa = idEmpresa;
        }
        public Empresa(int idEmpresa, string nombre, string ruc, string direccion, string representante, string telefono, string mail, string descripcion, string observacion)
        {
            IdEmpresa = idEmpresa;
            Nombre = nombre;
            Ruc = ruc;
            Direccion = direccion;
            Representante = representante;
            Telefono = telefono;
            Mail = mail;
            Descripcion = descripcion;
            Observacion = observacion;
        }

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Representante { get => representante; set => representante = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
