Buffet buffet = new Buffet();

SweetTooth cavity = new SweetTooth();

SpiceHound spicy = new SpiceHound();


while(!cavity.IsFull)
    cavity.Consume(buffet.Serve());

while(!spicy.IsFull)
    spicy.Consume(buffet.Serve());

Ninja champion;
string title;
if(cavity.ConsumptionHistory.Count > spicy.ConsumptionHistory.Count)
{
    champion = cavity;
    title = "SweetTooth";
}
else
{
    champion = spicy;
    title = "SpiceHound";
}
Console.WriteLine($"{title} is the winner with a whopping {champion.ConsumptionHistory.Count} entrees and drinks consumed! ");