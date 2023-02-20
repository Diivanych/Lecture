/*
Напишите программу, которая принимает на входпятизначное число
и проверяет, является ли оно палиндромом.
*/
Console.WriteLine("Введите любое целое чсло");
int number = Convert.ToInt32(Console.ReadLine());

int DepthTest(int num)  // Метод, вычисляющий разрядность
{
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int counter = DepthTest(number);

int[] CreateArray(int num, int count)   // Метод, создаёт и заполняет массив
{
    int ind = 0;
    int cell = 0;
    int[] arra = new int[count];
    while(ind < count)
    {
        cell = num / Convert.ToInt32(Math.Pow(10, count - ind - 1));
        cell = cell % 10;
        arra[ind] = cell;
        ind++;
    }
    return arra;
}

int FinalTest(int[] palindr)   // Проверка на палндром
{
    int i = 0;
    int res = 1;
    while(i < palindr.Length - i -1)
    {
        if(palindr[i] == palindr[palindr.Length -i - 1]) 
        {
            res = 1;
            i++;
        }
        else
        {
            res = 0;
            break;
        }
        
    }
    return res;
}

int result = FinalTest(CreateArray(number, counter));
if(result == 1)
Console.WriteLine("Это палиндром");
else
Console.WriteLine("Это не палиндром");
