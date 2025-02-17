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


        public static void insertarCuenta()
        {
            try
            {

            }
            catch (Exception error)
            {
                
            }
        }

        public static int getIdCuenta(cuenta cuenta)
        {
            //cuenta auxiliar = listarCuentasLN().OrderByDescending(a => a.IdCuenta).FirstOrDefault(); LAMBDA
            return filtrarCuentasLN(cuenta.Mail, cuenta.Password)[0].IdCuenta;
        }
       
    }
}
