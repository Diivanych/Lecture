/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19           [-4, -6, 89, 6] -> 0
*/

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

int MaxRend()
{
    Console.WriteLine("Введите максимальное число");
    int maxRen = Convert.ToInt32(Console.ReadLine());
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

void SumNotEven(int[] arr)
{
    int sne = 0;
    for(int i=0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sne += arr[i];        
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов массива стоящих");
    Console.WriteLine($"на нечётных местах равна {sne}");
    Console.WriteLine();
}

Console.Clear();

int[] array = CreateArray(LenArr(), MinRend(), MaxRend());

ShowArray(array);

SumNotEven(array);