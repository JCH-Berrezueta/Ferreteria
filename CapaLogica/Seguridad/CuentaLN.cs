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


namespace CapaLogica.Seguridad
{
    public class CuentaLN
    {
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

        public static bool insertarCuenta(cuenta cuenta)
        {
            try
            {
                CuentaCD.insertarCuentaCD(cuenta);
                return true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Cuenta LN" + error);
            }
            return false;
        }

        public static void modificarCuenta(cuenta cuenta)
        {
            try
            {
                CuentaCD.modificarCuentaCD(cuenta);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Cuenta LN" + error);
            }
        }

        public static void eliminarCuenta(int idCuenta)
        {
            try
            {
                CuentaCD.eliminarCuentaCD(idCuenta);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Cuenta LN" + error);
            }
        }

        public static int getIdCuenta(string mail,string password)
        {
            //return cuenta.IdCuenta;
            //return listarCuentasLN().OrderByDescending(a => a.IdCuenta).FirstOrDefault().IdCuenta;
            List<cuenta> x = filtrarCuentasLN(mail,password);
            Debug.WriteLine(x.Count);
            int id = x[0].IdCuenta;
            Debug.WriteLine(id);
            return id;
        }

        

    }
}
