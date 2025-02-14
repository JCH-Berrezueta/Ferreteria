using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        private int idCliente;
        [DataMember]
        private int idCuenta;
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

        public Cliente()
        {

        }
        public Cliente(int idCliente, int idCuenta, string nombre, string apellido, DateTime fechaNacimiento, int edad, string telefono)
        {
            IdCliente = idCliente;
            IdCuenta = idCuenta;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            Telefono = telefono;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
