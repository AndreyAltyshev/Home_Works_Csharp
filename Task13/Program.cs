/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

//Методы
bool ThreeDigetVerification(int num)
{
    return num > 99;
}
int ChekTheTreeDiget(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
//Тело программы

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int modNumber = Math.Abs(number);
if (ThreeDigetVerification(modNumber)) Console.WriteLine($"Третья цифра числа {number} => {ChekTheTreeDiget(modNumber)}");
else Console.WriteLine("в числе нет третьей цифры");