Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
Console.Write("max=");
Console.WriteLine(number1);
Console.Write("min=");
Console.WriteLine(number2);
}
else
{
Console.Write("max=");
Console.WriteLine(number2);
Console.Write("min=");
Console.WriteLine(number1);
}