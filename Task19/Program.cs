/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */
// Тело программы
int number = Prompt("Введите число");       //ввод данных
int revNumber = ReverseNum(number);         //получаем развёрнутое число
if (number == revNumber) Console.WriteLine($"Число {number} является палиндромом");         //сравниваем на палиндром
else Console.WriteLine($"Число {number} не является палиндромом");

//Методы
int Prompt(string mess)                                           //метод ввода данных
{
    Console.WriteLine(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int ReverseNum(int num)                                        //метод разворачивающий число
{
    int revNum = 0;
    while (num > 0)
    {
        revNum = revNum * 10 + num % 10;
        num = num / 10;
    }
    return revNum;
}