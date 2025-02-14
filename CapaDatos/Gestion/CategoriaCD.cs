using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Categoria = CapaEntidades.Gestion.Categoria;

namespace CapaDatos.Gestion
{
    public class CategoriaCD
    {
        static string ruta = "Data Source=CASA;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=False\"";

        public static List<CP_ListarCategoriasProductosResult> listarCategoriasCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarCategoriasProductosResult> lista = null;
            try
            {
<<<<<<< HEAD
                bd = new ConectorBDDataContext(ruta);
=======
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
>>>>>>> 922f477eebdfa5dfd0c749a1f9769d5d30cbb946
                lista = bd.CP_ListarCategoriasProductos().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Categorias CD" + error);
            }
            return lista;
        }

        public static List<CP_FiltrarCategoriasProductosResult> filtrarCategoriasCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarCategoriasProductosResult> lista = null;
            try
            {
<<<<<<< HEAD
                bd = new ConectorBDDataContext(ruta);
=======
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
>>>>>>> 922f477eebdfa5dfd0c749a1f9769d5d30cbb946
                lista = bd.CP_FiltrarCategoriasProductos(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Categorias CD" + error);
            }
            return lista;
        }

        public static void insertarCategoriaCD(Categoria Categoria)
        {
            ConectorBDDataContext bd = null;
            try
            {
<<<<<<< HEAD
                bd = new ConectorBDDataContext(ruta);
=======
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
>>>>>>> 922f477eebdfa5dfd0c749a1f9769d5d30cbb946
                bd.CP_InsertarCategoriaProducto(Categoria.Nombre, Categoria.Descripcion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar Categorias CD" + error);
            }
        }
        public static void modificarCategoriaCD(Categoria Categoria)
        {
            ConectorBDDataContext bd = null;
            try
            {
<<<<<<< HEAD
                bd = new ConectorBDDataContext(ruta);
=======
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
>>>>>>> 922f477eebdfa5dfd0c749a1f9769d5d30cbb946
                bd.CP_ModificarCategoriaProducto(Categoria.IdCategoria, Categoria.Nombre, Categoria.Descripcion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en modificar Categorias CD" + error);
            }
        }
        public static void eliminarCategoriaCD(int idCategoria)
        {
            ConectorBDDataContext bd = null;
            try
            {
<<<<<<< HEAD
                bd = new ConectorBDDataContext(ruta);
=======
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
>>>>>>> 922f477eebdfa5dfd0c749a1f9769d5d30cbb946
                bd.CP_EliminarCategoriaProducto(idCategoria);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en eliminar Categorias CD" + error);
            }
        }
    }
}
