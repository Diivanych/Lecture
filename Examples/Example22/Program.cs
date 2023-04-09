/*
Задача 58: 
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

double[,] Create1Array(int rows, int columns, double min, double max)
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

double[,] Create2Array(int rows, int columns, double min, double max)
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

void Show1Array(double[,] array)
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

void Show2Array(double[,] array)
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
/*
double[,] MultiplyMatrix(double[,] A, double[,] B)
{
    int rA = A.GetLength(0);
    int cA = A.GetLength(1);
    int rB = B.GetLength(0);
    int cB = B.GetLength(1);
    double[,] kHasil = new double[rA, cB];
    if (cA != rB)
    {
        Console.WriteLine("Matrixes can't be multiplied!!");
    }
    else
    {
        double temp = 0;
//        double[,] kHasil = new double[rA, cB];
        for (int i = 0; i < rA; i++)
        {
            for (int j = 0; j < cB; j++)
            {
                temp = 0;
                for (int k = 0; k < cA; k++)
                {
//                kHasil[i,j] = A[i, k] * B[k, j];
                    temp += A[i, k] * B[k, j];
                }
                kHasil[i, j] = temp;
            }
            
        }
//        return kHasil;
    }

    return kHasil; 
}
*/

double[,] CreateMultArray(double[,] a, double[,] b)
{
    double[,] multArr = new double[a.GetLength(0), b.GetLength(1)];
    double temp = 0;

    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < b.GetLength(1); j++)
        {
            temp = 0;

            for(int k = 0; k < a.GetLength(1); k++)
            {
                temp = temp + a[i,k] * b[k,j];
            }
            multArr[i,j] = temp;
        }
    }
    return multArr;
}


void ShowMultArray(double[,] array)
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


/*
void ShowMultiplic(double[,] a, double[,] b)
{
    double aver = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            aver = aver + array[i,j] / array.GetLength(0);
        }
        Console.Write(Math.Round(aver, 2) + " ");
        aver = 0;
    }
    Console.WriteLine();
}
*/

double[,] rand1Array = Create1Array(RowsArray(), ColumnsArray(), MinArray(), MaxArray());
double[,] rand2Array = Create2Array(RowsArray(), ColumnsArray(), MinArray(), MaxArray());
//double[,] multArray = MultiplyMatrix(rand1Array, rand2Array);
double[,] multArray = CreateMultArray(rand1Array, rand2Array);
Show1Array(rand1Array);
Show2Array(rand2Array);
ShowMultArray(multArray);
