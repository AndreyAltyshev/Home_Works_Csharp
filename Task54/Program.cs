/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void PrintMatrixInt(int[,] arr)
{
    int rows = arr.GetLength(0);
    int colums = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{arr[i, j],6}");
        }
        Console.WriteLine();
    }
}

void SortMatrixMaxToMinOfRows(int[,] matr)
{
    int rows = matr.GetLength(0),
        colmn = matr.GetLength(1),
        temp = matr[0, 0];
    for (int i = 0; i < rows; i++)
    {
        for (int iter = 0; iter < colmn; iter++)
        {
            for (int j = 1; j < colmn; j++)
            {
                if (matr[i, j] > matr[i, j - 1])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, j - 1];
                    matr[i, j - 1] = temp;
                }
            }

        }
    }
}

int row = PromptPositiv("Введите колличество строк "),
    column = PromptPositiv("Введите колличество столбцов "),
    minElemMatrix = -10,
    maxElemMatrix = 100;
int[,] matrix = CreateMatrixIntRnd(row, column, minElemMatrix, maxElemMatrix);
PrintMatrixInt(matrix);
SortMatrixMaxToMinOfRows(matrix);
Console.WriteLine();
PrintMatrixInt(matrix);