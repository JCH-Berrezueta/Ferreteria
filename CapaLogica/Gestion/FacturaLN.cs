using CapaDatos.Gestion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factura = CapaEntidades.Gestion.Factura;
using vistaFacturaCliente = CapaEntidades.Vistas.VFacturaCliente;

namespace CapaLogica.Gestion
{
    public class FacturaLN
    {
        public static List<vistaFacturaCliente> listarVistaFacturasClientesLN()
        {
            List<vistaFacturaCliente> lista = null;
            try
            {
                var sql = from x in FacturaCD.listarVistaFacturasClientesCD()
                          select new vistaFacturaCliente(x.Num_Factura, x.Cliente, x.Mail, x.FechaEmision, x.MetodoPago, x._IVA, x._Total);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error listar Vista Facturas Clientes LN" + error);
            }
            return lista;
        }

        public static List<vistaFacturaCliente> filtrarVistaFacturasClientesLN(string clave)
        {
            List<vistaFacturaCliente> lista = null;
            try
            {
                var sql = from x in FacturaCD.filtrarVistaFacturasClientesCD(clave)
                          select new vistaFacturaCliente(x.Num_Factura, x.Cliente, x.Mail, x.FechaEmision, x.MetodoPago, x._IVA, x._Total);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar Vista Facturas Clientes LN" + error);
            }
            return lista;
        }


        public static List<factura> listarFacturasLN()
        {
            List<factura> lista = null;
            try
            {
                var sql = from x in FacturaCD.listarFacturasCD()
                          select new factura(x.Id_Factura, x.Id_Cliente, x.FechaEmision, x.MetodoPago, x.Total, x.Iva);
                lista = sql.ToList();
            }
            catch(Exception error)
            {
                Debug.WriteLine("Error listar FacturasLN" + error);
            }
            return lista;
        }

        public static List<factura> filtrarFacturasLN(string clave)
        {
            List<factura> lista = null;
            try
            {
                var sql = from x in FacturaCD.filtrarFacturasCD(clave)
                          select new factura(x.Id_Factura, x.Id_Cliente, x.FechaEmision, x.MetodoPago, x.Total, x.Iva);
                lista = sql.ToList();
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error filtrar FacturasLN" + error);
            }
            return lista;
        }

        public static bool insertarFacturasLN(factura Factura)
        {
            bool resul = false;
            try
            {
                FacturaCD.insertarFacturaCD(Factura);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error insertar FacturasLN" + error);
            }
            return resul;
        }

        public static bool modificarFacturasLN(factura Factura)
        {
            bool resul = false;
            try
            {
                FacturaCD.modificarFacturaCD(Factura);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error modificar FacturasLN" + error);
            }
            return resul;
        }

        public static bool eliminarFacturasLN(int idFactura)
        {
            bool resul = false;
            try
            {
                FacturaCD.eliminarFacturaCD(idFactura);
                resul = true;
            }
            catch (Exception error)
            {
                Debug.WriteLine("Error eliminar FacturasLN" + error);
            }
            return resul;
        }
    }
}
