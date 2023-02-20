/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

// Тело программы
Console.WriteLine("Введите координаты точки A:");       //ввод данных
int xa = Prompt("x="),
    ya = Prompt("y="),
    za = Prompt("z=");
Console.WriteLine("Введите координаты точки B:");
int xb = Prompt("x="),
    yb = Prompt("y="),
    zb = Prompt("z=");

double result = Math.Sqrt((Squ(xb-xa)+Squ(yb-ya)+Squ(zb-za)));  //вычесляем  дистанцию

//вывод данных с округлением до двух знаков:
Console.WriteLine($"Расстояние между точками равно {Math.Round(result, 2, MidpointRounding.ToZero)}");  

//методы

int Prompt(string mess)                 //метод ввода данных
{
    Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Squ(int num)                        //метод возводящий число в квадрат
{
    return num*num;
}
