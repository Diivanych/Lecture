/* 
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели и проверяет, 
является ли этот день выходным.
*/

void TestDay(int req)
{
    while((req > 7) || (req <1))
    {
        Console.WriteLine();
        Console.WriteLine("Календарь Майя не обслуживаем!");
        Console.WriteLine("Поробуйте ещё раз.");
        Console.WriteLine();
        req = Convert.ToInt32(Console.ReadLine());
    }
    if(req < 6)
    {
        Console.WriteLine();
        Console.WriteLine("Работайте негры! Солнце ещё высоко.");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Парам-пабабам-пабабам-пабабам");
        Console.WriteLine("Парам-пабабам. По бабам пора!");
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Введите интересующий Вас день недели.");
Console.WriteLine();

int request = Convert.ToInt32(Console.ReadLine());

TestDay(request);