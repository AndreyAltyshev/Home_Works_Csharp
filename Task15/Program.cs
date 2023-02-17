/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

// Методы

bool DayVerification(int day)
{
    return day > 0 && day < 8;
}
bool CheckWeek(int day)
{
    return day == 6 || day == 7;
}

//тело программы

Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if(DayVerification(day)) 
{
    if (CheckWeek(day)) Console.WriteLine($"{day}-ой день является выходным");
    else Console.WriteLine("Не является выходным");
}
else Console.WriteLine("Введено не коректное значение");