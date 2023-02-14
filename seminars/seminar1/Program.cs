// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine($"Quad of {num} is {quad}");
// Задача 2

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if (quad == num1)
// {
//     Console.WriteLine("First number is quad of second number");

// }
// else 
// {
//     Console.WriteLine("First number is not quad of second number");

// }





// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);
// while(current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }




// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);
// while(current <= num)
// {
//      Console.Write(num + " ");
//      num--;
//  }

// //1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

//    // 456 -> 6

//     // 782 -> 2

//     // 918 -> 8

// Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num % 10;

// Console.WriteLine($"Last digit of {num} is {result}");

// Задача 2: Напишите программу,
// которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
//     if (num1 > num2)
//     {
//         int Maximum = num1;
//         int Minimum = num2;
//         Console.WriteLine($"Maximum number {Maximum}");
//         Console.WriteLine($"Minimum number {Minimum}");
//     }
//     else
//     {
//         int Maximum = num2;
//         int Minimum = num1;
//         Console.WriteLine($"Maximum number {Maximum}");
//         Console.WriteLine($"Minimum number {Minimum}");
//     }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input three number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int Maximum = num1;
// if (num2 > Maximum)
// {
//     Maximum = num2;
// }
// if (num3 > Maximum)
// {
//     Maximum = num3;
// }
// Console.WriteLine($"Maximum number {Maximum}");

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num % 2;
// if (result == 0)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Odd");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Input number");
// int N = Convert.ToInt32(Console.ReadLine());
// int current = 1;

// while (current <=  N)
// {
//     int result = current % 2;
//     if (result == 0)
//     {
//         Console.Write(current + " ");
//     }
//     current++;
// }