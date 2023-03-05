/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

// methods

int Prompt(string mess)     //метод ввода 
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintCountPositivNumbers(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >0 ) count++;
    }
    Console.WriteLine($" введено положительных чисел-> {count}");
}

int[] InputArrayFromKeyboard(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1} число ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return array;
}

void PrintArray(int[] arr)  //метод вывода массива на экран
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int len = Prompt("Введите сколько чисел вводить ");
if(len>0) 
{
    int[] arrNumbers = InputArrayFromKeyboard(len);
    PrintArray(arrNumbers);
    PrintCountPositivNumbers(arrNumbers);
}
else Console.WriteLine("введено не верное значение");
