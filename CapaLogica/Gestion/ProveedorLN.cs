using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proveedor = CapaEntidades.Gestion.Proveedor;
using vistaProveedorEmpresa = CapaEntidades.Vistas.VProveedorEmpresa;

namespace CapaLogica.Gestion
{
    public class ProveedorLN
    {
        //public static List<vistaProveedorEmpresa> listarVistaProveedoresEmpresaLN()
        //{
        //    List<vistaProveedorEmpresa> lista = null;
        //    try
        //    {
        //        var sql = from x in ProveedorCD.listarVistaProveedoresEmpresasCD()
        //                  select new vistaProveedorEmpresa(x.ID, x.Empresa, x.Empresa, x.FechaNacimiento, x.Edad, x.Mail, x.Telefono, x.Observacion);
        //        lista = sql.ToList();
        //    }
        //    catch (Exception error)
        //    {
        //        Debug.WriteLine("Error listar Vista Proveedores Empresa LN" + error);
        //    }
        //    return lista;
        //}

        public static List<vistaProveedorEmpresa> filtrarVistaProveedoresEmpresaLN(string clave)
        {
            List<vistaProveedorEmpresa> lista = null;
            try
            {
                var sql = from x in ProveedorCD.filtrarVistaProveedoresEmpresasCD(clave)
                          select new vistaProveedorEmpresa(x.ID, x.Empresa, x.Empresa, x.FechaNacimiento, x.Edad, x.Mail, x.Telefono, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Proveedores Empresa LN" + error);
            }
            return lista;
        }

        public static List<proveedor> listarProveedoresLN()
        {
            List<proveedor> lista = null;
            try
            {
                var sql = from x in ProveedorCD.listarProveedorsCD()
                          select new proveedor(x.Id_Proveedor,x.Id_Empresa, x.Nombre, x.Apellido, x.FechaNacimiento, x.Edad, x.Mail, x.Telefono, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Proveedores LN" + error);
            }
            return lista;
        }
    

        public static List<proveedor> filtrarProveedoresLN(string clave)
        {
            List<proveedor> lista = null;
            try
            {
                var sql = from x in ProveedorCD.filtrarProveedorsCD(clave)
                          select new proveedor(x.Id_Proveedor,x.Id_Empresa, x.Nombre, x.Apellido, x.FechaNacimiento, x.Edad, x.Mail, x.Telefono, x.Observacion);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Proveedores LN" + error);
            }
            return lista;
        }

        public static bool insertarProveedorLN(proveedor Proveedor)
        {
            bool resul = false;
            try
            {
                ProveedorCD.insertarProveedorCD(Proveedor);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar Proveedores LN" + error);
            }
            return resul;
        }

        public static bool modirficarProveedorLN(proveedor Proveedor)
        {
            bool resul = false;
            try
            {
                ProveedorCD.modificarProveedorCD(Proveedor);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar Proveedores LN" + error);
            }
            return resul;
        }

        public static bool eliminarProveedorLN(int idProveedor)
        {
            bool resul = false;
            try
            {
                ProveedorCD.eliminarProveedorCD(idProveedor);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar Proveedores LN" + error);
            }
            return resul;
        }

    }

}
