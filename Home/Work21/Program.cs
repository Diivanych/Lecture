/*
Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)       2, 4 -> 16
*/
Console.WriteLine();
Console.Write("Будем возводить число -> ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("В степень -> ");
int exponent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void TaskMethod(int num, int exp)
{
    int res = 1;
    for(int i = 1; i <= exp; i++)     res = res * num;
    Console.WriteLine($"Результат будет ->  {res}");
    Console.WriteLine();
}
TaskMethod(number, exponent);
