// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int InputNumber(string text) // Ручной ввод числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void InputArray(int[] array) // Ручной ввод массива чисел
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = InputNumber($"Введите {i + 1}-е число: ");
    }
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

int LimitedSum(int[] array, int min, int max) // Суммирование элементов массива в заданном промежутке значений
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
            sum += array[i];
    }
    return sum;
}

int n = InputNumber("Введите количество вводимых чисел: ");
int min = 1,
    max = 2147483647;
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + StringArray(array, ", ") + "]");
Console.WriteLine($"Сумма чисел больше 0: {LimitedSum(array, min, max)}");
