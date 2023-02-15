// Создаём два метода

// 1. Метод void FillArray()
// заполняет массив случайными числами 

// 2. Метод void PrintArray()
// Выводит его на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
    Console.WriteLine();
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Наш массив заполнен следующими элементами");
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
