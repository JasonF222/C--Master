namespace ProductsNCategories.Models;
using System.ComponentModel.DataAnnotations;

public class CategoryViewModel
{
    public CategoryViewModel(Category category)
    {
        this.CategoryId = category.CategoryId;
        this.CategoryName = category.CategoryName;
        this.CreatedAt = category.CreatedAt;
        this.UpdatedAt = category.UpdatedAt;
        // this.ProdWithCat = category.ProdWithCat;
    }

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // public List<Association> ProdWithCat { get; set; } = new List<Association>();
}

