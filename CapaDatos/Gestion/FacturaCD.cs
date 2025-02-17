using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using factura = CapaEntidades.Gestion.Factura;

namespace CapaDatos.Gestion
{
    public class FacturaCD
    {
        //public static List<listarVistaFacturaClienteResult> listarVistaFacturasClientesCD()
        //{
        //    ConectorBDDataContext bd = null;
        //    List<listarVistaFacturaClienteResult> lista = null;
        //    try
        //    {
        //        bd = new ConectorBDDataContext();
        //        lista = bd.listarVistaFacturaCliente().ToList();
        //        bd.SubmitChanges();
        //    }
        //    catch (Exception error)
        //    {
        //        Debug.WriteLine("Error listar Vista Facturas Clientes CD " + error);
        //    }
        //    return lista;
        //}

        public static List<FiltrarVistaFacturaClienteResult> filtrarVistaFacturasClientesCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<FiltrarVistaFacturaClienteResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.FiltrarVistaFacturaCliente(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Facturas Clientes CD " + error);
            }
            return lista;
        }

        public static List<CP_ListarFacturasResult> listarFacturasCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarFacturasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarFacturas().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Facturas CD " + error);
            }
            return lista;
        }

        public static List<CP_FiltrarFacturasResult> filtrarFacturasCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarFacturasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltrarFacturas(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Facturas CD " + error);
            }
            return lista;
        }

        public static void insertarFacturaCD(factura Factura)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarFactura(Factura.IdCliente, Factura.FechaEmision, Factura.MetodoPago, Factura.Total, Factura.Iva);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Facturas CD " + error);
            }
        }

        public static void modificarFacturaCD(factura Factura)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarFactura(Factura.IdFactura, Factura.IdCliente, Factura.FechaEmision, Factura.MetodoPago, Factura.Total, Factura.Iva);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Facturas CD " + error);
            }
        }

        public static void eliminarFacturaCD(int idFactura)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarFactura(idFactura);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar Facturas CD " + error);
            }
        }

    }
}
