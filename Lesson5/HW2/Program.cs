// принимает на вход число и выдаёт сумму цифр в числе
int num_1 = ReadInt("Введите число (минимум двузначное): ");
int len = NumLen(num_1);
SumNumbers(num_1, len);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
