using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int max = 0;
        int temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit > max) max = digit;
            temp /= 10;
        }
        Console.WriteLine(max);

        /*
        int max = 0;
        int temp = n;
        do
        {
            int digit = temp % 10;
            if (digit > max) max = digit;
            temp /= 10;
        } while (temp > 0);
        Console.WriteLine(max);
        */
    }
}