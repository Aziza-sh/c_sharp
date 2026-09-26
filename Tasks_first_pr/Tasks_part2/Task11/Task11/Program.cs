using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        int temp = n;
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }
        Console.WriteLine(count);

        /*
        int count = 0;
        int temp = n;
        do
        {
            count++;
            temp /= 10;
        } while (temp > 0);
        Console.WriteLine(count);
        */
    }
}