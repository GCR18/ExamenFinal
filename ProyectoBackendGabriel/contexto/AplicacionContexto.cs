using Microsoft.EntityFrameworkCore;
using ProyectoBackendGabriel.modelos;

namespace ProyectoBackendGabriel.contexto;
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Almacenes> Almacenes { get; set; }
        public DbSet<Capitanes> Capitanes { get; set; }
    }
}
