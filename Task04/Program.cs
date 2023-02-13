//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите 3 числа, после ввода каждого числа нажмите 'enter'"); //выводим текст запроса
int number1 = Convert.ToInt32(Console.ReadLine());  //строки 6-9 объявление переменных и ввод данных
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;                                   

if (max < number2)  max = number2;  // строки 11 12 поиск максимального из 3-х чисел
if (max < number3 ) max = number3; 

Console.Write($"Максимальное число из введёных: max={max}"); //вывод на экран результата