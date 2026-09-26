using System;

class Program
{
    static void Main()
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        long result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= a;
        }
        Console.WriteLine(result);

        /*
        long result = 1;
        int i = 0;
        while (i < n)
        {
            result *= a;
            i++;
        }
        Console.WriteLine(result);
        */
    }
}