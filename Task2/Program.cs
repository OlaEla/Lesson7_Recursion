// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.




using System;

class Program
{
    static void Main()
    {
        // Задаём значения m и n
        int m = 2;
        int n = 5;

        // Вызываем функцию Аккермана и выводим результат
        int result = AckermannFunction(m, n);
        Console.WriteLine($"Результат функции Аккермана для m={m}, n={n}: \nA={result}");
    }

    // Рекурсивная функция для вычисления функции Аккермана
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }

        return 0; // Этот возврат никогда не выполнится, так как все возможные случаи рассмотрены ранее в функции
                 // Если происходит выполнение строки, это является индикатором ошибки в логике программы
    }
}






