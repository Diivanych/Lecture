/*
Задача 66: 
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ShowNumbers(int n, int m)
 {
    if(n>=m)     
    {         
        return n + ShowNumbers(n-1, m);
    }     

    return 0;
}  
    
    Console.WriteLine("Input M: "); 
    int m = Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine("Input N: "); 
    int n = Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine(ShowNumbers(n, m));