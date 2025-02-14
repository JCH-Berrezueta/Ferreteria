using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using salidaProducto = CapaEntidades.Gestion.SalidaProducto;

namespace CapaDatos.Gestion
{
    public class SalidaProductoCD
    {
        public static List<listarVistaSalidaProductoResult> listarVistaSalidaProductosCD()
        {
            ConectorBDDataContext bd = null;
            List<listarVistaSalidaProductoResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.listarVistaSalidaProducto().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Salida productos CD " + error);
            }
            return lista;
        }

        public static List<FiltrarVistaSalidaProudctoResult> filtrarVistaSalidaProductosCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<FiltrarVistaSalidaProudctoResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.FiltrarVistaSalidaProudcto(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Salida productos CD " + error);
            }
            return lista;
        }

        public static List<CP_ListarSalidaProductosResult> listarSalidaProductosCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarSalidaProductosResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarSalidaProductos().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar productos CD " + error);
            }
            return lista;
        }

        public static List<CP_FiltraSalidasProductosResult> filtrarSalidaProductosCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltraSalidasProductosResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltraSalidasProductos(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Salida productos CD " + error);
            }
            return lista;
        }

        public static void insertarSalidaProductoCD(salidaProducto Salida)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarSalidaProducto(Salida.IdProducto, Salida.FechaSalida, Salida.Cantidad, Salida.Motivo, Salida.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Salida productos CD " + error);
            }
        }

        public static void modificarSalidaProductoCD(salidaProducto Salida)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarSalidaProducto(Salida.IdSalidaProducto, Salida.IdProducto, Salida.FechaSalida, Salida.Cantidad, Salida.Motivo, Salida.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Salida productos CD " + error);
            }
        }

        public static void eliminarSalidaProductoCD(int idSalidaProducto)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarSalidaProducto(idSalidaProducto);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar Salida productos CD " + error);
            }
        }

    }
}
