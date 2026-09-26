using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        /*
        int i = 1;
        while (i <= n)
        {
            Console.Write(i + " ");
            i++;
        }
        Console.WriteLine();
        */
    }
}