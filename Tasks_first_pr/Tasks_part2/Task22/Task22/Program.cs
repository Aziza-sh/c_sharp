using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i != 0) continue;
            count++;
        }
        Console.WriteLine(count);

        /*
        int count = 0;
        int i = 1;
        while (i <= n)
        {
            if (n % i == 0) count++;
            i++;
        }
        Console.WriteLine(count);
        */
    }
}