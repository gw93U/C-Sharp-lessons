// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array, int min, int max) // Случайный ввод массива по заданному диапазону
{
    for (int i = 0; i < array.Length; i++) // цикл по всем элементам массива
        array[i] = new Random().Next(min, max + 1); // заполнение текущего элемента массива случайным числом из заданного при вызове метода диапазона
}

string StringArray(int[] array, string split) // Преобразование массива в строку с заданным разделителем
{
    int length = array.Length; // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for (int i = 0; i < length; i++) // цикл по всем элементам массива
    {
        textarray += array[i]; // добавление в строку значение текущего элемента массива
        if (i < length - 1) // проверка является ли элемент последним (нужно ли добавлять разделитель в строку)
            textarray += split; // добавление разделителя между элементами в строку
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

bool IsDivisible(int number, int div) // Проверка делимости целого числа на заданное число
{
    if (div == 0)
        return false;
    if (number % div == 0)
        return true;
    else
        return false;
}

int GetDivisibleAmount(int[] array, int div) // Проверка делимости массива целых чисел на заданное число
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsDivisible(array[i], div))
            count++;
    }
    return count;
}

int n = 10,
    min = 100,
    max = 999,
    div = 2;
int[] array = new int[n];
FillArray(array, min, max);
Console.WriteLine("[" + StringArray(array, ", ") + "]");
Console.WriteLine("Количество чётных чисел в массиве: " + GetDivisibleAmount(array, div));