// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int InputNumber() // Ручной ввод целого числа
{
    Console.Write("Введите число: "); 
    return Convert.ToInt32(Console.ReadLine()); 
}

int isWeekend(int Day) // Проверка корректности дня недели и является ли он выходным
{
    if (Day<1 || Day>7)
    {
        return -1;  
    }
    if (Day==6 || Day==7)
    {
        return 1;
    }
    return 0;
}

int Result=isWeekend(InputNumber());
if (Result==-1)
{
    Console.WriteLine("Число не является эквивалентом дня недели");    
}
else 
{
    if (Result==1)
    {
        Console.WriteLine("День недели является выходным, отдыхаем!");
    }
    else
    {
        Console.WriteLine("День недели не является выходным");
    }
}