using CapaDatos.Gestion;
using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using empresa = CapaEntidades.Gestion.Empresa;

namespace CapaLogica.Gestion
{
    public class EmpresaLN
    {
        public static List<empresa> listarEmpresasLN()
        {
            List<empresa> lista = null;
            try
            {
                var sql = from x in EmpresaCD.listarEmpresasCD()
                          select new empresa(x.Id_Empresa, x.Nombre, x.Ruc, x.Direccion, x.Representante, x.Telefono, x.Mail, x.Descripcion, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Empresas LN" + error);
            }
            return lista;
        }

        public static List<empresa> filtrarEmpresasLN(string clave)
        {
            List<empresa> lista = null;
            try
            {
                var sql = from x in EmpresaCD.filtrarEmpresasCD(clave)
                          select new empresa(x.Id_Empresa, x.Nombre, x.Ruc, x.Direccion, x.Representante, x.Telefono, x.Mail, x.Descripcion, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Empresas LN" + error);
            }
            return lista;
        }

        public static bool insertarEmpresaLN(empresa Empresa)
        {
            bool resul = false;
            try
            {
                EmpresaCD.insertarEmpresaCD(Empresa);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Empresa LN" + error);
            }
            return resul;
        }

        public static bool modificarEmpresaLN(empresa Empresa)
        {
            bool resul = false;
            try
            {
                EmpresaCD.modificarEmpresaCD(Empresa);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Empresa LN" + error);
            }
            return resul;
        }

        public static bool eliminarEmpresaLN(int idEmpresa)
        {
            bool resul = false;
            try
            {
                EmpresaCD.eliminarEmpresaCD(idEmpresa);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar Empresa LN" + error);
            }
            return resul;
        }
    }
}
