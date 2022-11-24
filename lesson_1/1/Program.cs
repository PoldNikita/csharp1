Console.WriteLine("введите первое число:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе число:");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"первое введенное число (вы ввели: {num1}) больше второго");
}
else 
Console.WriteLine($"второе введенное число (вы ввели: {num2}) больше первого");