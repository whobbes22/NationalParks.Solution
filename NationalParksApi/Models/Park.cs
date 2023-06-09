using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(255, ErrorMessage = "length can't exceed 255 characters")]
    public string ParkName {get;set;}
    [Required]
    public string ParkType {get;set;}
    public string ParkLocation {get;set;}
    public string ParkSize {get;set;}
   
    public string ParkDescription { get; set; }
  }
}