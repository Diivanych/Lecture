/*
Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Clear();
Console.SetCursorPosition(0,1);

int RowsArray()
{
    Console.WriteLine("Введите количество строк в массиве");
    int rows = Convert.ToInt32(Console.ReadLine());

    while(rows <= 0)
    {
        Console.WriteLine("Количество строк должно быть положительным");
        Console.WriteLine("Введите количество строк в массиве");
        rows = Convert.ToInt32(Console.ReadLine());
    }
    return rows;
}

int ColumnsArray()
{
    Console.WriteLine("Введите количество столбцов в массиве");
    int columns = Convert.ToInt32(Console.ReadLine());

    while(columns <= 0)
    {
        Console.WriteLine("Количество столбцов должно быть положительным");
        Console.WriteLine("Введите количество столбцов в массиве");
        columns = Convert.ToInt32(Console.ReadLine());
    }
    return columns;
}

double MinArray()
{
    Console.WriteLine("Введите минимальное значение массива");
    double min = Convert.ToDouble(Console.ReadLine());
    return min;    
}

double MaxArray()
{
    Console.WriteLine("Введите максимальное значение массива");
    double max = Convert.ToDouble(Console.ReadLine());
    return max;    
}

double[,] Create2DRandomArray(int rows, int columns, double min, double max)
{
    while(min >= max)
    {
        Console.WriteLine("Максмальное число должно быть больше мнимального");
        max = MaxArray();
    }
        
    double[,] newArray = new double[rows, columns];
    var rnd = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            newArray[i,j] = Math.Round(num, 2);
        }
    }
    return newArray;
}

void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SearchElement(double[,] array)
{
    Console.Write("Введите номер строки -> ");
    int i = Convert.ToInt32(Console.ReadLine());

    while(i > array.GetLength(0))
    {
        Console.WriteLine("Такого числа в массиве  нет");
        Console.WriteLine("Искомый элемент должен быть");
        Console.WriteLine($"меньше или равен {array.GetLength(0)}. Повторите ввод");
        i = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Введите номер столбца -> ");
    int j = Convert.ToInt32(Console.ReadLine());

    while(j > array.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
        Console.WriteLine("Искомый элемент должен быть");
        Console.WriteLine($"меньше или равен {array.GetLength(1)}. Повторите ввод");
        j = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    ShowArray(array);

    Console.WriteLine($"Под этим номером находится число {array[(i - 1), (j - 1)]}");

    Console.WriteLine();
}

double[,] rand2DArray = Create2DRandomArray(RowsArray(), ColumnsArray(), MinArray(), MaxArray());
ShowArray(rand2DArray);
SearchElement(rand2DArray);
