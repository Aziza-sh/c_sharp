using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int temp = n;
        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        Console.WriteLine(sum);

        /*
        int sum = 0;
        int temp = n;
        do
        {
            sum += temp % 10;
            temp /= 10;
        } while (temp > 0);
        Console.WriteLine(sum);
        */
    }
}