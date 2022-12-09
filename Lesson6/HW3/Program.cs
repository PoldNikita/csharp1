// Задайте массив вещественных чисел. Пример вещетвенного числа - 3,14
// Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите число - размер будущего массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Это весь массив с заданными числами: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int b = 0; z < numbers.Length; b++)
{
    if (numbers[b] > max)
        {
            max = numbers[b];
        }
    if (numbers[b] < min)
        {
            min = numbers[b];
        }
}

Console.WriteLine($"Всего задан массив из {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
