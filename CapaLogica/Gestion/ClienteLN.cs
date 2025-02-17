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

        public static bool IngresarCliente(cliente nuevoCliente)
        {
            try
            {
                ClienteCD.insertarClienteCD(nuevoCliente);
                return true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar clientes LN" + error);
            }
            return false;
        }

        public static bool modificarCliente(cliente nuevoCliente)
        {
            try
            {
                ClienteCD.modificarClienteCD(nuevoCliente);
                return true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar clientes LN" + error);
            }
            return false;
        }

        public static bool eliminarCliente(int idCliente)
        {
            try
            {
                ClienteCD.eliminarClienteCD(idCliente);
                return true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar clientes LN" + error);
            }
            return false;
        }


    }
}
