namespace ChefsNDishes.Models;
using System.ComponentModel.DataAnnotations;

public class ChefDishList
{
    public Dish dish { get; set; }
    public List<Chef> chefList { get; set; }
    
}