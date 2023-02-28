/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
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
    for(int i=0; i < arr.Length; i++)
    {
        // Console.Write($"{arr[i]} ");
        Console.Write($"{Math.Round(arr[i], 2)}   ");        
    }
    Console.WriteLine();
}

int LenArr()
{
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
   /*
    while(minRen < 0)
    {
        Console.WriteLine("По условию число должно быть больше 0");
        Console.WriteLine("Повторите ввод");
        minRen = Convert.ToInt32(Console.ReadLine());
    }
    */
    return minRen;
}

double MaxRend()
{
    Console.WriteLine("Введите максимальное число");
    double maxRen = Convert.ToDouble(Console.ReadLine());
    /*
    while(maxRen < 0)
    {
        Console.WriteLine("По условию число должно быть больше 0");
        Console.WriteLine("Повторите ввод");
        maxRen = Convert.ToInt32(Console.ReadLine()) + 1;
    }
    */
    return maxRen;
}

void MinMaxNumb(double[] arr)
{
    double minNum = arr[0];
    double maxNum = arr[0];

    for(int i=1; i < arr.Length; i++)
    {
        if(minNum > arr[i]) minNum = arr[i];
        if(maxNum < arr[i]) maxNum = arr[i];               
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальный член массива -> {minNum}");
    Console.WriteLine($"Максимальный член массива -> {maxNum}");
    Console.WriteLine($"Разница Max и Min членов -> {maxNum - minNum}");
    Console.WriteLine();
}

Console.Clear();

double[] array = CreateArray(LenArr(), MinRend(), MaxRend());

ShowArray(array);

MinMaxNumb(array);