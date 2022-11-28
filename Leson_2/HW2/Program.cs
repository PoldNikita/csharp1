Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int digitsCount = (int)Math.Log10(number) + 1;
int multiplier = (int)Math.Pow(10, digitsCount - 2); 
int result = number % multiplier + number / multiplier / 10 * multiplier; 
Console.WriteLine(result); 