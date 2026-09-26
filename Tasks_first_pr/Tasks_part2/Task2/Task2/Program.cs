using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        /*
        int i = n;
        while (i >= 1)
        {
            Console.Write(i + " ");
            i--;
        }
        Console.WriteLine();
        */
    }
}