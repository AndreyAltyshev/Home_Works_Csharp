/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
Console.Write("Введите число: ");                                       //выводим запрос на ввод данных
int number = Convert.ToInt32(Console.ReadLine());                       //ввод  данных
if (number % 2 == 0) Console.WriteLine("Введёное число чётное");        //определение чётности цисла
else Console.WriteLine("Введёное число не чётное");