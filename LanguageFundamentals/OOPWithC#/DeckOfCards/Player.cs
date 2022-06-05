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
        return drawCard;
    }

    public Card Discard(int i)
    {
        Card newCard;
        if(i < hand.Count)
        {
            newCard = hand[i];
            hand.RemoveAt(i);
            return newCard;
        }
        else {return null!;}
    }


}