/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int PromptPositiv(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < 1)
    {
        Console.WriteLine("Введено не верное значение попробуйте ещё раз");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

int[,] CreateMatrixIntRnd(int str, int col, int min, int max)
{
    int[,] matr = new int[str, col];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matr[i, j] = rand.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrixInt(int[,] matr)
{
    int rows = matr.GetLength(0);
    int colums = matr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{matr[i, j],6}");
        }
        Console.WriteLine();
    }
}

int[] ArraySumsRowsMatrix(int[,] matr)
{
    int rows = matr.GetLength(0),
        colmn = matr.GetLength(1);
    int[] arrSum = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < colmn; j++)
        {
            sum += matr[i, j];
        }
        arrSum[i] = sum;
    }
    return arrSum;
}

int NumberLineWithMinSumElems(int[] arr)
{
    int number = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i - 1] < arr[number]) number = i-1;
    }
    return number + 1;
}

int row = PromptPositiv("Введите колличество строк "),
    column = PromptPositiv("Введите колличество столбцов "),
    minElemMatrix = 0,
    maxElemMatrix = 10;
int[,] matrix = CreateMatrixIntRnd(row, column, minElemMatrix, maxElemMatrix);
PrintMatrixInt(matrix);
int[] sumArray = ArraySumsRowsMatrix(matrix);
int numberLine = NumberLineWithMinSumElems(sumArray);
Console.WriteLine($"Наименьшая сумма эллементов в строке: {numberLine}");