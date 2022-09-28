// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int InputNumber() // Ручной ввод целого числа
{
    int number=0;
    while(number<1)
    {
        Console.Write("Введите целое число больше 0: "); 
        number=Convert.ToInt32(Console.ReadLine()); 
    }
    return number; 
}

void CubesTable(int N) // Вывод таблицы кубов чисел от 1 до N
{
    int i=0;
    Console.WriteLine("Таблица кубов чисел от 1 до "+N+":");
    while(i<N)
    {
        i++;
        Console.WriteLine(i+"^3 = "+Math.Pow(i,3)); 
    }
}

CubesTable(InputNumber());