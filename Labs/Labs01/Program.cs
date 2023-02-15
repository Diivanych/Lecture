// Напишите программу, которая выводит случайное число из отрезка
// [10, 99] и показывает наибольшую цифру чсла.

// 78 -> 8    12 -> 2    85 -> 8

void MaxDecimal(int num)
{
    int edc = num % 10;
    int dec = num / 10;
    if(edc > dec)
    {
        Console.WriteLine($"Большая цифра числа {num} -> {edc}");
    }
    else
    {
        Console.WriteLine($"Большая цифра числа {num} -> {dec}");
    }
}

int randomnumber = new Random().Next(10, 100);
MaxDecimal(randomnumber);
