using System.ComponentModel.DataAnnotations;

namespace Studentwebapi.Models
{
  public class Students
  {
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailId { get; set; }
    public string NewPassword { get; set; }
    public string ConfirmPassword { get; set; }
  }
}
