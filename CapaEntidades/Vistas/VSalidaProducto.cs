using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Vistas
{
    [DataContract]
    public class VSalidaProducto
    {
        [DataMember]
        private int id;
        [DataMember]
        private string categoria;
        [DataMember]
        private string producto;
        [DataMember]
        private DateTime fechaSalida;
        [DataMember]
        private int cantidad;
        [DataMember]
        private string motivo;
        [DataMember]
        private string observacion;

        public VSalidaProducto(int id, string categoria, string producto, DateTime fechaSalida, int cantidad, string motivo, string observacion)
        {
            Id = id;
            Categoria = categoria;
            Producto = producto;
            FechaSalida = fechaSalida;
            Cantidad = cantidad;
            Motivo = motivo;
            Observacion = observacion;
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Producto { get => producto; set => producto = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
