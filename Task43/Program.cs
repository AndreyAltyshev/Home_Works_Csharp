/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

double Prompt(string mess)     //метод ввода 
{
    Console.Write(mess);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double[] IntersectionCoordinate(double k1, double b1, double k2, double b2)
{
    double[] coordinate = new double[2];
    coordinate[0] = (b2 - b1) / (k1 - k2);
    coordinate[1] = k1 * coordinate[0] + b1;
    return coordinate;
}

bool ValidateLine(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("прямые паралельны");
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите значения переменных k1 и b1 для первой функции y = k1 * x + b1");
double k1 = Prompt("k1=");
double b1 = Prompt("b1=");
Console.WriteLine("Введите значения переменных k2 и b2 для первой функции y = k2 * x + b2");
double k2 = Prompt("k2=");
double b2 = Prompt("b2=");
if (ValidateLine(k1, b1, k2, b2)){
    double[] intersectionCoordinate = IntersectionCoordinate(k1, b1, k2, b2);
    Console.WriteLine($"координата пересечения ({intersectionCoordinate[0]},{intersectionCoordinate[1]})");
}
