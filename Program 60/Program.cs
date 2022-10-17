// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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

string StringArray3(int[,,] array) // Преобразование трехмерного массива в строку с указанием индексов
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    int length2 = array.GetLength(2);
    string textarray = String.Empty;
    for (int k = 0; k < length2; k++)
    {
        for (int i = 0; i < length0; i++)
        {
            for (int j = 0; j < length1; j++)
            {
                textarray += $"{array[i, j, k]}({i},{j},{k})  ";
            }
            if (i < length0 - 1)
                textarray += "\n";
        }
        if (k < length2 - 1)
            textarray += "\n\n";
    }
    return textarray;
}

int[] FindNumberIndex3(int[,,] array, int number) // Нахождение индекса заданного числа
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    int length2 = array.GetLength(2);
    for (int i = 0; i < length0; i++)
        for (int j = 0; j < length1; j++)
            for (int k = 0; k < length2; k++)
                if (array[i, j, k] == number)

                    return new int[] { i, j, k };

    return new int[] { -1, -1, -1 };
}

void FillArray3(int[,,] array, int min, int max) // Заполнение трехмерного массива случайными целыми числами в заданном отрезке, без повторений(только если достаточно индексов)
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    int length2 = array.GetLength(2);
    int newNumber;
    bool isEnoughIndex = max - min >= length0 * length1 * length2;
    for (int i = 0; i < length0; i++)
        for (int j = 0; j < length1; j++)
            for (int k = 0; k < length2; k++)
                if (isEnoughIndex)
                {
                    do
                    {
                        newNumber = new Random().Next(min, max + 1);
                    } while (FindNumberIndex3(array, newNumber)[0] != -1);
                    array[i, j, k] = newNumber;
                }
                else
                    array[i, j, k] = new Random().Next(min, max + 1);
}

int intmax = 2147483647,
    m = InputLimitedNumber("Введите первую размерность массива: ", 1, intmax),
    n = InputLimitedNumber("Введите вторую размерность массива: ", 1, intmax),
    l = InputLimitedNumber("Введите третью размерность массива: ", 1, intmax),
    min = 10,
    max = 99;
int[,,] array = new int[m, n, l];
FillArray3(array, min, max);
Console.WriteLine(StringArray3(array));
