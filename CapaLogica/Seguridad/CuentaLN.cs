using CapaDatos.Seguridad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadCuenta = CapaEntidades.Gestion.Cuenta;


namespace CapaLogica.Seguridad
{
    public class CuentaLN
    {
        public static List<EntidadCuenta> listarCuentasLN()
        {
            List<EntidadCuenta> lista = null;
            try
            {
                var sql = from x in CuentaCD.listarCuentasCD()
                          select new EntidadCuenta(x.Id_Cuenta,x.Id_rol,x.Mail, x.Password);
                lista = sql.ToList();
                Debug.WriteLine("Intentanto LN" + lista.Count);
            }
            catch(Exception error)
            {
                Debug.WriteLine("Error listar Vista Cuentas LN" + error);
            }
            return lista;
        }
       
    }
}
