/*
Задача 68: 
Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

 int solve_rec(int m, int n)
    {
        if(m == 0)
        {
            return n+1;
        }
        else 
        if(m > 0 && n == 0)
        {
            return solve_rec(m-1,1);
        }
        else
        {
            return solve_rec(m-1,solve_rec(m,n-1));
        }
    }

    Console.WriteLine("Input M: "); 
    int m = Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine("Input N: "); 
    int n = Convert.ToInt32(Console.ReadLine());  
    
    Console.WriteLine(solve_rec(m, n));