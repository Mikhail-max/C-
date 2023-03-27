////////////////DZ////////////////////
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void Naturals (int n)
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " "  );
//         Naturals(n - 1);
//     } 
// }
// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());
// Naturals(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum (int m, int n)
{
    int summa = 0;
    if (n != m)
    {
        if (m > n)
        {
            return Sum( (m - 1) + (n + 1));
        }
        else
        {
            return Sum( (m + 1) + (n - 1));
        }
    } 
    else
    {
        return Sum (m + n);
    }
}
Console.WriteLine("Input M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(m, n));