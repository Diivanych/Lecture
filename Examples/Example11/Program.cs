/*
Типы методов
Всего рассматривается 4 вида.
==============================================
Вид 1.
Метод ничего не возвращает 
и ничего не принимает.
*/
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();
/*
==============================================
Вид 2.
Метод ничего не возвращает,
но принимает аргументы.
*/

void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2(msg: "Текст сообщения", count: 4);
Method2(count: 4, msg: "новый текст");
// Используем именованные аргументы
// В этом случае порядок указания аргументов 
// не важен.
/*
==============================================
Вид 3.
Метод что-то возвращает,
но ничего не принимает.
*/
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
/*
==============================================
Вид 4.
Метод что-то принимает 
и что-то возвращает
*/
string Method4(int count, string text)
{
    string result = String.Empty;//Пустая строка
    
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, " Беня ");
Console.WriteLine(res);