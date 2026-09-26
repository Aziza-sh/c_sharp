using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        long factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);

        /*
        long factorial = 1;
        int i = 2;
        while (i <= n)
        {
            factorial *= i;
            i++;
        }
        Console.WriteLine(factorial);
        */
    }
}