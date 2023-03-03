/*
Задача 43: 

Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
double[,] matrix = new double[2,2];

Console.WriteLine();
Console.WriteLine("Введите смещение B1 для первой прямой");
matrix[0, 0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите коэффициент K1 для первой прямой");
matrix[0, 1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите смещение B2 для второй прямой");
matrix[1, 0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите коэффициент K2 для второй прямой");
matrix[1, 1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();


if(matrix[0, 1] == matrix[1, 1]) 
{
    Console.WriteLine("Эти прямые параллельны и не имеют точек пересечения");
    Console.WriteLine();
    return;
}

if(matrix[0, 0] == matrix[1, 0]) 
{
    Console.WriteLine($"Эти прямые пересекаются в точке X = 0   Y = {matrix[0, 0]}");
    Console.WriteLine();
    return;
}

double x = (matrix[1, 0] - matrix[0, 0]) / (matrix[0, 1] - matrix[1, 1]);
double y = matrix[0, 1] * x + matrix[0, 0];

Console.WriteLine($"Точка пересечения двух прямых имеет координаты X = {Math.Round(x, 3)}   Y = {Math.Round(y, 3)}");
Console.WriteLine();
Console.WriteLine();


//int num = Math.Min(array.GetLength(0), array.GetLength(1)); 