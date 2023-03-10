/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

//методы

int PromptPositiv(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1)
    {
        Console.WriteLine("Введено не натуральное число");
        num = PromptPositiv(msg);
    }
    return num;
}

void PrintNatureDecreasingOrder(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    PrintNatureDecreasingOrder(num-1);
}

//Тело программы
int number = PromptPositiv("Введите натуральное число ");
PrintNatureDecreasingOrder(number);