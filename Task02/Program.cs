//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число для сравнения a=");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b=");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.WriteLine($"Первое число a={number1} меньше второго b={number2}, по этому max={number2} ");
}
else
{
    Console.WriteLine($"Первое число a={number1} больше второго b={number2}. по этому max={number1} ");
}