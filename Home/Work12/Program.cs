Console.WriteLine();
Console.Write("Введите координату X точки A -> ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X точки B -> ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y точки A -> ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y точки B -> ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z точки A -> ");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z точки B -> ");
double zb = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));

Console.WriteLine();
Console.WriteLine($"Итоговая длина отрезка будет равна = {length}");
Console.WriteLine();
