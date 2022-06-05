class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    bool IsFull
    {
        get
        {
            return calorieIntake > 1000;
        }
    }



    public void Eat(Food item)
    {
        if (IsFull == false)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"Ninja ate {item.Name}");
            if(item.IsSpicy)
            {
                Console.WriteLine($"Now {item.Name} is a SPICY dish!");
            }
            if(item.IsSweet)
            {
                Console.WriteLine($"DROOL {item.Name} is so sweet!");
            }
        }
        else if(IsFull == true)
        {
            Console.WriteLine("Ninja can't eat another bite... Ninja is too full!");
        }
    }
}