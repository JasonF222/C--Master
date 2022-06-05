class Deck
{
    public List<Card> cards = new List<Card>();

    public Deck()
    {
        Reset();
        Console.WriteLine(cards.Count);
    }

    public List<Card> Reset()
    {
        cards.Clear();
        string[] suits = {"Hearts", "Clubs", "Diamonds", "Spades"};

        foreach (string suit in suits)
        {
            for(int i = 1; i < 14; i++)
            {
                cards.Add(new Card(suit, i));
                
            }
        }
        return cards;
    }
    
    public Card Deal()
    {
        Card cardDrawn = cards[0];
        cards.RemoveAt(0);
        return cardDrawn;
    }


    public void Shuffle()
    {
        Random rand = new Random();
        List<Card> unshuffled = this.cards;
        List<Card> shuffled = new List<Card>();
        while (unshuffled.Count > 0)
        {
            int i = rand.Next(0, unshuffled.Count);
            shuffled.Add(unshuffled[i]);
            unshuffled.RemoveAt(i);
        }
        this.cards = shuffled;
    }

}