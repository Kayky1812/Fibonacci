using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Informe um número:");
        int numero = int.Parse(Console.ReadLine());

        if (EhNumeroFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    
    static bool EhNumeroFibonacci(int n)
    {
        if (n < 0)
        {
            return false;
        }

        
        int a = 0;
        int b = 1;

       
        while (a <= n)
        {
            if (a == n)
            {
                return true;
            }
            int temp = a;
            a = b;
            b = temp + b;
        }
        return false;
    }
}
