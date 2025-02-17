using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using entradaProducto = CapaEntidades.Gestion.EntradaProducto;

namespace CapaDatos.Gestion
{
    public class EntradaEntradaProductoCD
    {
        //public static List<listarVistaEntradaProductoResult> listarVistaEntradaProductosCD()
        //{
        //    ConectorBDDataContext bd = null;
        //    List<listarVistaEntradaProductoResult> lista = null;
        //    try
        //    {
        //        bd = new ConectorBDDataContext();
        //        lista = bd.listarVistaEntradaProducto().ToList();
        //        bd.SubmitChanges();
        //    }
        //    catch (Exception error)
        //    {
        //        Debug.WriteLine("Error filtrar Vista entrada productos CD " + error);
        //    }
        //    return lista;
        //}

        public static List<FiltrarVistaEntradaProudctoResult> filtrarVistaEntradaProductosCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<FiltrarVistaEntradaProudctoResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.FiltrarVistaEntradaProudcto(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista entrada productos CD " + error);
            }
            return lista;
        }
        
        public static List<CP_ListarEntradaProductosResult> listarEntradaProductosCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarEntradaProductosResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarEntradaProductos().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar productos CD " + error);
            }
            return lista;
        }

        public static List<CP_FiltraEntradasProductosResult> filtrarEntradaProductosCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltraEntradasProductosResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltraEntradasProductos(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar entrada productos CD " + error);
            }
            return lista;
        }

        public static void insertarEntradaProductoCD(entradaProducto entrada)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarEntradaProducto(entrada.IdProducto, entrada.IdProveedor, entrada.FechaIngreso, entrada.Cantidad, entrada.CostoUnitario, entrada.CostoTotal, entrada.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar entrada productos CD " + error);
            }
        }

        public static void modificarEntradaProductoCD(entradaProducto entrada)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarEntradaProducto(entrada.IdEntradaProducto, entrada.IdProducto, entrada.IdProveedor, entrada.FechaIngreso, entrada.Cantidad, entrada.CostoUnitario, entrada.CostoTotal, entrada.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar entrada productos CD " + error);
            }
        }

        public static void eliminarEntradaProductoCD(int idEntradaProducto)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarEntradaProducto(idEntradaProducto);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar entrada productos CD " + error);
            }
        }


    }
}
