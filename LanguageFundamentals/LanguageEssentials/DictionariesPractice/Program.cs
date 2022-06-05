// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// DICTIONARIES PRACTICE //


Dictionary<string,string> profile = new Dictionary<string,string>();
// Almost ALL the methods that exist with Lists are the SAME with Dictionaries //
profile.Add("Name", "Speros");
profile.Add("Language", "PHP");
profile.Add("Location", "Greece");
Console.WriteLine("Instructor Profile");
Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile["Language"]);

// Iterating thru Dictionaries with FOREACH loops is slightly different //
// Because we are using key-value pairs instead of incremented indicies and values //
foreach (KeyValuePair<string,string> entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}

// The VAR keyword takes the place of a TYPE in type-inference //
foreach (var entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}