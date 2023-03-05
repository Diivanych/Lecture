/*
Задача 47. Задайте двумерный массив размером 
m×n, заполненный случайными вещественными 
числами.

m = 3, n = 4.

0,5  7,0 -2,0 -0,2
1   -3,3  8,0 -9,9
8    7,8 -7,1  9,0
*/

Console.Clear();
Console.SetCursorPosition(0,3);

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
    Console.WriteLine("Введите минимальное значение массива");
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

double[,] rand2DArray = Create2DRandomArray(RowsArray(), ColumnsArray(), MinArray(), MaxArray());
ShowArray(rand2DArray);

