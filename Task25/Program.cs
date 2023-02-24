/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

 */

// Тело программы

int number = Prompt("Введите число A, A=");      //ввод данных
int degree = Prompt("в какую степень возводить? B=");

if (Nature(degree))     //проверка на натуральность
{
    int result = Exponention(number, degree);
    Console.WriteLine($"Число {number} в степени {degree} равно {result}");
}
else Console.WriteLine("Введена не натуральная степень");

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

int Exponention(int num, int deg)        //метод возведения числа в целочисленную степень
{
    int res = 1;
     for (int i = 1; i <= deg; i++)
        {
             res = num * res;
        }
    return res;
   /*  if (deg != 0)
    {
        for (int i = 1; i <= deg; i++)
        {
            if (deg > 0) result = num * result;     //возведение в положительную степень
            else
            {                                       //возведение в отрицательную степень 
                result = num * result;
                result = 1 / result;
            }
        }
        return result;
    } 
    else return result;       //любое натуральное число в степени 0 равно 1*/
}