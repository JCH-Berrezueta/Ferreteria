using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using producto = CapaEntidades.Gestion.Producto;
using vistaProductoCategoria = CapaEntidades.Vistas.VProductoCategoria;

namespace CapaLogica.Gestion
{
    public class ProductoLN
    {
        public static List<vistaProductoCategoria> listarVistaProductosLN()
        {
            List<vistaProductoCategoria> lista = null;
            try
            {
                var sql = from x in ProductoCD.listarVistaProductosCategoriasCD()
                          select new vistaProductoCategoria(x.ID, x.Categoria, x.Producto, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Productos categorias LN" + error);
            }
            return lista;
        }

        public static List<vistaProductoCategoria> filtrarVistaProductosLN(string clave)
        {
            List<vistaProductoCategoria> lista = null;
            try
            {
                var sql = from x in ProductoCD.filtrarVistaProductosCategoriasCD(clave)
                          select new vistaProductoCategoria(x.ID, x.Categoria, x.Producto, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Productos categorias LN" + error);
            }
            return lista;
        }

        public static List<producto> listarProductosLN()
        {
            List<producto> lista = null;
            try
            {
                var sql = from x in ProductoCD.listarProductosCD()
                          select new producto(x.Id_Producto, x.Id_CategoriaProducto, x.Nombre, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch(Exception error)
            {
                Debug.WriteLine("Error listar Productos LN"+error);
            }
            return lista;
        }

        public static List<producto> filtrarProductosLN(string clave)
        {
            List<producto> lista = null;
            try
            {
                var sql = from x in ProductoCD.filtrarProductosCD(clave)
                          select new producto(x.Id_Producto, x.Id_CategoriaProducto, x.Nombre, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Productos LN" + error);
            }
            return lista;
        }

        public static bool VerificarCodProducto(int idProdu)
        {
            List<producto> categorias = listarProductosLN();

            return categorias.Any(c => c.IdProducto == idProdu);
        }

        public static bool InsertarProducto(producto p)
        {
            bool resul = false;
            try
            {
                ProductoCD.insertarProductoCD(p);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Producto LN" + error);
            }
            return resul;
        }

        public static bool ActualizarProducto(producto p)
        {
            bool resul = false;
            try
            {
                ProductoCD.modificarProductoCD(p);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error actualizar Producto LN" + error);
            }
            return resul;
        }

        public static bool EliminarProducto(int id)
        {
            bool resul = false;
            try
            {
                ProductoCD.eliminarProductoCD(id);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar Producto LN" + error);
            }
            return resul;
        }
    }
}
