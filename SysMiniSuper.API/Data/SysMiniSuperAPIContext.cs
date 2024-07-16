using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SysMiniSuper.API.Models;

namespace SysMiniSuper.API.Data
{
    public class SysMiniSuperAPIContext : DbContext
    {
        public SysMiniSuperAPIContext (DbContextOptions<SysMiniSuperAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SysMiniSuper.API.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<SysMiniSuper.API.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<SysMiniSuper.API.Models.Detalle_Venta> Detalle_Venta { get; set; } = default!;
        public DbSet<SysMiniSuper.API.Models.Empleado> Empleado { get; set; } = default!;
        public DbSet<SysMiniSuper.API.Models.Producto> Producto { get; set; } = default!;
        public DbSet<SysMiniSuper.API.Models.Proveedor> Proveedor { get; set; } = default!;
        public DbSet<SysMiniSuper.API.Models.Rol> Rol { get; set; } = default!;
        public DbSet<SysMiniSuper.API.Models.Venta> Venta { get; set; } = default!;
    }
}
