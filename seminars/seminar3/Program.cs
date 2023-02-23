// Задание1.  Напишите программу,
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart (double x, double y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 1;
//     if(x < 0 && y < 0) return 1;
//     if(x > 0 && y > 0) return 1;
//     return 0;
// }
// Console.WriteLine("Введите x:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y:");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Номер четверти {FindQuart (x, y)}");

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDistance (double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2)),2);
// }
// Console.WriteLine("Введите координату xa:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату xb:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату ya:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату yb:");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($" Дистанция между координатами -> {FindDistance (xa, xb, ya, yb)}");

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void Diapazon (int cheat)
// {
//     if (cheat > 0 && cheat < 5)
//     {
//         if(cheat == 1) Console.WriteLine("Диапазон координат: x > 0, y > 0");
//         if(cheat == 2) Console.WriteLine("Диапазон координат: x < 0, y > 0");
//         if(cheat == 3) Console.WriteLine("Диапазон координат: x < 0, y < 0");
//         if(cheat == 4) Console.WriteLine("Диапазон координат: x > 0, y < 0");
//     }
//     else
//     {
//         Console.WriteLine(" Такой четверти нет ");
//     }
// }
// Console.WriteLine("Введите четверть");
// int cheat = Convert.ToInt32(Console.ReadLine());
// Diapazon(cheat);

//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void Quad (int x, int y)
// {
//     while (x >= y)
//     {
//         Console.WriteLine($" Корень числа {y} равен {y * y}");
//         y++;
//     }
// }

// Console.WriteLine("Введите число N, чтобы далее увидеть квадраты чисел до этого числа от 1 до N");
// int N = Convert.ToInt32(Console.ReadLine());
// int y = 1;
// Quad (N, y);

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void Palindrom (int Numbers)
// {
//     if (Numbers < 100000)
//     {
//         int dthousand = Numbers / 10000;
//         Console.WriteLine($"Число dthousand = {dthousand}");
//         int thousand = (Numbers / 1000) - (dthousand * 10);
//         Console.WriteLine($"Число thousand = {thousand}");
//         int hundred = (Numbers / 100) - (Numbers / 1000 * 10);
//         Console.WriteLine($"Число hundred = {hundred}");
//         int dec = (Numbers / 10) - (Numbers / 100 * 10);
//         Console.WriteLine($"Число dec = {dec}");
//         int ed = Numbers % 10;
//         Console.WriteLine($"Число ed = {ed}");
//         if (dthousand == ed & thousand == dec)
//         {
//             Console.WriteLine($"Число {Numbers} является Палиндромом");
//         }
//         else
//         {
//             Console.WriteLine($"Число {Numbers} не является Палиндромом");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Число {Numbers} не является Пятизначным");
//     }
    
// }

// Console.WriteLine("Введите пятизначное число, чтобы увидеть является ли оно Палиндромом");
// int Numbers = Convert.ToInt32(Console.ReadLine());
// Palindrom (Numbers);

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance3D (double xa, double xb, double ya, double yb, double za, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2)),2);
// }
// Console.WriteLine("Введите координату xa:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату ya:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату za:");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату xb:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату yb:");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату zb:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($" Дистанция между координатами -> {FindDistance3D (xa, xb, ya, yb, za, zb)}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cub3 (int num)
// {
//         for (int i = 1; i <= num; i++)
//     {
//         Console.Write($"{Math.Pow(i,3)} ");
//     }
// }

// Console.WriteLine("Введите число N, чтобы далее увидеть кубы чисел от 1 до N");
// int N = Convert.ToInt32(Console.ReadLine());
// Cub3 (N);