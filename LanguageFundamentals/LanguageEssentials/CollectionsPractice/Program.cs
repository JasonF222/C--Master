// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// THREE BASIC ARRAYS //

int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};

bool[] boolArray = new bool[10];
boolArray[0] = true;
boolArray[1] = false;
boolArray[2] = true;
boolArray[3] = false;
boolArray[4] = true;
boolArray[5] = false;
boolArray[6] = true;
boolArray[7] = false;
boolArray[8] = true;
boolArray[9] = false;

// LIST OF FLAVORS //

List<string> flavors = new List<string>();
flavors.Add("Chocolate");
flavors.Add("Vanilla");
flavors.Add("Strawberry");
flavors.Add("Rocky Road");
flavors.Add("Chocolate Chip Cookie Dough");
flavors.Add("Mint Chocolate Chip");
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.Remove("Strawberry");
Console.WriteLine(flavors.Count);

List<string> moreFlavors = new List<string>();
moreFlavors.Add("Lemon");
moreFlavors.Add("Neopolitan");
moreFlavors.Add("Sherbet");
moreFlavors.Add("Cherry Garcia");

flavors.AddRange(moreFlavors);
Console.WriteLine(flavors.Count);

// USER INFO DICTIONARY //

Dictionary<string,string> user = new Dictionary<string,string>();
user.Add("Tim", "Rocky Road");
user.Add("Martin", "Chocolate Chip Cookie Dough");
user.Add("Nikki", "Mint Chocolate Chip");
user.Add("Sara", "Vanilla");
foreach (var entry in user)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}
