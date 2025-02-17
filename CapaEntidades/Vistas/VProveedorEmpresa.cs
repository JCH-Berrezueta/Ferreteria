using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    [DataContract]
    public class VProveedorEmpresa
    {
        [DataMember]
        private int id;
        [DataMember]
        private string empresa;
        [DataMember]
        private string proveedor;
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

        public VProveedorEmpresa(int id, string empresa, string proveedor, DateTime fechaNacimiento, int edad, string mail, string telefono, string observacion)
        {
            Id = id;
            Empresa = empresa;
            Proveedor = proveedor;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            Mail = mail;
            Telefono = telefono;
            Observacion = observacion;
        }

        public int Id { get => id; set => id = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
