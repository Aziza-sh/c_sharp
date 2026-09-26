using System;

static bool CanDeletePost(UserRole role)
{
    return role == UserRole.Moderator || role == UserRole.Admin;
}

static string GetRoleDescription(UserRole role)
{
    return role switch
    {
        UserRole.Guest => "Гость: только чтение",
        UserRole.User => "Пользователь: может писать",
        UserRole.Moderator => "Модератор: может удалять посты",
        UserRole.Admin => "Администратор: полный доступ",
        _ => "Неизвестная роль"
    };
}

Console.Write("Роль (Guest/User/Moderator/Admin): ");
if (Enum.TryParse<UserRole>(Console.ReadLine(), true, out var role))
{
    Console.WriteLine(GetRoleDescription(role));
    Console.WriteLine(CanDeletePost(role) ? "Может удалять посты" : "Не может удалять посты");
}
else
{
    Console.WriteLine("Неизвестная роль");
}

enum UserRole { Guest, User, Moderator, Admin }