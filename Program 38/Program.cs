// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillDoubleArray(double[] array, int min, int max) // Случайный ввод массива вещественными числами по заданному диапазону
{
    for (int i = 0; i < array.Length; i++) // цикл по всем элементам массива
        array[i] = new Random().Next(min, max + 1)+(new Random().Next(0, 100))*0.01; // заполнение текущего элемента массива случайным числом из заданного при вызове метода диапазона
}

string StringArray(double[] array, string split) // Преобразование массива в строку с заданным разделителем
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

int FindMax(double[] array) // Нахождение индекса элемента с максимальным значением
{
    int max = 0;
    for (int i = 1; i < array.Length; i++)
        if(array[i]>array[max])
            max=i;
    return max;
}

int FindMin(double[] array) // Нахождение индекса элемента с минимальным значением
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
        if(array[i]<array[min])
            min=i;
    return min;
}

int n = 4,
    min = -100,
    max = 100;

double[] array = new double[n];
FillDoubleArray(array, min, max);
Console.WriteLine("[" + StringArray(array, ", ") + "]");
Console.WriteLine("Разница между максимальным и минимальным элементов массива: "+(array[FindMax(array)]-array[FindMin(array)]));
