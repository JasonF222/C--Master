namespace ChefsNDishes.Models;
using System.ComponentModel.DataAnnotations;

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
    public Chef Creator { get; set; }
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
}