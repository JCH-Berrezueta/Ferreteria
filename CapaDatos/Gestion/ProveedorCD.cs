using CapaEntidades.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using proveedor = CapaEntidades.Gestion.Proveedor;

namespace CapaDatos.Gestion
{
    public class ProveedorCD
    {
        //public static List<listarVistaProveedorEmpresaResult> listarVistaProveedoresEmpresasCD()
        //{
        //    ConectorBDDataContext bd = null;
        //    List<listarVistaProveedorEmpresaResult> lista = null;
        //    try
        //    {
        //        bd = new ConectorBDDataContext();
        //        lista = bd.listarVistaProveedorEmpresa().ToList();
        //        bd.SubmitChanges();
        //    }
        //    catch (Exception error)
        //    {
        //        Debug.WriteLine("Error en listar Vista Proveedors Empresa CD" + error);
        //    }
        //    return lista;
        //}

        public static List<FiltrarVistaProveedorEmpresaResult> filtrarVistaProveedoresEmpresasCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<FiltrarVistaProveedorEmpresaResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.FiltrarVistaProveedorEmpresa(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Vista Proveedors Empresa CD" + error);
            }
            return lista;
        }

        public static List<CP_ListarProveedoresResult> listarProveedorsCD()
        {
            ConectorBDDataContext bd = null;
            List<CP_ListarProveedoresResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_ListarProveedores().ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en listar Proveedors CD" + error);
            }
            return lista;
        }

        public static List<CP_FiltrarProveedoresResult> filtrarProveedorsCD(string clave)
        {
            ConectorBDDataContext bd = null;
            List<CP_FiltrarProveedoresResult> lista = null;
            try
            {
                bd = new ConectorBDDataContext();
                lista = bd.CP_FiltrarProveedores(clave).ToList();
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en filtrar Proveedors CD" + error);
            }
            return lista;
        }

        public static void insertarProveedorCD(proveedor Proveedor)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_InsertarProveedor(Proveedor.IdEmpresa, Proveedor.Nombre, Proveedor.Apellido, Proveedor.FechaNacimiento, Proveedor.Edad, Proveedor.Mail, Proveedor.Telefono, Proveedor.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en insertar Proveedors CD" + error);
            }
        }
        public static void modificarProveedorCD(proveedor Proveedor)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_ModificarProveedor(Proveedor.IdProveedor, Proveedor.IdEmpresa, Proveedor.Nombre, Proveedor.Apellido, Proveedor.FechaNacimiento, Proveedor.Edad, Proveedor.Mail, Proveedor.Telefono, Proveedor.Observacion);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en modificar Proveedors CD" + error);
            }
        }
        public static void eliminarProveedorCD(int idProveedor)
        {
            ConectorBDDataContext bd = null;
            try
            {
                bd = new ConectorBDDataContext();
                bd.CP_EliminarProveedor(idProveedor);
                bd.SubmitChanges();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error en eliminar Proveedors CD" + error);
            }
        }

    }
}
