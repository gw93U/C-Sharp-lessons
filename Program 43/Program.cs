// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GetIntersection(double b1, double k1, double b2, double k2) // Получение точки пересечения двух прямых, заданных уравнениями
{
    if (k1 == k2)
        return new double[2] { 0, 0 }; // Возвращает 0,0 если пересечения нет (как обойти?)
    double[] intersection = new double[2];
    intersection[0] = (b2 - b1) / (k1 - k2);
    intersection[1] = intersection[0] * k1 + b1;
    return intersection;
}

double b1 = InputNumber("Введите b1: "),
    k1 = InputNumber("Введите k1: "),
    b2 = InputNumber("Введите b2: "),
    k2 = InputNumber("Введите k2: ");

double[] cross = GetIntersection(b1, k1, b2, k2);
Console.WriteLine(
    $"x={cross[0]}, y={cross[1]} - точка пересечения прямых y = {k1}x + {b1}, y = {k2}x + {b2}"
);