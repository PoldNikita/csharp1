Console.WriteLine("Введите число - размер будущего массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Это весь массив со случайными числами: ");
PrintArray(numbers);
int count = 0;

for (int b = 0; b < numbers.Length; b++)
if (numbers[b] % 2 == 0)
count++;

Console.WriteLine($"Итого в массиве {numbers.Length} чисел, {count} из которых - чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

