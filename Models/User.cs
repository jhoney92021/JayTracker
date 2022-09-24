using System.ComponentModel.DataAnnotations;

namespace JayTracker.Models;

public class User
{
    [Key]
    public int UserId {get;set;}
    [Required]
    public string Name { get; set; } = "default";
}
