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

        public static List<cuenta> filtrarCuentasLN(string clave)
        {
            List<cuenta> lista = null;
            try
            {
                var sql = from x in CuentaCD.filtrarCuentasCD(clave)
                          select new cuenta(x.Id_Cuenta, x.Id_rol, x.Mail, x.Password);
                lista = sql.ToList();
                Debug.WriteLine("Intentanto LN" + lista.Count);
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Cuentas LN" + error);
            }
            return lista;
        }

    }
}
