/*
Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

int StartedNumb()
{
    Console.WriteLine("Введите стартовое число");
    int start = Convert.ToInt32(Console.ReadLine());

    while(start <= 0)
    {
        Console.WriteLine("Стартовое число желательно выбрать от 10 до 99");
        Console.WriteLine("Введите стартовое число ещё раз");
        start = Convert.ToInt32(Console.ReadLine());
    }
    return start;
}

int [,] Create2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = 0;
        }
    }
/*    
    newArray[5,0] = -7;
    newArray[5,1] = -7;
    newArray[5,2] = -7;
    newArray[5,3] = -7;

    newArray[5,5] = -7;
    newArray[5,6] = -7;
    newArray[5,7] = -7;
    newArray[5,8] = -7;
*/    
    return newArray;
}

void ShowArray(int[,] array)
{
    Console.WriteLine();
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

int[,] fillArray(int[,] zArr, int start)
{
    int row = 0;
    int col = 0;
    int a = start;
    while(start < a + 1 + zArr.GetLength(0) * zArr.GetLength(1))
    {
        start++;    
        if((row - 1 < 0) || (zArr[row - 1, col] != 0))
            if((col + 1 >zArr.GetLength(1)-1) || (zArr[row, col + 1] != 0))
                if((row + 1 >zArr.GetLength(0)-1) || (zArr[row + 1, col] != 0))
                    if((col - 1 < 0) || (zArr[row, col - 1] != 0))
                        break;
                    else
                    {
                        zArr[row,col] = start;
                        col = col - 1;
                    }
                else
                {
                    zArr[row,col] = start;
                    row = row + 1;
                }
            else
            {
                zArr[row,col] = start;
                col = col + 1;
            }
        else
        {
            zArr[row,col] = start;
            row = row - 1;
        }
        zArr[row,col] = start + 1;
    }
    return zArr;
}

int[,] array2D = Create2DArray(RowsArray(), ColumnsArray());
ShowArray(array2D);
int[,] fillArr = fillArray(array2D, StartedNumb());
ShowArray(fillArr);