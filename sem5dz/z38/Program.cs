/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] GetRandomArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (minValue - maxValue + 1) + minValue;
    }

    return result;
}

double Raz(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
        i++;
    }
    return max - min;

Console.WriteLine($"max Num{max:f2}");
Console.WriteLine($"min Num{min:f2}");
Console.WriteLine($"difference Num{max - min:f2}");
}

double[] arr = GetRandomArray(10, 1, 10);
Console.WriteLine(String.Join(" ", arr));
Raz(arr);

