using System.ComponentModel.DataAnnotations;
namespace ParkAPI.Models
{
  public class StatePark
  {
    public int StateParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string Website { get; set; }
    [Required]
    public string TotalArea { get; set; }
  }
}