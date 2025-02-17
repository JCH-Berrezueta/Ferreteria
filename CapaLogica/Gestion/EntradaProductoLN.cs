using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entradaProducto = CapaEntidades.Gestion.EntradaProducto;
using vistaEntradaProducto = CapaEntidades.Vistas.VEntradaProducto;

namespace CapaLogica.Gestion
{
    public class EntradaProductoLN
    {
        public static List<vistaEntradaProducto> listarVistaEntradaProductosLN()
        {
            List<vistaEntradaProducto> lista = null;
            try
            {
                var sql = from x in EntradaProductoCD.listarVistaEntradaProductosCD()
                          select new vistaEntradaProducto(x.ID, x.Categoria, x.Producto, x.Proveedor, x.EmailProv, x.Empresa, x.EmailEmp, x.FechaIngreso, x.Cantidad,x.C_U, x.Total, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista entrada Productos LN" + error);
            }
            return lista;
        }

        public static List<vistaEntradaProducto> filtrarVistaEntradaProductosLN(string clave)
        {
            List<vistaEntradaProducto> lista = null;
            try
            {
                var sql = from x in EntradaProductoCD.filtrarVistaEntradaProductosCD(clave)
                          select new vistaEntradaProducto(x.ID, x.Categoria, x.Producto, x.Proveedor, x.EmailProv, x.Empresa, x.EmailEmp, x.FechaIngreso, x.Cantidad, x.C_U, x.Total, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista entrada Productos LN" + error);
            }
            return lista;
        }


        public static List<entradaProducto> listarEntradaProductosLN()
        {
            List<entradaProducto> lista = null;
            try
            {
                var sql = from x in EntradaProductoCD.listarEntradaProductosCD()
                          select new entradaProducto(x.Id_EntradaProducto, x.Id_Producto, x.Id_Proveedor, x.FechaIngreso, x.Cantidad, x.CostoUnitario, x.CostoTotal, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar entradaProductosLN" + error);
            }
            return lista;
        }

        public static List<entradaProducto> filtrarEntradaProductosLN(string clave)
        {
            List<entradaProducto> lista = null;
            try
            {
                var sql = from x in EntradaProductoCD.filtrarEntradaProductosCD(clave)
                          select new entradaProducto(x.Id_EntradaProducto, x.Id_Producto, x.Id_Proveedor, x.FechaIngreso, x.Cantidad, x.CostoUnitario, x.CostoTotal, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar entradaProductosLN" + error);
            }
            return lista;
        }

        public static bool insertarEntradaProductosLN(entradaProducto entradaProducto)
        {
            bool resul = false;
            try
            {
                EntradaProductoCD.insertarEntradaProductoCD(entradaProducto);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar entradaProductosLN" + error);
            }
            return resul;
        }

        public static bool modificarEntradaProductosLN(entradaProducto entradaProducto)
        {
            bool resul = false;
            try
            {
                EntradaProductoCD.modificarEntradaProductoCD(entradaProducto);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar entradaProductosLN" + error);
            }
            return resul;
        }

        public static bool eliminarEntradaProductosLN(int identradaProducto)
        {
            bool resul = false;
            try
            {
                EntradaProductoCD.eliminarEntradaProductoCD(identradaProducto);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar entradaProductosLN" + error);
            }
            return resul;
        }
    }
}
