using System;

static bool ValidatePassword(string password)
{
    bool HasDigit()
    {
        foreach (char c in password) if (char.IsDigit(c)) return true;
        return false;
    }

    bool HasUpper()
    {
        foreach (char c in password) if (char.IsUpper(c)) return true;
        return false;
    }

    bool HasMinLength() => password.Length >= 8;

    return HasDigit() && HasUpper() && HasMinLength();
}

Console.Write("Введите пароль: ");
string pwd = Console.ReadLine();
Console.WriteLine(ValidatePassword(pwd) ? "Пароль принят" : "Пароль слишком простой");