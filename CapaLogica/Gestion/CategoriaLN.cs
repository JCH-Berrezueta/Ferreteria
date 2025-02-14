using CapaDatos.Gestion;
using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Gestion
{
    public class CategoriaLN
    {
        public List<Categoria> listarCategoriaLN()
        {
            List<Categoria> lista = null;
            try
            {
                var sql = from x in CategoriaCD.listarCategoriasCD()
                          select new Categoria(x.Id_CategoriaProducto,x.Nombre,x.Descripcion);
                lista = sql.ToList();
                Debug.WriteLine("Intentanto LN" + lista.Count);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Categorias LN" + error);
            }
            return lista;
        }


    }
}
