using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }

        /*
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
            i++;
        }
        */
    }
}