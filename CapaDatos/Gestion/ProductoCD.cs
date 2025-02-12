using System;
using System.Collections.Generic;
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
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarProductos().ToList();
            }
            catch(Exception error)
            {
                Debug.WriteLine("Error listar productos CD "+error);
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
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar productos CD " + error);
            }
            return lista;
        }
    }
}
