// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

double InputNumber(string text) // Ручной ввод числа
{
    double number = 0;
    do
    {
        Console.Write(text);
    } while (double.TryParse(Console.ReadLine(), out number) == false);
    return number;
}

double InputLimitedNumber(string text, double min, double max) // Ручной ввод числа с ограничениями
{
    double number = 0;
    do
    {
        number = InputNumber(text);
    } while (number < min || number > max);
    return number;
}

double AckermannFunction(double m, double n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return -1;
}

double m = InputLimitedNumber("Введите число m: ", 0, Double.MaxValue),
    n = InputLimitedNumber("Введите число n: ", 0, Double.MaxValue);

Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");
