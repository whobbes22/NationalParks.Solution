using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(255, ErrorMessage = "length can't exceed 255 characters")]
    public string ParkDescription { get; set; }
  }
}