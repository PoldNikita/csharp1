Console.WriteLine("Введите число: ");

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 < num2)
{
    num1 = num2;
}
if (num1 < num3)
{
    num1 = num3;
}
else
Console.Write($"Число {num1} наибольшее");