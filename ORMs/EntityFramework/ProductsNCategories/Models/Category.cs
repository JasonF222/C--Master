namespace ProductsNCategories.Models;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "is required.")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
    [MaxLength(40, ErrorMessage = "must be less than 40 characters.")]
    [Display(Name = "Name:")]
    public string CategoryName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Association> ProdWithCat { get; set; } = new List<Association>();
}