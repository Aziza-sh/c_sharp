using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i != 0) continue;
            Console.Write(i + " ");
        }
        Console.WriteLine();

        /*
        int i = 1;
        while (i <= n)
        {
            if (n % i == 0) Console.Write(i + " ");
            i++;
        }
        Console.WriteLine();
        */
    }
}