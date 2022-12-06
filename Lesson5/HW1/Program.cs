// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень
int num_A = ReadInt("Введите число A: ");
int numB = ReadInt("Введите число B: ");
ToDegree(num_A, numB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}