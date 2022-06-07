class SweetTooth : Ninja
{
    public SweetTooth()
    {

    }

    public override bool IsFull
    {
        get
        {
            return calorieIntake > 1500;
        }
    }

    public override void Consume(IConsumable item)
    {
        
        if(IsFull == false)
        {
            calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);
            if(item.IsSweet == true)
            {
                calorieIntake += 10;
            }
        Console.WriteLine($"SweetTooth had {item.GetInfo()}");
        }
        if(IsFull)
        {
            Console.WriteLine($"SweetTooth is too full... SweetTooth cannot eat another bite!!!");
        }
    }
}