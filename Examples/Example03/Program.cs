// Имеется одномерный массив "array" из "n" элементов. 
// Требуется найти элемент массива, равный "find"

int [] array = { 1, 12, 31, 18, 15, 16, 17, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;    
}