using CapaDatos;
using CapaDatos.Gestion;
using CapaDatos.Seguridad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cuenta = CapaEntidades.Gestion.Cuenta;
using vistaCuentaRol = CapaEntidades.Vistas.VCuentaRol;

namespace CapaLogica.Seguridad
{
    public class CuentaLN
    {

        public static List<vistaCuentaRol> listarVistaCuentasRolesLN()
        {
            List<vistaCuentaRol> lista = null;
            try
            {
                var sql = from x in CuentaCD.listarVistaCuentasRolCD()
                          select new vistaCuentaRol(x.ID, x.Rol, x.Mail);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Cuentas Roles LN" + error);
            }
            return lista;
        }

        public static List<vistaCuentaRol> filtrarVistaCuentasRolesLN(string clave)
        {
            List<vistaCuentaRol> lista = null;
            try
            {
                var sql = from x in CuentaCD.filtrarVistaCuentasRolCD(clave)
                          select new vistaCuentaRol(x.ID, x.Rol, x.Mail);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Cuentas Roles LN" + error);
            }
            return lista;
        }


        public static List<cuenta> listarCuentasLN()
        {
            List<cuenta> lista = null;
            try
            {
                var sql = from x in CuentaCD.listarCuentasCD()
                          select new cuenta(x.Id_Cuenta,x.Id_rol,x.Mail, x.Password);
                lista = sql.ToList();
            }
            catch(Exception error)
            {
                Debug.WriteLine("Error listar Cuentas LN" + error);
            }
            return lista;
        }

        public static List<cuenta> filtrarCuentasLN(string user, string passwd)
        {
            List<cuenta> lista = null;
            try
            {
                var sql = from x in CuentaCD.filtrarCuentasCD(user, passwd)
                          select new cuenta(x.Id_Cuenta, x.Id_rol, x.Mail, x.Password);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Cuentas LN" + error);
            }
            return lista;
        }

        public static bool insertarCuentaLN(cuenta cuenta)
        {
            bool resul = false;
            try
            {
                CuentaCD.insertarCuentaCD(cuenta);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Cuenta LN" + error);
            }
            return resul;
        }

        public static bool modificarCuentaLN(cuenta cuenta)
        {
            bool resul = false;
            try
            {
                CuentaCD.modificarCuentaCD(cuenta);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Cuenta LN" + error);
            }
            return resul;
        }

        public static bool eliminarCuentaLN(int idCuenta)
        {
            bool resul = false;
            try
            {
                CuentaCD.eliminarCuentaCD(idCuenta);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Cuenta LN" + error);
            }
            return resul;
        }

        public static int getIdCuentaLN(string mail,string password)
        {
            return filtrarCuentasLN(mail,password)[0].IdCuenta;
        }

        public static bool autenticarCuentaLN(cuenta Cuenta)
        {
            bool resul = false;
            List<cuenta> cuentas = null;
            try
            {
                cuentas = filtrarCuentasLN(Cuenta.Mail, Cuenta.Password);
                if (cuentas.Count == 1)
                {
                    resul = true;
                    Debug.WriteLine("si llegamos aqui existe");
                }
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error Autenticar Cuenta LN" + error);
            }
            return resul;
        }

    }
}
