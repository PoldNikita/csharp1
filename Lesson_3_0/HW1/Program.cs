// определяет является ли число палиндромом (пример 12321)
void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int digit1 = number / 10000;
        int digit5 = number % 10;
 
            if(digit1 == digit5)
            {
                number = number / 10;
                int digit2 = number / 100 % 10;
                int digit4 = number % 10;
                if(digit2 == digit4)
                    Console.WriteLine("Да, это палиндром");
            }
            else 
            Console.WriteLine("Нет, это не палиндром");
            
    }
    else
    Console.WriteLine("Введено не пятизначное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);
