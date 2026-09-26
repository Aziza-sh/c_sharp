using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int product = 1;
        int temp = n;
        while (temp > 0)
        {
            product *= temp % 10;
            temp /= 10;
        }
        Console.WriteLine(product);

        /*
        int product = 1;
        int temp = n;
        do
        {
            product *= temp % 10;
            temp /= 10;
        } while (temp > 0);
        Console.WriteLine(product);
        */
    }
}