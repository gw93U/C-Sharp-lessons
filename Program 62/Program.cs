// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

string StringArray2(int[,] array) // Преобразование массива в строку с заданным разделителем
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    string textarray = String.Empty;
    for (int i = 0; i < length0; i++)
    {
        for (int j = 0; j < length1; j++)
            textarray += array[i, j] + " ";
        if (i < length0 - 1)
            textarray += "\n";
    }
    return textarray;
}

void FillArraySpiral(int[,] array) // Заполнение двумерного массива спирально
{
    int length0 = array.GetLength(0);
    int length1 = array.GetLength(1);
    int count = length0 * length1;
    int direction = 0;
    int i = 0,
        j = 0,
        x = 0,
        y = 0;
    int s;
    for (s = 1; s < count; s++)
    {
        array[i, j] = s;
        if (direction == 0)
            if (j < length1 - 1 - x)
                j++;
            else
            {
                x++;
                direction = 1;
                i++;
            }
        else if (direction == 1)
            if (i < length0 - 1 - y)
                i++;
            else
            {
                y++;
                direction = 2;
                j--;
            }
        else if (direction == 2)
            if (j > x - 1)
                j--;
            else
            {
                direction = 3;
                i--;
            }
        else if (direction == 3)
            if (i > y)
                i--;
            else
            {
                direction = 0;
                j++;
            }
    }
    array[i, j] = s;
}

int intmax = 2147483647,
    m = InputLimitedNumber("Введите первую размерность массива: ", 1, intmax),
    n = InputLimitedNumber("Введите вторую размерность массива: ", 1, intmax);
int[,] array = new int[m, n];
FillArraySpiral(array);
Console.WriteLine(StringArray2(array));
