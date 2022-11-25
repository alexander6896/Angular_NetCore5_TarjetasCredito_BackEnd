using FBTarjetas.Models;
using Microsoft.EntityFrameworkCore;

namespace FBTarjetas
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }
    }
}
