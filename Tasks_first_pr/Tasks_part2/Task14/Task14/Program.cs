using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        long reverse = 0;
        int temp = n;
        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }
        Console.WriteLine(reverse);

        /*
        long reverse = 0;
        int temp = n;
        do
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        } while (temp > 0);
        Console.WriteLine(reverse);
        */
    }
}