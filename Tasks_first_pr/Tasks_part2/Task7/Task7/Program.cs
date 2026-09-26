using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        long product = 1;
        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }
        Console.WriteLine(product);

        /*
        long product = 1;
        int i = 1;
        while (i <= n)
        {
            product *= i;
            i++;
        }
        Console.WriteLine(product);
        */
    }
}