//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

//РЕАЛИЗУЕМ МЕТОД ПОИНТЕРЕСНЕЕ ОН БУДЕТ МЕНЯТЬ ЛЮБУЮ С ЛЮБОЙ СТРОКИ

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

// int[,] ChangeRows (int[,] array, int row1, int row2)
// {
//     if (row1 > array.GetLength(0,1) || row2 > array.GetLength(0,1) || row1 < 0 || row2 < 0)
//     {
//         Cosole.WriteLine("invalid rows/s");
//         return array;
//     }
//     else
//     {
//         for (int j = 0; i < array.GetLength(1); i++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
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
// Console.WriteLine("Input number of first row to change");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of second row to change");
// int row2 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2dArray(myArray);
// Show2dArray(ChangeRows(myArray));

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

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
// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Row and column count mismatch");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
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
// Show2dArray(RowsToColumns(myArray));


//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

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

// int[,] DeleteRowsColomns (int[,] array)
// {
//     int min = array[0,0];
//     int rowmin = 0;
//     int columnmin = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j] < min)
//             {
//                 min = array[i,j];
//                 rowmin = i;
//                 columnmin = j;
//             }
//         }
//     }
//     //обнуление
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i,columnmin] = 0;
//     }
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[rowmin, j] = 0;
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
// Show2dArray(DeleteRowsColomns(myArray));


//////////////////ДЗ//////////////////////
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
// void BubbleSort(int[] array)
// {
//     int temp;
//     for (int i = 0; i < array.Length; i++)
//     {
//          for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[i] < array[j])
//              {
//                 temp = array[i];
//                 array[i] = array[j];
//                 array[j] = temp;
//               }                   
//          }            
//      }
// }

    
    

// void Insert(bool isRow, int i, int[] row, int[,] array)
//         {
//             for (int k = 0; k < row.Length; k++)
//             {
//                 if (isRow)
//                     array[i, k] = row[k];
//                 else
//                     array[k, i] = row[k];
//             }
//         }
// void Arrange (int[,] array)
// {
//     int[] row = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             row[j] = array[i, j];
//         }
//         BubbleSort(row);
//         Insert(true, i, row, array);
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
// Arrange(myArray);
// Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
// void Minsumrow (int[,] array)
// {
//     int sum = 0;
//     int minsum = 0;
//     int minindexsum = 0;
//     if (array.GetLength(0) == array.GetLength(1)) Console.WriteLine("Строки не должны равняться колонкам");
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum += array[i, j];
//             }
//             if (i > 0)
//             {
//                 if (minsum > sum)
//                 {
//                     minsum = sum;
//                     minindexsum = i;
//                 }
//             }
//             else
//             {
//                 minsum = sum;
//                 minindexsum = i;
//             }
//             sum = 0;
//         }
//         Console.WriteLine($"Строка {minindexsum + 1} имеет наименьшую сумму") ;
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
// Minsumrow(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// int [,] MatrixProduct(int [,] matrixA, int [,] matrixB)
// {
//   int aRows = matrixA.GetLength(0); int aCols = matrixA.GetLength(1);
//   int bRows = matrixB.GetLength(0); int bCols = matrixB.GetLength(1);
//   if (aCols != bRows)
//     throw new Exception("Non-conformable matrices in MatrixProduct");
//   int [,] resultMatrix = new int[aRows, bCols];
//   for (int i = 0; i < aRows; ++i) // каждая строка A
//     for (int j = 0; j < bCols; ++j) // каждый столбец B
//       for (int k = 0; k < aCols; ++k)
//         resultMatrix[i,j] += matrixA[i,k] * matrixB[k,j];
//   return resultMatrix;
// }
// Console.WriteLine("Input aRows");
// int aRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input aColumns");
// int aColumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input bRows");
// int bRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input bColumns");
// int bColumns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] aMatrix = Create2DRandomArray (aColumns, aRows, minValue, maxValue);
// int[,] bMatrix = Create2DRandomArray (bColumns, bRows, minValue, maxValue);
// int[,] Matrix = MatrixProduct(aMatrix, bMatrix);
// Show2dArray(aMatrix);
// Show2dArray(bMatrix);
// Show2dArray(Matrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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
// static int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
// {
//     int[,,] matrix = new int[row, col, dep];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++) { matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k); }
//         }
//     }
//     return matrix;
// }
// static int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
// {
//     int value = default;
//     bool exist = true;
//     while (exist)
//     {
//         bool _break = false;
//         value = new Random().Next(min, max + 1);
//         for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
//         {
//             if (_break) { break; }
//             for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
//             {
//                 if (_break) { break; }
//                 for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
//                 {
//                     if (matrix[i1, j1, k1] == value) { _break = true; break; }
//                     if (i1 == i && j1 == j && k1 == k) { exist = false; }
//                 }
//             }
//         }
//     }
//     return value;
// }
// static void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("|");
//             for (int k = 0; k < matrix.GetLength(2); k++) { Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); }
//             Console.WriteLine();
//         }
//     }
// }
// Console.WriteLine("Input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input dep");
// int dep = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,,] array3D = CreateMatrix (rows, columns, dep, minValue, maxValue);
// PrintMatrix(array3D);
    

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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
// int[,] Spiral(int [,] array)
// {
    
// }
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Numbers");
// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int[,] myArray = new int[rows,columns];
// Spiral(myArray);
// Show2dArray(myArray);