class Player
{
    private string name;
    private List<Card> hand;
    
    public Player(string name)
    {
        this.name = name;
        hand = new List<Card>();
    }

    public string Name
    {
        get{return name;}
    }

    public Card Draw(Deck draw)
    {
        Card drawCard = draw.Deal();
        hand.Add(drawCard);
        Console.WriteLine(hand.Count);
        return drawCard;
    }

    public Card Discard(int i)
    {
        Card newCard;
        if(i < hand.Count)
        {
            newCard = hand[i];
            hand.RemoveAt(i);
            Console.WriteLine(hand.Count);
            return newCard;
        }
        else {return null!;}
    }

    public List<Card> ShowHand()
    {
        foreach(Card card in hand)
        {
            Console.Write(card.Name + " of " + card.Suit + " || ");
        }
        return hand;
    }
}