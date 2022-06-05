// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// PRINT 1-255 //

// static void PrintNumbers() 
// {
//     for(int i = 1; i <= 255; i++) {
//         Console.WriteLine(i);
//     }
// }
// PrintNumbers();


// PRINT ODD NUMBERS BETWEEN 1-255 //

// static void PrintOdds()
// {
//     for(int i = 1; i <= 255; i++) {
//         if(i % 2 != 0) {
//             Console.WriteLine(i);
//         }
//     }
// }
// PrintOdds();


// PRINT SUM //

// static void PrintSum()
// {
//     int sum = 0;
//     int newNum = 0;
//     for(int i = 0; i <= 255; i++) {
//         sum += i;
//         newNum = i;
//         Console.WriteLine($"New Number: {newNum} Sum: {sum}");
//     }
// }
// PrintSum();


// ITERATING THROUGH AN ARRAY //

// int[] numbers = {1, 2, 3, 54, 61};
// static void LoopArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++) {
//         Console.Write(numbers[i] + " ");
//     }
// }
// LoopArray(numbers);


// FIND MAX //

// int[] numbers = {15, 11, 45, 9};
// static int FindMax(int[] numbers)
// {
//     int newMax = numbers[0];
//     foreach (int num in numbers) {
//         if(num >= newMax) {
//             newMax = num;
//         }
//     }
//     return newMax;
// }
// int maxVal;
// maxVal = FindMax(numbers);
// Console.WriteLine(maxVal);


// GET AVERAGE //

// int[] numbers = {2, 10, 3};
// static void GetAverage(int[] numbers)
// {
//     int sum = 0;
//     int avg = 0;
//     foreach (int num in numbers) {
//         sum += num;
//     }
//     avg = sum/numbers.Length;
//     Console.WriteLine(avg);
// }
// GetAverage(numbers);


// ARRAY WITH ODD NUMBERS //

// static int[] OddArray()
// {
//     List<int> bucket = new List<int>();
//     for (int i = 1; i <= 256; i++)
//     {
//         if(i % 2 != 0)
//         {
//             bucket.Add(i);
//         }
//     }
//     int[] array = bucket.ToArray();
//     foreach(int value in array)
//     {
//         Console.WriteLine(value);
//     }
//     return array;
// }
// OddArray();


// GREATER THAN Y //

// int[] newNum = {5, 11, 2};
// static int GreaterThanY(int[] numbers, int y)
// {
//     int counter = 0;
//     foreach (int num in numbers)
//     {
//         if(num > y)
//         counter++;
//     }
//     return counter;
// }
// int maxY;
// maxY = GreaterThanY(newNum, 3);
// Console.WriteLine(maxY);


// SQUARE THE VALUES //

// int[] numbers = {3, 6, 10};
// int[] numbers2 = {-4, -7, -2};
// static void SquareArrayValues(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = numbers[i] * numbers[i];
//         Console.Write(numbers[i] +  " ");
//     }
// }
// SquareArrayValues(numbers);
// SquareArrayValues(numbers2);


// ELIMINATE NEGATIVE NUMBERS //

// int[] numbers2 = {4, -3, 8};
// int[] numbers = {-4, -3, -8};
// static void EliminateNegatives(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] < 0)
//         {
//             numbers[i] = 0;
//             Console.Write(numbers[i] + " ");
//         }
            
//         else
//         {
//             numbers[i] = numbers[i];
//             Console.Write(numbers[i] + " ");
//         }
//     }
// }
// EliminateNegatives(numbers);


// MIN MAX AND AVERAGE //

// int[] numbers = {3, 5 , 9, 16, 4, 7};
// int[] numbers2 = {-4, -6, -18, -1, -16};
// static void MinMaxAverage(int[] numbers)
// {
//     int max = numbers[0];
//     int min = numbers[0];
//     int sum = 0;
//     for( int i = 0; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//         if(numbers[i] > max)
//         max = numbers[i];

//         if(numbers[i] < min)
//         min = numbers[i];
//     }

//     int avg = sum / numbers.Length;
//     Console.WriteLine(min + " " + max + " " + avg);
// }
// MinMaxAverage(numbers);
// MinMaxAverage(numbers2);


// SHIFTING THE VALUES IN AN ARRAY //

// int[] numbers = {4, 7, 9, 11, 14, 5, 6, 9};
// static void ShiftValues(int[] numbers)
// {
//     int first = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (i == numbers.Length - 1)
//         {
//             numbers[i] = first;
//         }
//         else
//         {
//             numbers[i] = numbers[i + 1];
//         }
        
//         Console.Write(numbers[i] + " ");
//     }
// }
// ShiftValues(numbers);


// NUMBER TO STRING //

// int[] numbers = {2, 5, -9, 6, 4, -7, -8};
// static object[] NumToString(int[] numbers)
// {
//     object[] objects = new object[numbers.Length];
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] < 0)
//         {
//             objects[i] = "Dojo";
//             Console.Write(objects[i] + " ");
//         }
            
//         else
//         {
//             objects[i] = numbers[i];
//             Console.Write(objects[i] + " ");
//         }
            
//     }
//     return objects;
// }
// NumToString(numbers);