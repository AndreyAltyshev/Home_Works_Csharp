/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int Prompt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateMatrixIntRnd(int str, int col, int min, int max)
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

void PrintMatrixInt(int[,] arr)
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

/* void AverageColume(int[,] arr)          // метод для расчёта среднего арифметического по столбцам и с выводом результата в консоль
{
    int rows = arr.GetUpperBound(0) + 1;
    int colums = arr.Length / rows;
    double aver = 0;
    double sum = 0;
    for (int j = 0; j < colums; j++)
    {
        sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + arr[i, j];
        }
        aver = sum / rows;
        Console.WriteLine($"Среднее арифметическое столбца {j+1} равно {aver}");
    }

}
 */
double[] AverageColume(int[,] arr)          
{
    double[] result = new double[arr.GetLength(1)];
    double aver = 0;
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        aver = sum / arr.GetLength(0);
        result[j] = aver; 
    }
    return result;

}
void PrintArray(double[] arr)  //метод вывода массива на экран
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i], 6}");
    }
    
}

int row = Prompt("Введите колличество строк ");
int colume = Prompt("Введите колличество столбцов ");
int[,] array = CreateMatrixIntRnd(row, colume, 0, 10);
PrintMatrixInt(array);

Console.WriteLine("средее арифметическое:");
double[] res = AverageColume(array);
PrintArray(res);