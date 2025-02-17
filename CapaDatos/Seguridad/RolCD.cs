using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using rol = CapaEntidades.Gestion.Rol;

namespace CapaDatos.Seguridad
{
    public class RolCD
    {
        public static List<CP_ListarRolesResult> listarRolesCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarRolesResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarRoles().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Roles CD" + error);
            }
            return lista;
        }

        public static List<CP_FiltrarRolesResult> filtrarRolesCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarRolesResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltrarRoles(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Roles CD" + error);
            }
            return lista;
        }

        public static void insertarRolCD(rol Rol)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarRol(Rol.Nombre);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar Roles CD" + error);
            }
        }
        public static void modificarRolCD(rol Rol)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarRol(Rol.IdRol, Rol.Nombre);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en modificar Roles CD" + error);
            }
        }
        public static void eliminarRolCD(int idRol)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarRol(idRol);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en eliminar Roles CD" + error);
            }
        }

    }
}
