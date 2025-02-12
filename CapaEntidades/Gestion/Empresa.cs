using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class Empresa
    {
        private int idEmpresa;
        private string nombre;
        private string ruc;
        private string direccion;
        private string representante;
        private string telefono;
        private string mail;
        private string descripcion;
        private string observacion;

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
