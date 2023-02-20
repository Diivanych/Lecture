/*
Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine();
Console.WriteLine("Введите натуральное чсло N");
Console.Write("-> ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Таблица кубов для числа N = {n} будет следующей:");
Console.WriteLine();
for(int i = 1; i <= n; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine();
Console.WriteLine();