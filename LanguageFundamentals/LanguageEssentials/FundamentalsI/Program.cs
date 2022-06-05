// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Loop that prints all values from 1-255 //

// for (int i = 1; i <= 255; i++)
// {
//     Console.WriteLine(i);
// }

// Loop that prints all values from 1-100 //
// Divisible by 3 OR 5, not both //

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 || i % 5 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// Modified Loop to print 'FIZZ' on % 3 //
// Print 'BUZZ' on % 5 //
// Print 'FIZZBUZZ' on % 3 AND % 5 //

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FIZZBUZZ");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("FIZZ");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("BUZZ");
    }
    
    else if (i % 3 != 0 || i % 5 != 0 )
    {
        Console.WriteLine(i);
    }
}
