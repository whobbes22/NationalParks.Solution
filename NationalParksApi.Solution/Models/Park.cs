using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(255, ErrorMessage = "length can't exceed 255 characters")]
    public string ParkDescription { get; set; }
    public string ReviewCountry { get; set; }
    [Required]
    public string ReviewUserName {get;set;}
    [Range(0,10, ErrorMessage ="Rating should be between 0 and 10")]
    public int ReviewRating { get; set; }
  }
}