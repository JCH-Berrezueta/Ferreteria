using CapaDatos.Gestion;
using CapaDatos.Seguridad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rol = CapaEntidades.Gestion.Rol;

namespace CapaLogica.Seguridad
{
    public class RolLN
    {
        public static List<rol> listarRolsLN()
        {
            List<rol> lista = null;
            try
            {
                var sql = from x in RolCD.listarRolesCD()
                          select new rol(x.Id_rol, x.Nombre);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar rols LN" + error);
            }
            return lista;
        }

        public static List<rol> filtrarRolsLN(string clave)
        {
            List<rol> lista = null;
            try
            {
                var sql = from x in RolCD.filtrarRolesCD(clave)
                          select new rol(x.Id_rol, x.Nombre);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar rols LN" + error);
            }
            return lista;
        }

        public static bool insertarRolLN(rol Rol)
        {
            bool resul = false;
            try
            {
                RolCD.insertarRolCD(Rol);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar rol LN" + error);
            }
            return resul;
        }

        public static bool modificarRolLN(rol rol)
        {
            bool resul = false;
            try
            {
                RolCD.modificarRolCD(rol);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar rol LN" + error);
            }
            return resul;
        }

        public static bool eliminarRolLN(int idrol)
        {
            bool resul = false;
            try
            {
                RolCD.eliminarRolCD(idrol);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar rol LN" + error);
            }
            return resul;
        }
    }
}
