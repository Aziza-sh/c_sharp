using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        /*
        int i = 1;
        while (i <= n)
        {
            Console.Write(i + " ");
            i += 2;
        }
        Console.WriteLine();
        */
    }
}