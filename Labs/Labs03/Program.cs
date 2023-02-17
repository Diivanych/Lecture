// Написать программу, которая выводит случайное трёхзначное число
// и удаляет из него вторую цифру
// 456 -> 46,   782 -> 72,   918 -> 98
// просмотр остановлен на 38 минуте 

int DeleteDecimal(int num)
{
    int sot = num / 100;
    int edc = num %  10;
    return sot * 10 + edc;
    
}

int randomnamber = new Random().Next(100, 1000);

Console.WriteLine(randomnamber);
Console.WriteLine(DeleteDecimal(randomnamber));