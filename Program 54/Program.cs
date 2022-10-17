// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
}

void DescendingLineSort(int[,] array)
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    int maxIndex,
        swap;
    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
        {
            maxIndex = j;
            for (int m = j + 1; m < length1; m++)
            {
                if (array[i, m] > array[i, maxIndex])

                    maxIndex = m;
            }
            if (j != maxIndex)
            {
                swap = array[i, maxIndex];
                array[i, maxIndex] = array[i, j];
                array[i, j] = swap;
            }
        }
    }
}

int intmax = 2147483647,
    m = InputLimitedNumber("Введите первую размерность массива: ", 1, intmax),
    n = InputLimitedNumber("Введите вторую размерность массива: ", 1, intmax),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputLimitedNumber("Введите максимальное значение случайных чисел: ", min, intmax);
int[,] array = new int[m, n];
FillArray(array, min, max);
Console.WriteLine(StringArray2(array, " "));
Console.WriteLine();
DescendingLineSort(array);
Console.WriteLine(StringArray2(array, " "));
