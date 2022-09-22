Console.Write("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.Write($"Наибольшее = {num1}");
    }
    else
    {
        Console.Write($"Наибольшее = {num3}");
    }
}
else
{
    if (num2 > num3)
    {
        Console.Write($"Наибольшее = {num2}");
    }
    else
    {
        Console.Write($"Наибольшее = {num3}");
    }
}