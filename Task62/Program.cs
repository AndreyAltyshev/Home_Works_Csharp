/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int PromptPositiv(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1)
    {
        Console.WriteLine("Введено не верное значение попробуйте ещё раз");
        num = PromptPositiv(msg);
    }
    return num;
}

int[,] SpiralCompletionMatrix(int[,] matr)
{
    int count = 1,
        i = 0, j = 0,
        imin = 0, jmin = 0,
        imax = 0, jmax = 0;

    for (int n = 0; n < matr.Length; n++)
    {
        matr[i, j] = count;
        if (i == imin && j < matr.GetLength(1) - 1 - jmax) j += 1;

        else if (j == matr.GetLength(1) - 1 - jmax && i < matr.GetLength(0) - 1 - imax) i += 1;

        else if (i == matr.GetLength(0) - 1 - imax && j > jmin) j -= 1;

        else i -= 1;

        if (i == imin + 1 && j == jmin && j != matr.GetLength(1) - 1 - jmax)
        {
            imin += 1;
            imax += 1;
            jmin += 1;
            jmax += 1;
        }
        count += 1;
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


int row = PromptPositiv("Введите колличество строк "),
    column = PromptPositiv("Введите колличество столбцов ");
int[,] matrix = new int[row, column];
PrintMatrixInt(matrix);
Console.WriteLine();
matrix = SpiralCompletionMatrix(matrix);
PrintMatrixInt(matrix);