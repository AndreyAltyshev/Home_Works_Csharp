/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

// Тело программы
Console.WriteLine("Введите число N:");          //ввод данных
int number = Prompt("N=");
int degree = Prompt("в какую степень возводить? degree=");

if (Nature(number))     //проверка на натуральность
{
    for(int i=1; i<=number; i++)        //вывод резальтата в консоль с округлением для отрицательных степеней до 5 знаков, в виде таблицы
    {
        Console.WriteLine($"{i,5} - {Math.Round(Exponention(i, degree), 5, MidpointRounding.ToZero),5}");
    }
}
else Console.WriteLine("Введено не натуральное число");

// Методы

int Prompt(string mess)     //метод ввода
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Nature(int num)    //метод проверки на натуральность
{
    return num > 0;
}

double Exponention(int num, int deg)        //метод возведения числа в целочисленную степень
{
    double result = 1;
    if (deg > 0)                        //возведение в положительную степень
    {
        for (int i = 1; i <= deg; i++)
        {
            result = num * result;
        }
        return result;
    }
    else if (deg == 0) return result;       //любое натуральное число в степени 0 равно 1
    else
    {
        for (int i = -1; i >= deg; i--)        //возведение в отрицательную степень 
        {
            result = num * result;
        }
        return 1 / result;

    }
}