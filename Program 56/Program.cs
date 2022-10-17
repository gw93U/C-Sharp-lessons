// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputNumber(string text) // Ручной ввод целого числа
{
    int number = 0;
    do
    {
        Console.Write(text);
    } while (int.TryParse(Console.ReadLine(), out number) == false);
    return number;
}

int InputLimitedNumber(string text, int min, int max) // Ручной ввод целого числа с ограничениями
{
    int number = 0;
    do
    {
        number = InputNumber(text);
    } while (number < min || number > max);
    return number;
}

string StringArray2(int[,] array, string split) // Преобразование массива в строку с заданным разделителем
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
        if (i < length0 - 1)
            textarray += "\n";
    }
    return textarray;
}

void FillArray(int[,] array, int min, int max) // Заполнение двумерного массива случайными целыми числами в заданном отрезке
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
}

int GetLineWithLowestSum(int[,] array) // Получение индекса строки с наименьшей суммой элементов
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    int sum,
        lowestSum = 0,
        lowestIndex = 0;
    for (int i = 0; i < length0; i++)
    {
        sum = 0;
        for (int j = 0; j < length1; j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
            lowestSum = sum;
        else if (sum < lowestSum)
        {
            lowestSum = sum;
            lowestIndex = i;
        }
    }
    return lowestIndex;
}

int intmax = 2147483647,
    m = InputLimitedNumber("Введите первую размерность массива: ", 1, intmax),
    n = InputLimitedNumber("Введите вторую размерность массива: ", 1, intmax),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputLimitedNumber("Введите максимальное значение случайных чисел: ", min, intmax);
int[,] array = new int[m, n];
FillArray(array, min, max);
Console.WriteLine(StringArray2(array, " "));
Console.WriteLine("Строка с наименьшей суммой элементов: " + (GetLineWithLowestSum(array) + 1));
