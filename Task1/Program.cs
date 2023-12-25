// Задача 1: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        // Определяем начало и конец промежутка чисел
        // метод Min, Max из класса Math возвращает минимальное или максимальное значение из двух переданных ему чисел. 
        // В данном случае, он сравнивает значения переменных m и n и возвращает меньшее или большее из них.

        int start = Math.Min(m, n);
        int end = Math.Max(m, n);

        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n} :");

        // Вызываем рекурсивный метод для вывода чисел в промежутке
        PrintNumbersInRange(start, end);
        
        // Программа завершается без ожидания ввода пользователя
        //Console.ReadLine();
    }

    //метод PrintNumbersInRange вызывается рекурсивно для каждого числа в заданном диапазоне, 
    //начиная с current и заканчивая end. Метод выводит текущее число, 
    //затем вызывает сам себя с увеличенным на единицу current. 
    //Рекурсия завершается, когда current становится больше end.

    static void PrintNumbersInRange(int current, int end)
    {
        if (current > end)
        {
            return;
        }

        // Выводим текущее число
        Console.Write($"{current} ");

        // Рекурсивный вызов метода для следующего числа в промежутке
        PrintNumbersInRange(current + 1, end);
    }
}
