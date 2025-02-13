using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using producto = CapaEntidades.Gestion.Producto;

namespace CapaLogica.Gestion
{
    public class ProductoLN
    {
        public static List<producto> listarProductosLN()
        {
            List<producto> lista = null;
            try
            {
                var sql = from x in ProductoCD.listarProductosCD()
                          select new producto(x.Id_Producto, x.Id_CategoriaProducto, x.Nombre, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
                Debug.WriteLine("Intentanto LN" + lista.Count);
            }
            catch(Exception error)
            {
                Debug.WriteLine("Error listar Productos LN"+error);
            }
            return lista;
        }
    }
    public static bool AgregarProductoLN(Producto nuevoProducto)
        {
            try
            {
                return ProductoCD.AgregarProductoCD(nuevoProducto);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error al agregar producto: " + error);
                return false;
            }
        }

        public static bool ModificarProductoLN(Producto productoModificado)
        {
            try
            {
                return ProductoCD.ModificarProductoCD(productoModificado);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error al modificar producto: " + error);
                return false;
            }
        }

        public static bool EliminarProductoLN(int idProducto)
        {
            try
            {
                return ProductoCD.EliminarProductoCD(idProducto);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error al eliminar producto: " + error);
                return false;
            }
        }
    }
}
