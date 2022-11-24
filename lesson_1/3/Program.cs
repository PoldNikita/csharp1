// программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.Write($"Число {num1} четное");
}
else
{
    Console.WriteLine($"Число {num1} НЕЧЕТНОЕ");
}

Console.WriteLine("Введите число: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 % 2 == 0)
{
    Console.Write($"Число {num2} ЧЕТНОЕ");
}
else
{
    Console.Write($"Число {num2} нечетное");
}
