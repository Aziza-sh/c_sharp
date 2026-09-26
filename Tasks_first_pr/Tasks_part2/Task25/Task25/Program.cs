using System;

class Program
{
    static void Main()
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine(a);

        /*
        do
        {
            int temp = b;
            b = a % b;
            a = temp;
        } while (b != 0);

        Console.WriteLine(a);
        */
    }
}