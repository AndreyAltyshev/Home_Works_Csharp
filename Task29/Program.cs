/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

int[] arr = NewRandomArray(8, 0, 150);
Console.WriteLine($"Полученый массив из 8 эллементов");
PrintArray(arr);
Console.Write(" -> [");
PrintArray(arr);
Console.Write("]");
Console.WriteLine();

//Методы
int[] NewRandomArray(int number, int min, int max)
{
    Random rand = new Random();
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write($", ");
    }
}