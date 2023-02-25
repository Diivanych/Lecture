/*
Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine();
Console.Write("Введте коллчество элементов массива -> ");
int lenght = Convert.ToInt32(Console.ReadLine());

void PrintArray(int len)
{
    Console.WriteLine("Вводите числа ");
    Console.WriteLine();
    int[] array = new int [len];
    for(int i = 0; i < len; i++) 
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Элементы массива -> [");
    for(int i = 0; i < len; i++) 
    Console.Write($" {array[i]},");
    Console.WriteLine(" ]");
    Console.WriteLine();
}
PrintArray(lenght);