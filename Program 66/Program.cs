// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double InputNumber(string text) // Ручной ввод числа
{
    double number = 0;
    do
    {
        Console.Write(text);
    } while (double.TryParse(Console.ReadLine(), out number) == false);
    return number;
}

double NaturalsSumBetween(double start, double end)
{
    double sum = 0;
    for (start = Math.Ceiling(start); start <= Math.Truncate(end); start++)
        if (start >= 1)
            sum += start;
    return sum;
}

double m = InputNumber("Введите первое число: "),
    n = InputNumber("Введите второе число: ");

Console.WriteLine(
    $"Сумма натуральных элементов в промежутке от {m} до {n}: {NaturalsSumBetween(m, n)}"
);
