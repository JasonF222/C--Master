class SpiceHound : Ninja
{
    public SpiceHound()
    {

    }

    public override bool IsFull
    {
        get
        {
            return calorieIntake > 1200;
        }
    }

    public override void Consume(IConsumable item)
    {
        
        if(IsFull == false)
        {
            calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);
            if(item.IsSpicy == true)
            {
                calorieIntake -= 5;
            }
        Console.WriteLine($"SpiceHound had {item.GetInfo()}");
        }
        if(IsFull)
        {
            Console.WriteLine($"SpiceHound is too full... SpiceHound cannot eat another bite!!!");
        }
    }
}