int[] array = new int[number]; // 0 1 2 3 4 5 6 7

// int[] array1 = new int[8] { 4, 5, 7, 8, 9, 6, 6, 6 };
// int[] array2 = new int[] { 4, 5, 7, 8, 9, 6, 6, 6 };
// int[] array3 = { 4, 5, 7, 8, 9, 6, 6, 6 };
// var array4 = new int[8];

//array[3] = 4546;

for (int i = 0; i < array.Length; i++)
{
array[i] = i * i; // заполнение элементов массива значениями
//Console.Write(array[i] + " "); // вывод элементов массива
}

for (int i = 0; i < array.Length; i++)
{
//array[i] = i * i; // заполнение элементов массива значениями
Console.Write(array[i] + " "); // вывод элементов массива
}