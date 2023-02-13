//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число для сравнения a=");             //выводим запрос на ввод данных
int number1 = Convert.ToInt32(Console.ReadLine());                  //ввод первого числа
Console.Write("Введите второе число b=");                           //выводим запрос на ввод данных
int number2 = Convert.ToInt32(Console.ReadLine());                  //ввод второго числа
if (number1 < number2)                                              //сравниваем 2 введёных числа и выводим результат
{
    Console.WriteLine($"Первое число a={number1} меньше второго b={number2}, по этому max={number2} ");
}
else
{
    Console.WriteLine($"Первое число a={number1} больше второго b={number2}. по этому max={number1} ");
}