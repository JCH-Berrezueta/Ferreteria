using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using detalleFactura = CapaEntidades.Gestion.DetalleFactura;

namespace CapaDatos.Gestion
{
    public class DetalleFacturaCD
    {
        //public static List<listarVistaDetalleFacturaResult> listarVistaDetalleFacturasCD()
        //{
        //    ConectorBDDataContext bd = null;
        //    List<listarVistaDetalleFacturaResult> lista = null;
        //    try
        //    {
        //        bd = new ConectorBDDataContext();
        //        lista = bd.listarVistaDetalleFactura().ToList();
        //        bd.SubmitChanges();
        //    }
        //    catch (Exception error)
        //    {
        //        Debug.WriteLine("Error en listar Vista DetalleFacturas CD" + error);
        //    }
        //    return lista;
        //}

        public static List<FiltrarVistaDetalleFacturaResult> filtrarVistaDetalleFacturasCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<FiltrarVistaDetalleFacturaResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.FiltrarVistaDetalleFactura(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Vista DetalleFacturas CD" + error);
            }
            return lista;
        }

        public static List<CP_ListarDetalleFacturasResult> listarDetalleFacturasCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarDetalleFacturasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarDetalleFacturas().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar DetalleFacturas CD" + error);
            }
            return lista;
        }

        public static List<CP_FiltrarDetallesFacturasResult> filtrarDetalleFacturasCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarDetallesFacturasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltrarDetallesFacturas(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar DetalleFacturas CD" + error);
            }
            return lista;
        }

        public static void insertarDetalleFacturaCD(detalleFactura DetalleFactura)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarDetalleFactura(DetalleFactura.IdProducto, DetalleFactura.IdFactura, DetalleFactura.Cantidad, DetalleFactura.Subtotal);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar DetalleFacturas CD" + error);
            }
        }
        public static void modificarDetalleFacturaCD(detalleFactura DetalleFactura)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarDetalleFactura(DetalleFactura.IdDetalleFactura, DetalleFactura.IdProducto, DetalleFactura.IdFactura, DetalleFactura.Cantidad, DetalleFactura.Subtotal);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en modificar DetalleFacturas CD" + error);
            }
        }
        public static void eliminarDetalleFacturaCD(int idDetalleFactura)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarDetalleFactura(idDetalleFactura);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en eliminar DetalleFacturas CD" + error);
            }
        }
    }
}
