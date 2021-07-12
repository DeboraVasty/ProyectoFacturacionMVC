using FacturacionMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturacionMVC.DB
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options): base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacturaProducto>()
            .HasKey(p => new { p.NumeroFactura, p.CodigoProducto });
        }

        public DbSet<Usuario> TablaUsuarios { get; set; }
        public DbSet<Cliente> TablaCliente { get; set; }
        public DbSet<Producto> TablaProducto { get; set; }

        public DbSet<Factura> TablaFactura { get; set; }
        public DbSet<FacturaProducto> TablaFacturaProducto { get; set; }
        public DbSet<ReporteFacturas>ReporteFacturas { get; set; }



    }
}
