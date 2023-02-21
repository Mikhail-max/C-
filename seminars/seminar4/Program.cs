//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum(int a)
// {
//     int sum = 0;
//     for (int current = 1; current <= a; current++)
//     {
//         sum = sum + current;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число");
// int Number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел от 1 до {Number} равна = {FindSum(Number)}");

//Задача 4. Напишите программу, которая выводит массив из N элементов, заполненный числами от a => b в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray(int size, int minvalue, int maxvalue)
// {
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minvalue, maxvalue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Напишите программу, которая выводит массив из N элементов, заполненный числами диапазоном от a => b в случайном порядке.");
// Console.WriteLine("Введите длину массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент массива");
// int minvalue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент массива");
// int maxvalue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Случайный массив с диапазоном от {minvalue} до {maxvalue} ");
// ShowArray(CreateRandomArray(size, minvalue, maxvalue));


//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// void Kolvo(int Numbers)
// {
//     int current = 0;
//     for (int i = 0; 0 < Numbers; i++)
//     {
//         Numbers = Numbers / 10;
//         current++;
//     }
//     Console.WriteLine($"В числе количество цифр равно {current}");
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Kolvo(num);


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120


// int FindFactorial (int num)
// {
//     int factorial = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         factorial = factorial * i;
//     }
//     return factorial;
// }
// Console.WriteLine("Введите число");
// int cifra = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Факториал числа {cifra} равен {FindFactorial(cifra)}");