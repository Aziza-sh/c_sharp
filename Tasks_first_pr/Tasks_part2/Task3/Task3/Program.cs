using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        /*
        int i = 2;
        while (i <= n)
        {
            Console.Write(i + " ");
            i += 2;
        }
        Console.WriteLine();
        */
    }
}