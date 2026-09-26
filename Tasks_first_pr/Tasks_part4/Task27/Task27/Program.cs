using System;

static string GetStatusMessage(OrderStatus status)
{
    return status switch
    {
        OrderStatus.New => "Заказ создан",
        OrderStatus.Paid => "Заказ оплачен",
        OrderStatus.Shipped => "Заказ отправлен",
        OrderStatus.Delivered => "Заказ доставлен",
        OrderStatus.Cancelled => "Заказ отменён",
        _ => "Неизвестный статус"
    };
}

Console.Write("Статус (New/Paid/Shipped/Delivered/Cancelled): ");
if (Enum.TryParse<OrderStatus>(Console.ReadLine(), true, out var st))
    Console.WriteLine(GetStatusMessage(st));
else
    Console.WriteLine("Неизвестный статус");

enum OrderStatus { New, Paid, Shipped, Delivered, Cancelled }