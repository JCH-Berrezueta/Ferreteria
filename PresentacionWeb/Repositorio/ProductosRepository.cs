using CapaEntidades.Gestion;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PresentacionWeb.Repositorio
{
    public class ProductosRepository
    {
        private readonly string _connectionString;

        public ProductosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Producto> ObtenerProducto()
        {
            var Productos = new List<Producto>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("CP_ListarProductos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var producto = new Producto()
                            {
                                IdProducto = reader.GetInt32(reader.GetOrdinal("Id_Producto")),
                                IdCategoriaProducto = reader.GetInt32(reader.GetOrdinal("Id_CategoriaProducto")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Precio = reader.GetDecimal(reader.GetOrdinal("Precio")),
                                Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                Estado = reader.GetString(reader.GetOrdinal("Estado")),
                                Icono = reader.GetString(reader.GetOrdinal("Icono")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"))
                            };
                            Productos.Add(producto);
                        }
                    }
                }
            }
            return Productos;
        }


        public void InsertarProducto(int idCategoriaProducto, string nombre,decimal precio,int stock,string estado,string icono,string descripcion)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("CP_InsertarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdCategoriaProducto", idCategoriaProducto);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@Stock", icono);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ModificarProducto(int idCategoriaProducto, string nombre, decimal precio, int stock, string estado, string icono, string descripcion)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("CP_ModificarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdCategoriaProducto", idCategoriaProducto);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@Icono", icono);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EliminarProducto(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("CP_EliminarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        
    }
}
