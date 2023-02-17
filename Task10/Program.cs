/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

//Методы

bool CheckThreeDiget(int num)
{
    return num > 100 && num < 1000;
}
int CheckSecondDiget(int num)
{
    int firstDig = num / 10;
    int secondDiget = firstDig % 10;
    return secondDiget;
}
//Тело программы

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (CheckThreeDiget(number)) Console.WriteLine($"Вторая цифра числа {number} => {CheckSecondDiget(number)}");
else Console.WriteLine("число не трёхзначное");