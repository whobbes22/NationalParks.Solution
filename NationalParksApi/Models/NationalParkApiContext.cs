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
          new Park { ParkId = 1, ParkName="Yellowstone", ParkType = "National",ParkLocation="Wyoming", ParkSize ="2.2 million acres", ParkDescription="a Massive park"},
          new Park { ParkId = 2, ParkName="Sequoia and Kings Canyon", ParkType = "National",ParkLocation="California", ParkSize ="1353 square miles", ParkDescription="A lot of really tall trees"},
          new Park { ParkId = 3, ParkName="Valley of Fire", ParkType = "State", ParkLocation="Nevada", ParkSize ="40,000 acres", ParkDescription="Awesome rock formations"},
          new Park { ParkId = 4, ParkName="Blackwater Falls", ParkType = "State", ParkLocation="West Virginia", ParkSize ="2,358 acres", ParkDescription="A good place to Hike with a fantastic waterfall at the end."},
          new Park { ParkId = 5, ParkName="Noah's Ark", ParkType = "Water Park", ParkLocation="Wisconsin", ParkSize ="70 acres", ParkDescription="The biggest water park in the United States!"}
        );
    }
  }
}


