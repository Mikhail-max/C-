//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[,] Create2DRandomArray (int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int[,] Create2DRandomArray (int columns, int rows)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = i + j;
//         }
//     }
//     return newArray;
// }


// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Show2dArray(Create2DRandomArray(columns, rows));


//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

// int[,] Create2DRandomArray (int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] kvadro (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
//             }
//         }
//     }
//     return array;
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);
// Show2dArray(kvadro(myArray));

//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2                      Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] Create2DRandomArray (int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void Sum (int[,] array)
// {
//     int summa = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 summa = summa + array[i,j];
//             }
//         }
//     }
//     Console.WriteLine($"Сумма элементов по диагонали равна {summa}");
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);
// Sum(myArray);


// int[,] Create2DRandomArray (int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue); // newArray[i, j] = new Random().Next(minValue, maxValue + Random.Double(0, 1))
//         }
//     }
//     return newArray;
// }
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void Sum (int[,] array)
// {
//     int summa = 0;
//     for (int i = 0, j = 0; i < array.GetLength(0); i++, j++)
//     {
//         summa = summa + array[i,j];
//     }
//     Console.WriteLine($"Сумма элементов по диагонали равна {summa}");
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);
// Sum(myArray);

/////////////////////////////////////////////////DZ///////////////////////////////////////////////////

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] Create2DRandomArray (int columns, int rows, int minValue, int maxValue)
// {
//     double[,] newArray = new double[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = rand.Next(minValue, maxValue + 1) + Math.Round(rand.NextDouble(), 1);
//         }
//     }
//     return newArray;
// }
// void Show2dArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray (int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue); // newArray[i, j] = new Random().Next(minValue, maxValue + Random.Double(0, 1))
//         }
//     }
//     return newArray;
// }
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void Number(int[,] array, int number)
// {
//     int rowsnumber = 0;
//     int columnnumber = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            if (number == array[i, j])
//            {
//             rowsnumber = i;
//             columnnumber = j;
//            }
//         }
//     }
//     if (array[rowsnumber, columnnumber] == number)
//     {
//         Console.Write($"Число {number} имеет значения в массиве {rowsnumber},{columnnumber} ");
//     }
//     else
//     {
//         Console.Write($"{number} => такого числа нет ");
//     }
    
        
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);
// Number(myArray, number);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] Create2DRandomArray (int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;
// }
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void Arithmetic (int[,] array)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//           sum = sum + array[i,j];
//         }
//         Console.WriteLine($"Среднее арифмитическое в стобце {j} равно {sum / array.GetLength(1)}");
//         sum = 0;
//     }
    
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);
// Arithmetic(myArray);
