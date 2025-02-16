using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cliente=CapaEntidades.Gestion.Cliente;
namespace CapaLogica.Gestion
{
    public class ClienteLN
    {
      

        public static List<cliente> listarClientesLN()
        {
            List<cliente> lista = null;
            try
            {
                var sql = from x in ClienteCD.listarClientesCD()
                          select new cliente(x.Id_Cliente, x.Id_Cuenta, x.Nombre, x.Apellido, x.FechaNacimiento, x.Edad, x.Telefono);
                lista = sql.ToList();
                Debug.WriteLine("Intentanto LN" + lista.Count);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Clientes LN" + error);
            }
            return lista;
        }
    }
}
