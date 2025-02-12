using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Gestion
{
    public class SalidaProducto
    {
        private int idSalidaProducto;
        private int idProducto;
        private int cantidad;
        private DateTime fechaSalida;
        private string motivo;
        private string observacion;

        public SalidaProducto(int idSalidaProducto, int idProducto, int cantidad, DateTime fechaSalida, string motivo, string observacion)
        {
            IdSalidaProducto = idSalidaProducto;
            IdProducto = idProducto;
            Cantidad = cantidad;
            FechaSalida = fechaSalida;
            Motivo = motivo;
            Observacion = observacion;
        }

        public int IdSalidaProducto { get => idSalidaProducto; set => idSalidaProducto = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
