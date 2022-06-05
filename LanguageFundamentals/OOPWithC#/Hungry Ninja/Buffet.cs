class Buffet
{
    public List<Food> Menu;

    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Taco", 400, false, false),
            new Food("Pho", 300, true, false),
            new Food("Ice Cream Sundae", 900, false, true),
            new Food("Steak", 400, false, false),
            new Food("Orange Chicken", 500, true, true),
            new Food("Lasagna", 1000, false, false),
            new Food("Monte Cristo", 500, false, true),
            new Food("Burrito", 700, true, false),
            new Food("Mac n Cheese", 100, false, false),
            new Food("Rotisserie Chicken", 200, false, false)
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        Food entree = Menu[rand.Next(Menu.Count())];
        return entree;
    }
}