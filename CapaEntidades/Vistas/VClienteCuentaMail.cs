using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    [DataContract]
    public class VClienteCuentaMail
    {
        [DataMember]
        private int id;
        [DataMember]
        private string nombre;
        [DataMember]
        private string apellido;
        [DataMember]
        private DateTime fechaNacimiento;
        [DataMember]
        private int edad;
        [DataMember]
        private string telefono;
        [DataMember]
        private string mail;

        public VClienteCuentaMail(int id, string nombre, string apellido, DateTime fechaNacimiento, int edad, string telefono, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            Telefono = telefono;
            Mail = mail;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
