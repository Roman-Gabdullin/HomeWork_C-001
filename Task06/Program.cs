Console.Write ("Введите целое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 % 2;
if (num2 == 0)
{
    Console.Write ("Четное");
}
else
{
    Console.Write ("Нечетное");
}