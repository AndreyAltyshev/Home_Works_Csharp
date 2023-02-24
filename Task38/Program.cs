/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

//методы

double[] CreateArrayRndDbl(int size, int min, int max) //метод для создания массива с рандомными значениями эл-в от min до max 
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return arr;
}
void PrintArray(double[] arr)  //метод вывода массива на экран
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
double DiffMinMaxElementsArray(double[] arr)   //метод считающий разницу между min и max
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    double diff = max - min;
    return Math.Round(diff, 1, MidpointRounding.ToZero);
}

// programm

int volume = Prompt("Сколько эллементов в массиве ");
int minElem = Prompt("минимльно возможный эллемент массива: ");
int maxElem = Prompt("Максимальный возможный эллемент массива: ");
double[] array = CreateArrayRndDbl(volume, minElem, maxElem);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным эллементом массива: {DiffMinMaxElementsArray(array)}");