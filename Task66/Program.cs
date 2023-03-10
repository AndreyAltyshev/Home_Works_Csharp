/* Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

//методы

int PromptPositiv(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1)
    {
        Console.WriteLine("Введено не натуральное число M=");
        num = PromptPositiv(msg);
    }
    return num;
}

int SumElementFromSegment(int num1, int num2)
{
    if (num1 == num2) return num2;
    else return num1 + SumElementFromSegment(num1-1, num2);
}

//Тело программы

int numberOne = PromptPositiv("Введите натуральное число M="),
    numberTwo = PromptPositiv("Введите натуральное число N="),
    sum = 0;
if (numberOne > numberTwo) sum = SumElementFromSegment(numberOne, numberTwo);
else sum = SumElementFromSegment(numberTwo, numberOne);
Console.WriteLine($"Сумма эллементов в заданном отрезке равна:{sum}");
