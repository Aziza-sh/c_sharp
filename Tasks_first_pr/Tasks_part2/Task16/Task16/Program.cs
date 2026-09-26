using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int min = 9;
        int temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit < min) min = digit;
            temp /= 10;
        }
        Console.WriteLine(min);

        /*
        int min = 9;
        int temp = n;
        do
        {
            int digit = temp % 10;
            if (digit < min) min = digit;
            temp /= 10;
        } while (temp > 0);
        Console.WriteLine(min);
        */
    }
}