using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using producto = CapaEntidades.Gestion.Producto;
using VProducto = CapaEntidades.Vistas.VProductoCategoria;

namespace CapaLogica.Gestion
{
    public class ProductoLN
    {
        public static List<VProducto> listarVistaProductosLN()
        {
            List<VProducto> lista = null;
            try
            {
                var sql = from x in ProductoCD.listarVistaProductosCD()
                          select new VProducto(x.ID, x.Categoria, x.Producto, x.Precio, x.Stock, x.Estado, x.Icono, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Productos LN" + error);
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
                Debug.WriteLine("Intentanto LN" + lista.Count);
            }
            catch(Exception error)
            {
                Debug.WriteLine("Error listar Productos LN"+error);
            }
            return lista;
        }
    
    }
}
