// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] array, int min, int max) // Случайный ввод массива по заданному диапазону
{
    int length=array.Length;
    for(int i=0; i<length; i++)
    {
        array[i]=new Random().Next(min,max+1);
    }
}

void ManualFillArray(int[] array, int bottomlimit) // Ручной ввод массива с заданной нижней границей
{
    int number=0;
    for(int i=0; i<array.Length; i++)
    {
        do
        {
            Console.Write("Введите a["+i+"]: "); 
            number=Convert.ToInt32(Console.ReadLine()); 
        }while(number<bottomlimit);
        array[i]=number;
    }
}

string StringArray(int[] array, string split) // Преобразование массива в строку с заданным разделителем
{
    int length=array.Length;
    string textarray=String.Empty;
    for(int i=0; i<length; i++)
    {
        textarray+=array[i];
        if(i<length-1)
        {
            textarray+=split;
        }
    }
    return textarray;
}

int[] array = new int[8];
Console.WriteLine("Введите '+' для ручного ввода массива");
if(Console.ReadLine()=="+")
{
    ManualFillArray(array,-2147483648);
}
else
{
    FillArray(array,0,100);
}
Console.WriteLine("["+StringArray(array,", ")+"]");