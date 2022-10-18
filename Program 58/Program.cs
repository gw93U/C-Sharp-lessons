// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplicate(int[,] matrix1, int[,] matrix2)
{
    int m = matrix1.GetLength(0),
        n = matrix1.GetLength(1),
        l = matrix2.GetLength(1);
    if (n != matrix2.GetLength(0))
        return null;
    int[,] result = new int[m, l];

    int sum = 0;
    for (int i = 0; i < m; i++)

        for (int j = 0; j < l; j++)
        {
            sum = 0;
            for (int r = 0; r < n; r++)
                sum += matrix1[i, r] * matrix2[r, j];
            result[i, j] = sum;
        }
    return result;
}

int m = InputLimitedNumber("Введите размерность m: ", 1, Int32.MaxValue),
    n = InputLimitedNumber("Введите размерность n: ", 1, Int32.MaxValue),
    l = InputLimitedNumber("Введите размерность l: ", 1, Int32.MaxValue),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputLimitedNumber(
        "Введите максимальное значение случайных чисел: ",
        min,
        Int32.MaxValue
    );

int[,] matrixK = new int[m, n];
FillArray(matrixK, min, max);
Console.WriteLine("Матрица K");
Console.WriteLine(StringArray2(matrixK, " ")+"\n");

int[,] matrixL = new int[n, l];
FillArray(matrixL, min, max);
Console.WriteLine("Матрица L");
Console.WriteLine(StringArray2(matrixL, " ")+"\n");

Console.WriteLine("K*L:");
Console.WriteLine(StringArray2(MatrixMultiplicate(matrixK, matrixL), " "));