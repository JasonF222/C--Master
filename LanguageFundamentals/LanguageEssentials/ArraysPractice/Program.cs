// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// ARRAYS PRACTICE //


// Declaring an ARRAY of length 5, initialized by default to all zeroes //
int[] numArray = new int[5];

// Declaring an ARRAY with pre-populated values //
// For ARRAYS initialized this way, the length is determined by the size of the given data //
int[] numArray2 = {1, 2, 3, 4, 6};

// Declaring an ARRAY without initialization using the 'NEW' operator //
int[] array3;
array3 = new int[] {1, 2, 3, 5, 7, 9};


// ACCESSING ARRAYS //


// ARRAYS are zero indexed //
int[] arrayOfInts = {1, 2, 3, 4, 5};
Console.WriteLine(arrayOfInts[0]);
Console.WriteLine(arrayOfInts[1]);
Console.WriteLine(arrayOfInts[2]);
Console.WriteLine(arrayOfInts[3]);
Console.WriteLine(arrayOfInts[4]);

// We can redefine the value at a particular index (ONCE ARRAY HAS AN INITAL SET OF VALUES) //
int[] arr = {1, 2, 3, 4};
Console.WriteLine($"The first number of the ARRAY is {arr[0]}");
arr[0] = 8;
Console.WriteLine($"The first number of the ARRAY is NOW {arr[0]}");


// ITERATING THROUGH AN ARRAY //

// Looping through an ARRAY //
string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300ZX"};
// The 'Length' property tells us how many values are in the ARRAY (4 in our example) //
// We can use this to determine where the loop ends: Length - 1 is the index of the LAST value //
for (int idx = 0; idx < myCars.Length; idx++)
{
    Console.WriteLine($"I own a {myCars[idx]}");
}

// FOR EACH Loop //
// string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300ZX"};
// foreach (string car in myCars)
// {
//     We no longer need the index, because the variable 'car' already represents each indexed value //
//     Console.WriteLine($"I own{car}");
// }