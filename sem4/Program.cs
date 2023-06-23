//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] array = new int[number];
//int[] array1 = new int[8]{4,5,6,2,1,6,7,7};
//int[] array2 = new int[]{4,5,6,2,1,6,7,7};
//int[] array3 = {4,5,6,2,1,6,7,7};
//var array4 = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = i*i;
    Console.Write(array[i] + "");
}