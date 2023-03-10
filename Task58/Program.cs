/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

bool IsItPossibleMultiply(int[,] matr1, int[,] matr2)
{
    return matr1.GetLength(1) == matr2.GetLength(0);
}

int[,] MultplyTwoMatrix(int[,] matr1, int[,] matr2)
{
    int resRows = matr1.GetLength(0),
        resColmn = matr2.GetLength(1),
        multiply = 1,
        sum = 0;
    int[,] result = new int[resRows, resColmn];
    for (int i = 0; i < resRows; i++)
    {
        for (int j = 0; j < resColmn; j++)
        {
            multiply = 1;
            sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                multiply = matr1[i, k] * matr2[k, j];
                sum += multiply;
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int rowsFirst = PromptPositiv("Введите колличество строк первой матрицы "),
    colmnFirst = PromptPositiv("Введите колличество столбцов первой матрицы "),
    rowsSecond = PromptPositiv("Введите колличество строк второй матрицы "),
    colmnSecond = PromptPositiv("Введите колличество столбцов второй матрицы "),
    minElemMatrix = 0,
    maxElemMatrix = 10;
int[,] firstMatrix = CreateMatrixIntRnd(rowsFirst, colmnFirst, minElemMatrix, maxElemMatrix);
Console.WriteLine("Первая матрица:");
PrintMatrixInt(firstMatrix);
int[,] secondMatrix = CreateMatrixIntRnd(rowsSecond, colmnSecond, minElemMatrix, maxElemMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrixInt(secondMatrix);
if (IsItPossibleMultiply(firstMatrix, secondMatrix))             // можно было не писать метод и проверять условие (colmnFirst == rowsSecond)
{
    int[,] result = MultplyTwoMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("Результирующая матрица");
    PrintMatrixInt(result);
}
else Console.WriteLine("Произведение посчитать не возможно");