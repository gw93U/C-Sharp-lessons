// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumofEveryN(int[] array, int start, int n) // Получение суммы элементов массива, начиная с заданного элемента и последующих, через указанный промежуток
{
    int sum = 0;
    for (int i = start; i < array.Length; i += n)
        sum += array[i];
    return sum;
}

int n = 4,
    min = -100,
    max = 100,
    start = 1,
    step = 2;

int[] array = new int[n];
FillArray(array, min, max);
Console.WriteLine("[" + StringArray(array, ", ") + "]");
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + GetSumofEveryN(array, start, step));