using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 2; i <= n; i += 2)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        /*
        int sum = 0;
        int i = 2;
        while (i <= n)
        {
            sum += i;
            i += 2;
        }
        Console.WriteLine(sum);
        */
    }
}