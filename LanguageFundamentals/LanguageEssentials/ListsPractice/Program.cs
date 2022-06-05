// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// LISTS Practice //


// INSTANTIATING and ADDING to a List //

// Initializing an empty list of Motorcycle Manufacturers //
List<string> bikes = new List<string>();
// Use the ADD function in a similar fashion to PUSH //
bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");
// Accessing a GENERIC LIST value is the same as you would in an ARRAY //
Console.WriteLine(bikes[2]);
Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers");

// ITERATING THROUGH A LIST //

// Using the ARRAY from above //
// We can loop through the list of them with a FOR loop //
// This time, COUNT is the attribute for a NUMBER of items //
Console.WriteLine("The current manufacturers we have seen are:");
for (var idx = 0; idx < bikes.Count; idx++)
{
    Console.WriteLine("-" + bikes[idx]);
}
// INSERTING a new item between a specific index //
bikes.Insert(2, "Yamaha");
// REMOVAL from GENERIC LIST //
// Remove is a lot like Javascript POP, but searches for a SPECIFIED value //
// In this case we are removing all manufacturers located in Japan //
bikes.Remove("Suzuki");
bikes.Remove("Yamaha");
bikes.RemoveAt(0); // RemoveAt has no return value //
// The updated list can then be iterated through using a FOREACH loop //
Console.WriteLine("List of Non-Japanese Manufacturers:");
foreach (string manu in bikes)
{
    Console.WriteLine("-" + manu);
}