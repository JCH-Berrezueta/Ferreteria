using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using detalleFactura = CapaEntidades.Gestion.DetalleFactura;
using vistaDetalleFactura = CapaEntidades.Vistas.VDetalleFactura;

namespace CapaLogica.Gestion
{
    public class DetalleFacturaLN
    {
        public static List<vistaDetalleFactura> listarVistaDetalleFacturasLN()
        {
            List<vistaDetalleFactura> lista = null;
            try
            {
                var sql = from x in DetalleFacturaCD.listarVistaDetalleFacturasCD()
                          select new vistaDetalleFactura(x.ID, x.Categoria, x.Producto, x.Precio, x.Cantidad, x.Subtotal);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Detalle Facturas Clientes LN" + error);
            }
            return lista;
        }

        public static List<vistaDetalleFactura> filtrarVistaDetalleFacturasLN(string clave)
        {
            List<vistaDetalleFactura> lista = null;
            try
            {
                var sql = from x in DetalleFacturaCD.filtrarVistaDetalleFacturasCD(clave)
                          select new vistaDetalleFactura(x.ID, x.Categoria, x.Producto, x.Precio, x.Cantidad, x.Subtotal);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Detalle Facturas Clientes LN" + error);
            }
            return lista;
        }


        public static List<detalleFactura> listarDetalleFacturasLN()
        {
            List<detalleFactura> lista = null;
            try
            {
                var sql = from x in DetalleFacturaCD.listarDetalleFacturasCD()
                          select new detalleFactura(x.Id_DetalleFactura, x.Id_Producto, x.Id_Factura, x.Cantidad, x.Subtotal);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Detalle FacturasLN" + error);
            }
            return lista;
        }

        public static List<detalleFactura> filtrarDetalleFacturasLN(string clave)
        {
            List<detalleFactura> lista = null;
            try
            {
                var sql = from x in DetalleFacturaCD.filtrarDetalleFacturasCD(clave)
                          select new detalleFactura(x.Id_DetalleFactura, x.Id_Producto, x.Id_Factura, x.Cantidad, x.Subtotal);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Detalle FacturasLN" + error);
            }
            return lista;
        }

        public static bool insertarDetalleFacturaLN(detalleFactura DetalleFactura)
        {
            bool resul = false;
            try
            {
                DetalleFacturaCD.insertarDetalleFacturaCD(DetalleFactura);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Detalle FacturasLN" + error);
            }
            return resul;
        }

        public static bool modificarDetalleFacturasLN(detalleFactura DetalleFactura)
        {
            bool resul = false;
            try
            {
                DetalleFacturaCD.modificarDetalleFacturaCD(DetalleFactura);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Detalle FacturasLN" + error);
            }
            return resul;
        }

        public static bool eliminarDetalleFacturasLN(int idDetalleFactura)
        {
            bool resul = false;
            try
            {
                DetalleFacturaCD.eliminarDetalleFacturaCD(idDetalleFactura);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar Detalle FacturasLN" + error);
            }
            return resul;
        }
    }
}
