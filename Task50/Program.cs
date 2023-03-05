/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого элемента в массиве нет */

int Prompt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateArrayIntRnd(int str, int col, int min, int max)
{
    int[,] arr = new int[str, col];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = rand.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    int rows = arr.GetUpperBound(0) + 1;
    int colums = arr.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{arr[i, j], 6}");
        }
        Console.WriteLine();
    }
}

void SearchElement(int[,] arr, int str, int clmn)
{
    if (str < arr.GetLength(0) && clmn < arr.GetLength(1)) Console.WriteLine($"Эллемент массиваа с индексом строки {str} и столбца {clmn} -> {arr[str, clmn]}");
    else Console.WriteLine($"Эллемента массиваа с индексом строки {str} и столбца {clmn} не существует");
}

int row = Prompt("Введите колличество строк ");
int colume = Prompt("Введите колличество столбцов ");
int[,] matrix = CreateArrayIntRnd(row, colume, 0, 10);
PrintMatrix(matrix);
int searchIndexRow = Prompt("Введите индекс строки разыскиваемого эллемента ");
int searchIndexColume = Prompt("Введите индекс столбца разыскиваемого эллемента ");
SearchElement(matrix, searchIndexRow, searchIndexColume);