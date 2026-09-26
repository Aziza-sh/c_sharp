using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        do
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0) break;
            sum += x;
        } while (true);

        Console.WriteLine(sum);

        /*
        int sum = 0;
        while (true)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0) break;
            sum += x;
        }
        Console.WriteLine(sum);
        */
    }
}