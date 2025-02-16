using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using producto = CapaEntidades.Gestion.Producto;

namespace CapaDatos.Gestion
{
    public class ProductoCD
    {
        public static List<listarVistaProductoCategoriaResult> listarVistaProductosCategoriasCD()
        {
            ConectorBDDataContext bd = null;
            List<listarVistaProductoCategoriaResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.listarVistaProductoCategoria().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista productos Categoria CD " + error);
            }
            return lista;
        }

        public static List<FiltrarVistaProductoCategoriaResult> filtrarVistaProductosCategoriasCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<FiltrarVistaProductoCategoriaResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.FiltrarVistaProductoCategoria(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista productos Categoria CD " + error);
            }
            return lista;
        }

        public static List<CP_ListarProductosResult> listarProductosCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarProductosResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarProductos().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar productos CD " + error);
            }
            return lista;
        }

        public static List<CP_FiltrarProductosResult> filtrarProductosCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarProductosResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltrarProductos(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar productos CD " + error);
            }
            return lista;
        }

        public static void insertarProductoCD(producto producto)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarProducto(producto.IdCategoriaProducto, producto.Nombre, producto.Precio, producto.Stock, producto.Estado, producto.Icono, producto.Descripcion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar productos CD " + error);
            }
        }

        public static void modificarProductoCD(producto producto)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarProducto(producto.IdProducto, producto.IdCategoriaProducto, producto.Nombre, producto.Precio, producto.Stock, producto.Estado, producto.Icono, producto.Descripcion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar productos CD " + error);
            }
        }

        public static void eliminarProductoCD(int idProducto)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarProducto(idProducto);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar productos CD " + error);
            }
        }

    }

}
