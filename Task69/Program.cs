/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29 */

//методы

int PromptPositiv(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
    {
        Console.WriteLine("Введено не натуральное число");
        num = PromptPositiv(msg);
    }
    return num;
}

long AkkermanFunction(long m, long n)
{
    if (m == 0) return n + 1;                                        //Рекурсивная реализация
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    /* while (m != 0)                                                // полуитеративная реализация 
    {                                                               // за счёт меньших рекурсивных вызовов считает ббыстрее крупные значения)
        if (n == 0) n = 1;
        else n = AkkermanFunction(m, n - 1);
        m = m - 1;
    }
    return n + 1; */
}

long num1 = PromptPositiv("Введите натуральное число m="),
    num2 = PromptPositiv("Введите натуральное число n="),
    ack = AkkermanFunction(num1, num2);
Console.WriteLine($"A({num1}, {num2}) = {ack}");