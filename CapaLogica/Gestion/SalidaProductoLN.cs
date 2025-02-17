using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salidaProducto = CapaEntidades.Gestion.SalidaProducto;
using vistaSalidaProducto = CapaEntidades.Vistas.VSalidaProducto;

namespace CapaLogica.Gestion
{
    public class SalidaProductoLN
    {
        public static List<vistaSalidaProducto> listarVistaSalidaProductosLN()
        {
            List<vistaSalidaProducto> lista = null;
            try
            {
                var sql = from x in SalidaProductoCD.listarVistaSalidaProductosCD()
                          select new vistaSalidaProducto(x.ID, x.Categoria, x.Producto, x.FechaSalida, x.Cantidad, x.Motivo, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista salida Productos LN" + error);
            }
            return lista;
        }

        public static List<vistaSalidaProducto> filtrarVistaSalidaProductosLN(string clave)
        {
            List<vistaSalidaProducto> lista = null;
            try
            {
                var sql = from x in SalidaProductoCD.filtrarVistaSalidaProductosCD(clave)
                          select new vistaSalidaProducto(x.ID, x.Categoria, x.Producto, x.FechaSalida, x.Cantidad, x.Motivo, x.Observacion);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista salida Productos LN" + error);
            }
            return lista;
        }


        public static List<salidaProducto> listarSalidaProductosLN()
        {
            List<salidaProducto> lista = null;
            try
            {
                var sql = from x in SalidaProductoCD.listarSalidaProductosCD()
                          select new salidaProducto(x.Id_SalidaProducto, x.Id_Producto, x.Cantidad, x.FechaSalida, x.Motivo, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar salidaProductosLN" + error);
            }
            return lista;
        }

        public static List<salidaProducto> filtrarSalidaProductosLN(string clave)
        {
            List<salidaProducto> lista = null;
            try
            {
                var sql = from x in SalidaProductoCD.filtrarSalidaProductosCD(clave)
                          select new salidaProducto(x.Id_SalidaProducto, x.Id_Producto, x.Cantidad, x.FechaSalida, x.Motivo, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar salidaProductosLN" + error);
            }
            return lista;
        }

        public static bool insertarSalidaProductosLN(salidaProducto salidaProducto)
        {
            bool resul = false;
            try
            {
                SalidaProductoCD.insertarSalidaProductoCD(salidaProducto);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar salidaProductosLN" + error);
            }
            return resul;
        }

        public static bool modificarSalidaProductosLN(salidaProducto salidaProducto)
        {
            bool resul = false;
            try
            {
                SalidaProductoCD.modificarSalidaProductoCD(salidaProducto);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar salidaProductosLN" + error);
            }
            return resul;
        }

        public static bool eliminarSalidaProductosLN(int idsalidaProducto)
        {
            bool resul = false;
            try
            {
                SalidaProductoCD.eliminarSalidaProductoCD(idsalidaProducto);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar salidaProductosLN" + error);
            }
            return resul;
        }
    }
}
