using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (IsFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == n;
    }
}