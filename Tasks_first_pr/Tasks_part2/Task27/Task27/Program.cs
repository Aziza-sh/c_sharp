using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > max) max = x;
        }

        Console.WriteLine($"Максимум: {max}");

        /*
        int max = int.MinValue;
        int i = 0;

        while (i < n)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > max) max = x;
            i++;
        }

        Console.WriteLine($"Максимум: {max}");
        */
    }
}