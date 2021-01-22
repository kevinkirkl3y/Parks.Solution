using Microsoft.EntityFrameworkCore;

namespace ParkAPI.Models
{
  public class ParkAPIContext : DbContext
  {
    public ParkAPIContext(DbContextOptions<ParkAPIContext> options)
        : base(options)
        {  
        } 
    public DbSet<StatePark> StateParks { get; set; }
    public DbSet<NationalPark> NationalParks { get; set; }
  }
}