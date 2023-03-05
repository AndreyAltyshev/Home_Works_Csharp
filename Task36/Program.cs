/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

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

int SumNotEvenEllemArray(int[] arr)   //метод считающий сумму нечётных эллементов
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}
// programm
int volume = Prompt("Введите колличество эллементов массива ");
int minElem = Prompt("Минимльно возможный эллемент массива: ");
int maxElem = Prompt("Максимальный возможный эллемент массива: ");
int[] array = CreateArrayRndInt(volume, minElem, maxElem);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечётных эллементов массива {SumNotEvenEllemArray(array)}");