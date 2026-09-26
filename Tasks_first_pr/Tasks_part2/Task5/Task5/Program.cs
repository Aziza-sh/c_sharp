using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);

        /*
        int sum = 0;
        int i = 1;
        while (i <= n)
        {
            sum += i;
            i++;
        }
        Console.WriteLine(sum);
        */
    }
}