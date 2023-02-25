/*
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11,         82 -> 10,         9012 -> 12
*/

Console.WriteLine();
Console.Write("Введите число для подччёта суммы -> ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void DigitalSum(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр в этом чсле будет равна {sum}");
}
DigitalSum(number);
Console.WriteLine();