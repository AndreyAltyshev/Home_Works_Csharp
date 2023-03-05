/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

int Prompt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] CreateMatrixDobleRnd(int str, int colume, int min, int max)
{
    double[,] array = new double[str, colume];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < colume; j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
        }
    }
    return array;
}
void PrintMatrix(double[,] arr)
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

int row = Prompt("Введите колличество строк ");
int colum = Prompt("Введите колличество столбцов ");
double[,] randomArray = CreateMatrixDobleRnd(row, colum, 0, 100);
PrintMatrix(randomArray);

