Console.WriteLine("введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число: ");
int N3 = Convert.ToInt32(Console.ReadLine());

int max = N1;

if(max<N2)
{
max = N2;   
}
if(max<N3)
{
max = N3;
}
Console.Write("max=");
Console.WriteLine(max);