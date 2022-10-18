// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

double InputNumber(string text) // Ручной ввод числа
{
    double number = 0;
    do
    {
        Console.Write(text);
    } while (double.TryParse(Console.ReadLine(), out number) == false);
    return number;
}

string NaturalsDownTo(string startstring, double start, double end) 
{
    start = Math.Truncate(start);
    if (end < 1)
        end = 1;
    if (start >= end + 1)
        return NaturalsDownTo(startstring + start + ", ", start - 1, end);
    else if (start >= end)
        return NaturalsDownTo(startstring + start + ".", start - 1, end);
    else
        return startstring;
}

double n = InputNumber("Введите число N: "),
    n2 = 1;

Console.WriteLine(NaturalsDownTo($"Натуральные числа в промежутке от {n} до {n2}: ", n, n2));
