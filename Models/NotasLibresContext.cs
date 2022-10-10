using Microsoft.EntityFrameworkCore;

namespace NotasLibres.Models
{
  public class NotasLibresContext : DbContext
  {
    public NotasLibresContext(DbContextOptions<NotasLibresContext> options) : base(options)
    {

    }

    // public DbSet<Nota> Notas {get; set;} = null!;
    public DbSet<Nota> Notas => Set<Nota>();
  }
}