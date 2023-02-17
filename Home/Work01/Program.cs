// Напишите программу, которая выводит третью цифру 
// заданного числа, или сообщает, что третьей цифры нет.
// 645 -> 4,    78 -> трерьей цифры нет,    32679 -> 6

int NumberControl(int num, int pos)
{
    int ind = 1;
    int div = 1;
    if(num < 0) num = (num * (- 1));
       
    while(ind <= pos)
    {
        div = div * 10;
        ind++;
    }
    
    if(num < div)
        return -1;
        return num;
}

int SearchPosiiton(int num, int pos)
{
    int ind = 1;
    int div = 1;

    while(ind <= pos)
    {
        div = div * 10;
        ind++;
    }
        
    while(num >= div)
        num = num / 10;
    return (num % 10);
}

Console.WriteLine("Введите чсло");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите искомую позицию");
int position = Convert.ToInt32(Console.ReadLine());

int result = SearchPosiiton(NumberControl(number, position), position);
if(result == -1) Console.WriteLine("В этом числе нет такой позиции");
else    Console.WriteLine($"{number} -> {result}");