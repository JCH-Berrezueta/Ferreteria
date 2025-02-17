using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class Proveedor
    {
        [DataMember]
        private int idProveedor;
        [DataMember]
        private int idEmpresa;
        [DataMember]
        private string nombre;
        [DataMember]
        private string apellido;
        [DataMember]
        private DateTime fechaNacimiento;
        [DataMember]
        private int edad;
        [DataMember]
        private string mail;
        [DataMember]
        private string telefono;
        [DataMember]
        private string observacion;

        public Proveedor(int idProveedor, int idEmpresa, string nombre, string apellido, DateTime fechaNacimiento, int edad, string mail, string telefono, string observacion)
        {
            IdProveedor = idProveedor;
            IdEmpresa = idEmpresa;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            Mail = mail;
            Telefono = telefono;
            Observacion = observacion;
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
