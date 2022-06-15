namespace ProductsNCategories.Models;
using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "is required.")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
    [MaxLength(40, ErrorMessage = "must be less than 40 characters.")]
    [Display(Name = "Name:")]
    public string ProductName { get; set; }

    [Required(ErrorMessage = "is required.")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    [Display(Name = "Description:")]
    public string ProductDescription { get; set; }
    [Required(ErrorMessage = "is required.")]
    [Display(Name = "Price:")]
    public decimal ProductPrice { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Association> CatWithProd { get; set; } = new List<Association>();
}