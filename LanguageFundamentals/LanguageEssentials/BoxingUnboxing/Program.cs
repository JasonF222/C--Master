// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

List<object> newList = new List<object>();
newList.Add(7);
newList.Add(28);
newList.Add(-1);
newList.Add(true);
newList.Add("chair");

int sum = 0;

foreach (object num in newList)
{
    if (num is int)
    {
        Console.WriteLine(num);
        sum += (int)num;    
    }
    else if(num is bool)
    {
        Console.WriteLine(num);
    }
    else if(num is string)
    {
        Console.WriteLine(num);
    }
}
Console.WriteLine(sum);