namespace LoginRegistration.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int UserId { get; set; }
    [Required(ErrorMessage = "is required.")]
    [MinLength(2, ErrorMessage ="must be at least 2 characters.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "is required.")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "is required.")]
    [EmailAddress(ErrorMessage = "must provide a valid email address.")]
    [Display(Name = "Email Address")]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "is required.")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters or longer!")]
    [Display(Name = "Password")]

    public string Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string Confirm { get; set; }
    
}

public class LoginUser
{
    [Required]
    [Display(Name = "Email")]
    public string LogEmail { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LogPassword { get; set; }
}