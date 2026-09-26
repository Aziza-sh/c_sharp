using System;

const int secretCode = 2468;
int attempts = 0;
bool guessed = false;

while (attempts < 3 && !guessed)
{
    Console.WriteLine("Введите код:");
    int code = Convert.ToInt32(Console.ReadLine());
    attempts = attempts + 1;

    if (code == secretCode)
    {
        guessed = true;
        Console.WriteLine("Код принят");
    }
}

if (!guessed)
{
    Console.WriteLine("Попытки закончились");
}
