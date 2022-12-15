Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a == b*b)
{
  Console.Write("Первое квадрат второго");
}
else
{ Console.WriteLine("Первое не квадрат второго");
}