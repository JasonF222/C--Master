#pragma warning disable CS8618
namespace ChefsNDishes.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Chef
{
    [Key]
    public int ChefId { get; set; }
    [Required(ErrorMessage = "is required.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "is required.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "is required.")]
    [NoFuture]
    [Display(Name = "Date of Birth")]
    public DateTime DOB { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<Dish> CreatedDishes { get; set; } = new List<Dish>();
}

public class Dish
{
    [Key]
    public int DishId { get; set; }
    [Required]
    [Display(Name = "Chef")]
    public int ChefId { get; set; }
    public Chef? Creator { get; set; }
    [Required(ErrorMessage = "is required.")]
    [Display(Name = "Dish Name")]
    public string DishName { get; set; }
    [Required(ErrorMessage = "is required.")]
    [Display(Name = "# of Calories")]
    [Range(1, 99999, ErrorMessage = "must be at least 1 calorie.")]
    public int Calories { get; set; }
    [Required(ErrorMessage = "is required.")]
    [MinLength(1, ErrorMessage = "field must not be blank.")]
    public string Description { get; set; }
    [Required(ErrorMessage = " is required")]
    [Display(Name = "Tastiness")]
    public int Tastiness { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    [NotMapped]
    public List<Chef> AllChefs { get; set; } = new List<Chef>();

}
public class NoFutureAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object value, ValidationContext values)
    {
        DateTime subDate = (DateTime)value;
        int compYear = DateTime.Now.Year - 18;
        DateTime compDate = new DateTime(compYear, DateTime.Now.Month, DateTime.Now.Day);
        if(subDate > compDate)
        {
            return new ValidationResult("Chef must be at least 18 years old.");
        }
        return ValidationResult.Success;
    }
}

