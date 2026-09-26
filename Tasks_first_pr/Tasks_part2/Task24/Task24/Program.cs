using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;

            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(i + " ");
        }
        Console.WriteLine();

        /*
        int i = 2;
        while (i <= n)
        {
            bool isPrime = true;
            int j = 2;

            while (j * j <= i)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
                j++;
            }

            if (isPrime)
                Console.Write(i + " ");
            i++;
        }
        Console.WriteLine();
        */
    }
}