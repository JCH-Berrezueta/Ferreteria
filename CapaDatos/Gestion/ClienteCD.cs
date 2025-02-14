using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cliente = CapaEntidades.Gestion.Cliente;

namespace CapaDatos.Gestion
{
    public class ClienteCD
    {
        public static List<listarVistaClienteCuentaMailResult> listarVistaClientesCuentasMailCD()
        {
            ConectorBDDataContext bd = null;
            List<listarVistaClienteCuentaMailResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.listarVistaClienteCuentaMail().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Clientes CD" + error);
            }
            return lista;
        }


        public static List<CP_ListarClientesResult> listarClientesCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarClientesResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
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
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltrarClientes(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Clientes CD" + error);
            }
            return lista;
        }

        public static void insertarClienteCD(cliente Cliente)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarCliente(Cliente.IdCuenta, Cliente.Nombre, Cliente.Apellido, Cliente.FechaNacimiento, Cliente.Edad, Cliente.Telefono);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar Clientes CD" + error);
            }
        }
        public static void modificarClienteCD(cliente Cliente)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarCliente(Cliente.IdCliente, Cliente.IdCuenta, Cliente.Nombre, Cliente.Apellido, Cliente.FechaNacimiento, Cliente.Edad, Cliente.Telefono);
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
                bd = new ConectorBDDataContext();
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
