using System;

class Program
{
    static void Main()
    {
        Console.Write("W = ");
        int w = int.Parse(Console.ReadLine());

        Console.Write("H = ");
        int h = int.Parse(Console.ReadLine());

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        /*
        int i = 0;
        while (i < h)
        {
            int j = 0;
            while (j < w)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            i++;
        }
        */
    }
}