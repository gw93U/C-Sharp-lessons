// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputNumber(string text) // Ручной ввод целого числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double InputDouble(string text) // Ручной ввод вещественного числа
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

string StringArray2(double[,] array, string split) // Преобразование массива в строку с заданным разделителем
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    string textarray = String.Empty;
    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            textarray += array[i, j];
            if (j < length1 - 1)
                textarray += split;
        }
        textarray += "\n";
    }
    return textarray;
}

void FillArray(double[,] array, double min, double max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = min + new Random().NextDouble() * (max - min);
}

int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: ");
double min = InputDouble("Введите минимальное значение случайных чисел: "),
    max = InputDouble("Введите максимальное значение случайных чисел: ");
double[,] array = new double[m, n];

FillArray(array, min, max);
Console.WriteLine(StringArray2(array, "; "));
