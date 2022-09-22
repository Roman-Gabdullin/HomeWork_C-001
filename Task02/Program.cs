Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.Write($"большее - {num1}, меньшее - {num2} ");
}
else
{
    Console.Write($"большее - {num2}, меньшее - {num1}");
}