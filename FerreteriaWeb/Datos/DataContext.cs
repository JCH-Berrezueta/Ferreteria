using CapaEntidades.Gestion;
using Microsoft.EntityFrameworkCore;

namespace PresentacionWeb.Datos
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Rol> rols { get; set; }
        public DbSet<Cuenta> cuentas { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Proveedor> proveedors { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<DetalleFactura> detalleFacturas { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<EntradaProducto> entradaProductos { get; set; }
        public DbSet<SalidaProducto> salidaProductos { get; set; }

    }
}
