class Card
{
    public string Name;
    public string Suit;
    public int Value;

    public Card(string suit, int val)
    {
        Suit = suit;
        Value = val;
        switch(val)
        {

            case 11:
            Name = "Jack";
            break;

            case 12:
            Name = "Queen";
            break;

            case 13:
            Name = "King";
            break;

            case 1:
            Name = "Ace";
            break;

            default:
            Name = val.ToString();
            break;

        }
    }

    public void Print()
    {
        Console.WriteLine($"{Name} of {Suit} value: {Value}");
    }



}