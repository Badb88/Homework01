/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (a > b) max = a;
if (a < b) max = b;
if (a < b) min = a;
if (a > b) min = b;
Console.Write("Максимальное число: ");
Console.WriteLine(max);
Console.Write("Минимальное число: ");
Console.WriteLine(min);