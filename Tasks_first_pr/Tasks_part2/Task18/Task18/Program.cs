using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int original = n;
        long reverse = 0;
        int temp = n;

        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }

        if (original == reverse)
            Console.WriteLine("Палиндром");
        else
            Console.WriteLine("Не палиндром");

        /*
        int original = n;
        long reverse = 0;
        int temp = n;

        do
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        } while (temp > 0);

        if (original == reverse)
            Console.WriteLine("Палиндром");
        else
            Console.WriteLine("Не палиндром");
        */
    }
}