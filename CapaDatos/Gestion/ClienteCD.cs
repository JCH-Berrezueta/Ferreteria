using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cliente = CapaEntidades.Gestion.Cliente;

namespace CapaDatos.Gestion
{
    public class ClienteCD
    {
        public static List<CP_ListarClientesResult> listarClientesCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarClientesResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                lista = bd.CP_ListarClientes().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Clientes CD" + error);
            }
            return lista;
        }

        public static List<CP_FiltrarClientesResult> filtrarClientesCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarClientesResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                lista = bd.CP_FiltrarClientes(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Clientes CD" + error);
            }
            return lista;
        }

        public static void insertarClienteCD(Cliente Cliente)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                bd.CP_InsertarCliente(Cliente.Id_Cuenta, Cliente.Nombre, Cliente.Apellido, Cliente.FechaNacimiento, Cliente.Edad, Cliente.Telefono);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar Clientes CD" + error);
            }
        }
        public static void modificarClienteCD(Cliente Cliente)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                bd.CP_ModificarCliente(Cliente.Id_Cliente, Cliente.Id_Cuenta, Cliente.Nombre, Cliente.Apellido, Cliente.FechaNacimiento, Cliente.Edad, Cliente.Telefono);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en modificar Clientes CD" + error);
            }
        }
        public static void eliminarClienteCD(int idCliente)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext("Data Source=DESKTOP-M2DUKGS;Initial Catalog=FerreteriaPA;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                bd.CP_EliminarCliente(idCliente);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en eliminar Clientes CD" + error);
            }
        }

    }
}
