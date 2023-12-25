// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.



using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину массива: ");
        int length = int.Parse(Console.ReadLine());

        int[] myArray = new int[length];

        // Генерация массива случайных чисел
        GenerateRandomArray(myArray, 0);

        Console.WriteLine("Заданный массив:");
        PrintArray(myArray, 0);

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(myArray, 0, myArray.Length - 1);

        //Console.ReadLine(); // Программа завершается без ожидания ввода пользователя
    }

    // Рекурсивная функция для генерации массива случайных чисел

    // В реальных проектах использование рекурсии для генерации случайных массивов 
    // может быть неэффективным из-за увеличения глубины стека вызовов и, 
    // как следствие, возможных проблем с производительностью и использованием памяти


    static void GenerateRandomArray(int[] array, int index)
    {
        // Если индекс выходит за пределы массива, завершаем рекурсию
        if (index == array.Length)
        {
            return;
        }

        // Генерируем случайное число и присваиваем его элементу массива
        Random random = new Random();
        array[index] = random.Next(1, 100);

        // Рекурсивный вызов для следующего элемента
        GenerateRandomArray(array, index + 1);
    }

    // Рекурсивная функция для вывода элементов массива
    static void PrintArray(int[] array, int index)
    {
        // Если индекс выходит за пределы массива, завершаем рекурсию
        if (index == array.Length)
        {
            Console.WriteLine();
            return;
        }

        // Выводим текущий элемент
        Console.Write(array[index] + " ");

        // Рекурсивный вызов для следующего элемента
        PrintArray(array, index + 1);
    }

    // Рекурсивная функция для вывода элементов массива в обратном порядке
    static void PrintArrayReverse(int[] array, int startIndex, int endIndex)
    {
        // Если начальный индекс превышает конечный, завершаем рекурсию
        if (startIndex > endIndex)
        {
            Console.WriteLine();
            return;
        }

        // Выводим текущий элемент
        Console.Write(array[endIndex] + " ");

        // Рекурсивный вызов для предыдущего элемента
        PrintArrayReverse(array, startIndex, endIndex - 1);
    }
}
