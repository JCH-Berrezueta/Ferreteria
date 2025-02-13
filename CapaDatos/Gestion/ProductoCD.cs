using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Gestion
{
    public class ProductoCD
    {
        public static List<CP_ListarProductosResult> listarProductosCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarProductosResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext("Data Source=DESKTOP-O65TFRR;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                lista = bd.CP_ListarProductos().ToList();
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
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                lista = bd.CP_FiltrarProductos(clave).ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar productos CD " + error);
            }
            return lista;
        }
        public static bool AgregarProductoCD(Producto nuevoProducto)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Id_CategoriaProducto, Nombre, Precio, Stock, Estado, Icono, Descripcion) VALUES (@categoria, @nombre, @precio, @stock, @estado, @icono, @descripcion)", con);

                cmd.Parameters.AddWithValue("@categoria", nuevoProducto.Id_CategoriaProducto);
                cmd.Parameters.AddWithValue("@nombre", nuevoProducto.Nombre);
                cmd.Parameters.AddWithValue("@precio", nuevoProducto.Precio);
                cmd.Parameters.AddWithValue("@stock", nuevoProducto.Stock);
                cmd.Parameters.AddWithValue("@estado", nuevoProducto.Estado);
                cmd.Parameters.AddWithValue("@icono", (object)nuevoProducto.Icono ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@descripcion", nuevoProducto.Descripcion);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool ModificarProductoCD(Producto productoModificado)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET Nombre=@nombre, Precio=@precio, Stock=@stock, Estado=@estado, Icono=@icono, Descripcion=@descripcion WHERE Id_Producto=@id", con);

                cmd.Parameters.AddWithValue("@id", productoModificado.Id_Producto);
                cmd.Parameters.AddWithValue("@nombre", productoModificado.Nombre);
                cmd.Parameters.AddWithValue("@precio", productoModificado.Precio);
                cmd.Parameters.AddWithValue("@stock", productoModificado.Stock);
                cmd.Parameters.AddWithValue("@estado", productoModificado.Estado);
                cmd.Parameters.AddWithValue("@icono", (object)productoModificado.Icono ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@descripcion", productoModificado.Descripcion);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarProductoCD(int idProducto)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE Id_Producto=@id", con);
                cmd.Parameters.AddWithValue("@id", idProducto);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

}
