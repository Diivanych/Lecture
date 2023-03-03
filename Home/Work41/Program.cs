/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2          1, -7, 567, 89, 223-> 3
*/

double[] CreateArray(int len, double min, double max)
{
    while(min >= max) 
    {
        Console.WriteLine("Число должно больше минимального числа");
        max = MaxRend();
    }
    double[] arr = new double[len];
    var rnd = new Random();
    for(int i = 0; i < len; i ++)
    {
        double num = rnd.NextDouble() * (max - min) + min; 
        arr[i] = Math.Round(num, 2);
    }
    return arr;
}

void ShowArray(double[] arr)
{
    Console.WriteLine();
    for(int i=0; i < arr.Length; i++) Console.Write($"{Math.Round(arr[i], 2)}   ");        
    Console.WriteLine();
}

int LenArr()
{
    Console.SetCursorPosition(32, 0);
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    while(size < 1)
    {
        Console.WriteLine("Размер массива должен быть больше 0");
        Console.WriteLine("Повторите ввод");
        size = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}

double MinRend()
{
    Console.WriteLine("Введите минимальное число");
    double minRen = Convert.ToDouble(Console.ReadLine());
    return minRen;
}

double MaxRend()
{
    Console.WriteLine("Введите максимальное число");
    double maxRen = Convert.ToDouble(Console.ReadLine());
    return maxRen;
}

void PositivNumberCount(double[] arr)
{
    int counter = 0;

    for(int i=0; i < arr.Length; i++) if(arr[i] > 0) counter++;
    Console.WriteLine();
    Console.WriteLine($"Всего в массиве {counter} положительных чисел");
    Console.WriteLine();
}

Console.Clear();

double[] array = CreateArray(LenArr(), MinRend(), MaxRend());

ShowArray(array);

PositivNumberCount(array);

//Console.SetCursorPosition(0, 32);