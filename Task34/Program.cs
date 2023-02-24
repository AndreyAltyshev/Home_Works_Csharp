/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

 */

//методы

int[] CreateArrayRndInt(int size, int min, int max) //метод для создания массива с рандомными значениями эл-в от min до max 
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)  //метод вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int Prompt(string mess)     //метод ввода 
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int CountIfEvenEllementArr(int[] arr)   //метод счётчик чётных эллементов
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count = count + 1;
    }
    return count;
}

// programm
int volume = Prompt("Сколько эллементов в массиве ");
int minElem = 100; //Prompt("минимльный эллемент массива ");
int maxElem = 999; //Prompt("Максимальный эллемент миассива ");
int[] array = CreateArrayRndInt(volume, minElem, maxElem);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Чётных эллементов в массиве {CountIfEvenEllementArr(array)}");