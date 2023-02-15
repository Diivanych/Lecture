
int MaxDecimal(int num)
{
    int edc = num % 10;
    int dec = num / 10;

    if(edc > dec) num = edc;
    else num = dec;
    return num;
}

int randomnumber = new Random().Next(10, 100);
int maxnum = MaxDecimal(randomnumber);
Console.WriteLine($"Наибольшая цифра числа {randomnumber} это {maxnum}.");