using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using empresa = CapaEntidades.Gestion.Empresa;

namespace CapaDatos.Gestion
{
    public class EmpresaCD
    {
        public static List<CP_ListarEmpresasResult> listarEmpresasCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarEmpresasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarEmpresas().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Empresas CD" + error);
            }
            return lista;
        }

        public static List<CP_FiltraEmpresasResult> filtrarEmpresasCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltraEmpresasResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltraEmpresas(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Empresas CD" + error);
            }
            return lista;
        }

        public static void insertarEmpresaCD(empresa Empresa)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarEmpresa(Empresa.Nombre, Empresa.Ruc, Empresa.Direccion, Empresa.Representante, Empresa.Telefono, Empresa.Mail, Empresa.Descripcion, Empresa.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar Empresas CD" + error);
            }
        }
        public static void modificarEmpresaCD(Empresa Empresa)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarEmpresa(Empresa.Id_Empresa, Empresa.Nombre, Empresa.Ruc, Empresa.Direccion, Empresa.Representante, Empresa.Telefono, Empresa.Mail, Empresa.Descripcion, Empresa.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en modificar Empresas CD" + error);
            }
        }
        public static void eliminarEmpresaCD(int idEmpresa)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarEmpresa(idEmpresa);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en eliminar Empresas CD" + error);
            }
        }
    }
}
