/*                 Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2               */

int[] CreateArray(int len, int min, int max)
{
    while(min >= max) 
    {
        Console.WriteLine("Число должно больше минимального числа");
        max = MaxRend();
    }
    int[] arr = new int[len];
    for(int i = 0; i < len; i ++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}

void ShowArray(int[] arr)
{
    Console.WriteLine();
    for(int i=0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");        
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

int MinRend()
{
    Console.WriteLine("Введите минимальное число");
    int minRen = Convert.ToInt32(Console.ReadLine());
    while(minRen < 0)
    {
        Console.WriteLine("По условию число должно быть больше 0");
        Console.WriteLine("Повторите ввод");
        minRen = Convert.ToInt32(Console.ReadLine());
    }
    return minRen;
}

int MaxRend()
{
    Console.WriteLine("Введите максимальное число");
    int maxRen = Convert.ToInt32(Console.ReadLine());
    while(maxRen < 0)
    {
        Console.WriteLine("По условию число должно быть больше 0");
        Console.WriteLine("Повторите ввод");
        maxRen = Convert.ToInt32(Console.ReadLine()) + 1;
    }
    return maxRen;
}

void NumbEven(int[] arr)
{
    int numEven = 0;
    for(int i=0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) numEven++;        
    }
    Console.WriteLine($"В массиве всего {numEven} чётных членов");
    Console.WriteLine();
}

Console.Clear();

int[] array = CreateArray(LenArr(), MinRend(), MaxRend());

ShowArray(array);

NumbEven(array);