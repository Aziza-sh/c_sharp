using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("D = ");
        int d = int.Parse(Console.ReadLine());

        int count = 0;
        int temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            temp /= 10;

            if (digit != d) continue;
            count++;
        }
        Console.WriteLine(count);

        /*
        int count = 0;
        int temp = n;
        do
        {
            int digit = temp % 10;
            temp /= 10;
            if (digit == d) count++;
        } while (temp > 0);
        Console.WriteLine(count);
        */
    }
}