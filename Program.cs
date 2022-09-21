// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine("первое число больше второго");
// }
// else
// {
//     Console.WriteLine("второе число больше первого");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine());

// int num1 = max;
// if (num1 < num2)
// {
//     num2 = max;
// }
// else (num2 < num3)
//  {
//     num3 = max;
//  }

// Console.WriteLine($"Максимальное число = {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num %2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int i = 1;
// Console.WriteLine("Промежуток четных чисел: ");
// while (i <= num)
// {
//     if (i %2 == 0)
//     {
//         Console.Write($"{i} ");
//     }
//     i++;
// }