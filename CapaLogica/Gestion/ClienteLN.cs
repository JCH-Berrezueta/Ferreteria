using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cliente=CapaEntidades.Gestion.Cliente;
using vistaClienteCuentaMail = CapaEntidades.Vistas.VClienteCuentaMail;
namespace CapaLogica.Gestion
{
    public class ClienteLN
    {
        public static List<vistaClienteCuentaMail> listarVistaClientesCuentaMailLN()
        {
            List<vistaClienteCuentaMail> lista = null;
            try
            {
                var sql = from x in ClienteCD.listarVistaClientesCuentasMailCD()
                          select new vistaClienteCuentaMail(x.ID, x.Nombre, x.Apellido, x.FechaNacimiento, x.Edad, x.Telefono, x.Mail);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Clientes Cuentas Mail LN" + error);
            }
            return lista;
        }

        public static List<vistaClienteCuentaMail> filtrarVistaClientesCuentaMailLN(string clave)
        {
            List<vistaClienteCuentaMail> lista = null;
            try
            {
                var sql = from x in ClienteCD.filtrarVistaClientesCuentasMailCD(clave)
                          select new vistaClienteCuentaMail(x.ID, x.Nombre, x.Apellido, x.FechaNacimiento, x.Edad, x.Telefono, x.Mail);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Clientes Cuentas Mail LN" + error);
            }
            return lista;
        }

        public static List<cliente> listarClientesLN()
        {
            List<cliente> lista = null;
            try
            {
                var sql = from x in ClienteCD.listarClientesCD()
                          select new cliente(x.Id_Cliente, x.Id_Cuenta, x.Nombre, x.Apellido, x.FechaNacimiento, x.Edad, x.Telefono);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Clientes LN" + error);
            }
            return lista;
        }

        public static List<cliente> filtrarClientesLN(string clave)
        {
            List<cliente> lista = null;
            try
            {
                var sql = from x in ClienteCD.filtrarClientesCD(clave)
                          select new cliente(x.Id_Cliente, x.Id_Cuenta, x.Nombre, x.Apellido, x.FechaNacimiento, x.Edad, x.Telefono);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Clientes LN" + error);
            }
            return lista;
        }

        public static bool insertarClienteLN(cliente nuevoCliente)
        {
            bool resul = false;
            try
            {
                ClienteCD.insertarClienteCD(nuevoCliente);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar clientes LN" + error);
            }
            return resul;
        }

        public static bool modificarCliente(cliente nuevoCliente)
        {
            bool resul = false;
            try
            {
                ClienteCD.modificarClienteCD(nuevoCliente);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar clientes LN" + error);
            }
            return resul;
        }

        public static bool eliminarCliente(int idCliente)
        {
            bool resul = false;
            try
            {
                ClienteCD.eliminarClienteCD(idCliente);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar clientes LN" + error);
            }
            return resul;
        }

        public static bool VerificarCodProducto(int v)
        {
            List<cliente> cuen = listarClientesLN();
            return cuen.Any(x => x.IdCliente == v);
        }
    }
}
