using System;

class FibonacciProgram
{
    static void Main()
    {
        Console.Write("Enter how many Fibonacci numbers to display: ");
        int n = int.Parse(Console.ReadLine()!);

        int a = 0, b = 1;

        Console.Write("Fibonacci series: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine();
    }
}
