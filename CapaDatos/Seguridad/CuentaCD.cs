using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cuenta = CapaEntidades.Gestion.Cuenta;

namespace CapaDatos.Seguridad
{
    public class CuentaCD
    {
        

        public static List<listarVistaCuentaRolResult> listarVistaCuentasRolCD()
        {
            ConectorBDDataContext bd = null;
            List<listarVistaCuentaRolResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.listarVistaCuentaRol().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Vista Cuentas Roles CD" + error);
            }
            return lista;
        }

        public static List<FiltrarVistaCuentaRolResult> filtrarVistaCuentasRolCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<FiltrarVistaCuentaRolResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.FiltrarVistaCuentaRol(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Vista Cuentas Roles CD" + error);
            }
            return lista;
        }

        public static List<CP_ListarCuentasResult> listarCuentasCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarCuentasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarCuentas().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Cuentas CD" + error);
            }
            return lista;
        }

        public static List<CP_FiltrarCuentasResult> filtrarCuentasCD(string user, string passwd)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarCuentasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltrarCuentas(user, passwd).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Cuentas CD" + error);
            }
            return lista;
        }

        public static void insertarCuentaCD(cuenta Cuenta)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarCuenta(Cuenta.IdRol, Cuenta.Mail, Cuenta.Password);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar Cuentas CD" + error);
            }
        }
        public static void modificarCuentaCD(cuenta Cuenta)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarCuenta(Cuenta.IdCuenta, Cuenta.IdRol, Cuenta.Mail, Cuenta.Password);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en modificar Cuentas CD" + error);
            }
        }
        public static void eliminarCuentaCD(int idCuenta)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarCuenta(idCuenta);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en eliminar Cuentas CD" + error);
            }
        }

    }
}
