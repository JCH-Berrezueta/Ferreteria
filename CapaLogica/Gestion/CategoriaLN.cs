using CapaDatos;
using CapaDatos.Gestion;
using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using categoria = CapaEntidades.Gestion.Categoria;

namespace CapaLogica.Gestion
{
    public class CategoriaLN
    {
        public static List<categoria> listarCategoriaLN()
        {
            List<categoria> lista = null;
            try
            {
                var sql = from x in CategoriaCD.listarCategoriasCD()
                          select new categoria(x.Id_CategoriaProducto,x.Nombre,x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Categorias LN" + error);
            }
            return lista;
        }

        public static List<categoria> filtrarCategoriaLN(string clave)
        {
            List<categoria> lista = null;
            try
            {
                var sql = from x in CategoriaCD.filtrarCategoriasCD(clave)
                          select new categoria(x.Id_CategoriaProducto, x.Nombre, x.Descripcion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Categorias LN" + error);
            }
            return lista;
        }

        public static bool insertarCategoriaLN(categoria Categoria)
        {
            bool resul = false;
            try
            {
                CategoriaCD.insertarCategoriaCD(Categoria);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Categoria LN" + error);
            }
            return resul;
        }

        public static bool modificarCategoriaLN(categoria Categoria)
        {
            bool resul = false;
            try
            {
                CategoriaCD.modificarCategoriaCD(Categoria);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Categoria LN" + error);
            }
            return resul;
        }

        public static bool eliminarCategoriaLN(int idCategoria)
        {
            bool resul = false;
            try
            {
                CategoriaCD.eliminarCategoriaCD(idCategoria);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar Categoria LN" + error);
            }
            return resul;
        }

        public static bool VerificarCodProducto(int v)
        {
            List<categoria> categorias=listarCategoriaLN();
            return categorias.Any(x => x.IdCategoria == v);
        }
    }
}
