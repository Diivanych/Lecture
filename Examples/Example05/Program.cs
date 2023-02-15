// Поиск позиции заданного элемента в массиве
// Создаём новый метод IndexOf()

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -2;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Искомый элемент находится на позиции");

int pos = IndexOf(array, 4);
Console.WriteLine(pos + 1);