using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime && n > 1)
            Console.WriteLine("Простое");
        else
            Console.WriteLine("Составное");

        /*
        bool isPrime = true;
        int i = 2;
        while (i * i <= n)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
            i++;
        }

        if (isPrime && n > 1)
            Console.WriteLine("Простое");
        else
            Console.WriteLine("Составное");
        */
    }
}