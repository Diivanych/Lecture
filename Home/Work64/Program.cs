/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента. 
Массив размером 2 x 2 x 2 

66(0,0,0) 25(0,1,0) 
34(1,0,0) 41(1,1,0) 

27(0,0,1) 90(0,1,1) 
26(1,0,1) 55(1,1,1) 
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

int DeepArray()
{
    Console.WriteLine("Введите количество слоёв в массиве");
    int deep = Convert.ToInt32(Console.ReadLine());

    while(deep <= 0)
    {
        Console.WriteLine("Количество слоёв должно быть положительным");
        Console.WriteLine("Введите количество слоёв в массиве");
        deep = Convert.ToInt32(Console.ReadLine());
    }
    return deep;
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

double[,,] Create2DRandomArray(int rows, int columns, int deep, double min, double max)
{
    double[,,] newArray = new double[rows, columns, deep];
//    var rnd = new Random();
    int temp = 10;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < deep; k++)
            {
//                double num = rnd.NextDouble() * (max - min) + min;
//                newArray[i,j,k] = Math.Round(num, 0);
                newArray[i,j,k] = temp++;
            }
        }
    }
    return newArray;
}

void ShowArray(double[,,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,,] rand2DArray = Create2DRandomArray(RowsArray(), ColumnsArray(), DeepArray(), MinArray(), MaxArray());
ShowArray(rand2DArray);