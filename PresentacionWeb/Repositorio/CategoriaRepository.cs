using CapaEntidades.Gestion;
using Microsoft.Data.SqlClient;
using System.Data;

namespace PresentacionWeb.Repositorio
{
    public class CategoriaRepository
    {
        private readonly string _connectionString;

        public CategoriaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Categoria> ObtenerCategorias()
        {
            var categorias = new List<Categoria>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("CP_ListarCategoriasProductos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var categoria = new Categoria()
                            {
                                IdCategoria = reader.GetInt32(reader.GetOrdinal("Id_CategoriaProducto")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"))
                            };
                            categorias.Add(categoria);
                        }
                    }
                }
            }

            return categorias;
        }


        public void InsertarCategoria(string nombre, string descripcion)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("CP_InsertarCategoriaProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ModificarCategoria(int id, string nombre, string descripcion)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("CP_ModificarCategoriaProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EliminarCategoria(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("CP_EliminarCategoriaProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
