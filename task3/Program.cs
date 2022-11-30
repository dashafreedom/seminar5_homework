/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
WriteArray(numbers);


double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (min > numbers[i])
        min = numbers[i];
    }
 Console.WriteLine("min = {0}", min);

double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max < numbers[i])
        max = numbers[i];
    }
 Console.WriteLine("max = {0}", max);

double dif = max - min;
Console.WriteLine("Разница = {0}", dif);


void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
}


void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}