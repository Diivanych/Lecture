/* 
Задача:

Написать программу, которая из меющегося массива 
строк формирует массив из строк, длина которых 
меньше либо равна 3 символам.

Массив задаётся на входе.
*/

string[] array = { "Мороз", "и", "солнце","день", "чудесный", "ещё", "ты", "дремлешь", "друг", "прелестный"};

void MethodShowArray(string[] array)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < array.Length; i++) 
    Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string[] MethodCreateArray(string[] array)
{
    Console.Write($"Output array: ");
    string[] shortarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortarr[i] = array[i];
            Console.Write($"{shortarr[i]} ");
        }
    }
    Console.WriteLine();
    return shortarr;
}

Console.WriteLine();
MethodShowArray(array);
Console.WriteLine();
string[] newArray = MethodCreateArray(array);
Console.WriteLine();
// MethodShowArray(newArray);