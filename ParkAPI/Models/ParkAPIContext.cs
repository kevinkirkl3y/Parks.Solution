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
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<NationalPark>()
      .HasData(
        new NationalPark { NationalParkId = 1, Name = "Grand Canyon National Park", State = "Arizona", Address = "PO Box 129 Grand Canyon, AZ 86023", Website = "https://www.nps.gov/grca/index.htm", TotalArea = "1902 mi²"},
        new NationalPark { NationalParkId = 2, Name = "Death Valley National Park", State = "California", Address = "P.O. Box 579 Death Valley, CA 92328", Website = "https://www.nps.gov/deva/index.htm", TotalArea = "5,270 mi²"},
        new NationalPark { NationalParkId = 3, Name = "Yosemite National Park", State = "California", Address = "PO Box 577 Yosemite, CA 95389", Website = "https://www.nps.gov/yose/index.htm", TotalArea = "1,169 mi²"},
        new NationalPark { NationalParkId = 4, Name = "Crater Lake National Park", State = "Oregon", Address = "PO Box 7 Crater Lake , OR 97604", Website = "https://www.nps.gov/crla/index.htm", TotalArea = "20.6 mi²"},
        new NationalPark { NationalParkId = 5, Name = "Capitol Reef National Park", State = "Utah", Address = "HC 70, PO Box15 Torrey, UT 84775", Website = "https://www.nps.gov/care/index.htm", TotalArea = "378 mi²"}
      );
      builder.Entity<StatePark>()
      .HasData(
        new StatePark { StateParkId = 1, Name = "Lost Dutchman State Park", State = "Arizona", Address = "6109 N. Apache Trail Apache Junction, AZ 85119", Website = "https://azstateparks.com/lost-dutchman/", TotalArea = ".5 mi²"},
        new StatePark { StateParkId = 2, Name = "Dead Horse Point State Park", State = "Utah", Address = "UT-313, Moab, UT 84532", Website = "https://stateparks.utah.gov/parks/dead-horse/", TotalArea = "8.4 mi²"},
        new StatePark { StateParkId = 3, Name = "Smith Rock State Park", State = "Oregon", Address = " 44°21'58.01N, 121° 8'13.32W or 44.367612, -121.138988", Website = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=36", TotalArea = "1.1 mi²"},
        new StatePark { StateParkId = 4, Name = "Emerald Bay State Park", State = "California", Address = "138 Emerald Bay Rd, South Lake Tahoe, CA 96150", Website = "https://www.parks.ca.gov/?page_id=506", TotalArea = "2.4 mi²"},
        new StatePark { StateParkId = 5, Name = "Red Rock State Park", State = "Arizona", Address = "4050 Red Rock Loop Rd Sedona, AZ 86336", Website = "https://azstateparks.com/red-rock/", TotalArea = ".45 mi²"}
      );
    }  
  }
}