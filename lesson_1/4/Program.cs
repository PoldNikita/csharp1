// программа, которая на вход принимает число (N),
//    а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");

int num1 = int.Parse(Console.ReadLine());
int i = 2;

while (i <= num1)
{    
    Console.Write($"{i} ");
    i += 2;
}