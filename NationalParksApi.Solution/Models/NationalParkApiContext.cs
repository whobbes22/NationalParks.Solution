using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
  public class NationalParkContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public NationalParkContext(DbContextOptions<NationalParkContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1}
        );
    }
  }
}


