/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int number = Prompt("Введите число ");
int summ = SumDiggit(number);
Console.WriteLine($"Сумма цифр в числе {number} равно {summ}");

//metods
int Prompt(string mess)     //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumDiggit(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}