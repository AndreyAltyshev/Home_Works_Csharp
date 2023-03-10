/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

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

int[,,] Create3dArraySuccessively(int rows, int colmn, int depth, int initNumber, int finNumber)
{
    int[,,] arr3d = new int[rows, colmn, depth];
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmn; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                if (arr3d[i, j, k] <= finNumber)
                {
                    arr3d[i, j, k] = initNumber + count;
                    count++;
                }
            }
        }
    }
    return arr3d;
}

void PrintArr3D(int[,,] arr3d)
{
    int rows = arr3d.GetLength(0),
        colums = arr3d.GetLength(1),
        depth = arr3d.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{arr3d[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[] ListValue()
{
    int minPositive = 10,
        maxPositive = 99,
        minNegative = -maxPositive,
        maxNegative = -minPositive,
        size = (maxPositive - minPositive) + ((-minNegative) - (-maxNegative)) + 2;
    int[] listValues = new int[size];
    int count = 0;
    for (int i = 0; i < listValues.Length; i++)
    {
        if (i < size / 2)
        {
            count = i;
            listValues[i] = minNegative + count;
        }
        else
        {
            count = i - size / 2;
            listValues[i] = minPositive + count;
        }
    }
    return listValues;
}
int[,,] Create3dArrTwoDiggetRandom(int rows, int colmn, int dep)
{
    int[] listValues = ListValue();
    int[,,] arr3d = new int[rows, colmn, dep];
    Random ind = new Random();
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmn; j++)
        {
            for (int k = 0; k < dep; k++)
            {
                int point = 0;
                while (point == 0)
                {
                    index = ind.Next(0, listValues.Length);
                    if (listValues[index] != 0)
                    {
                        arr3d[i, j, k] = listValues[index];
                        listValues[index] = 0;
                        point = 1;
                    }

                }

            }
        }
    }
    return arr3d;
}

bool ValidateDimansion(int[,,] arr3d, int num)
{
    return arr3d.Length <= num;
}

int row = PromptPositiv("Введите строки "),
    column = PromptPositiv("Введите  столбцы "),
    depth = PromptPositiv("Введите глубину"),
    minElemMatrix = 10,
    maxElemMatrix = 99;
int[,,] array3D = new int[row, column, depth];
if (ValidateDimansion(array3D, maxElemMatrix - minElemMatrix))
{
    array3D = Create3dArraySuccessively(row, column, depth, minElemMatrix, maxElemMatrix);
    PrintArr3D(array3D);
}
else Console.WriteLine("Трёхмерный массив неповторяющихся двузначных положительных чисел, с ведёнными парамметрами, не может существовать,");
int[,,] newArray3D = new int[row, column, depth];
if (ValidateDimansion(array3D, (maxElemMatrix - minElemMatrix) * 2 + 2))
{
    newArray3D = Create3dArrTwoDiggetRandom(row, column, depth);
    Console.WriteLine();
    PrintArr3D(newArray3D);
}
else Console.WriteLine("Трёхмерный массив неповторяющихся двузначных чисел, с ведёнными парамметрами, не может существовать,");
