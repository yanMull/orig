/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int Chetnum(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {

        if (item % 2 == 0) count++;

    }
    return count;
}
int[] array = GetRandomArray(6, 100, 999);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(Chetnum(array));