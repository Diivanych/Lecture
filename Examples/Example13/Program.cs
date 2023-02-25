/*
Дан текст. В тексте нужно все пробеллы 
заменить чёрточкам.
Маленьке буквы "к" заменить большими "К".
Большие "С" заменить маленькими "с".
*/
string text = "Узнаете, что массивы в языке С# "
            + "описываются разными способами. "
            + "Посмотрите, как описываются "
            + "методы, попробуете написать "
            + "собственные методы,";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue)
        result = result + $"{newValue}"; // newValue;
        else
        result = result + $"{text[i]}"; // text[i];
    }
    return result;
}
Console.WriteLine();
string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();