/*
Задача 54: 
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива. 

Например, задан массив: 

1 4 7 2 
5 9 2 3 
8 4 2 4 

В итоге получается вот такой массив: 

7 4 2 1 
9 5 3 2 
8 4 4 2 

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
            newArray[i,j] = Math.Round(num, 0);
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

double[,] SortRowArray(double[,] sortArray)
{
    for(int i = 0; i < sortArray.GetLength(0); i++)
    {
        for(int j = 0; j < sortArray.GetLength(1); j++)
        {
            for(int k = 0; k < sortArray.GetLength(1) - 1; k++)
            {
                if(sortArray[i, k] < sortArray[i, k+1])
                {
                    double tempMin = sortArray[i, k];
                    sortArray[i, k] = sortArray[i, k + 1];
                    sortArray[i, k + 1] = tempMin;
                }
            }
        }
    }
    return sortArray;
}



double[,] rand2DArray = Create2DRandomArray(RowsArray(), ColumnsArray(), MinArray(), MaxArray());
ShowArray(rand2DArray);
double[,] sortRow = SortRowArray(rand2DArray);
//ShowArray(rand2DArray);
ShowArray(sortRow);

