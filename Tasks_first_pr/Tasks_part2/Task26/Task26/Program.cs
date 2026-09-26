using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
        Console.WriteLine();

        /*
        int a = 0;
        int b = 1;
        int i = 0;

        while (i < n)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
            i++;
        }
        Console.WriteLine();
        */
    }
}