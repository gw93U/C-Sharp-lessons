// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int InputNumber() // Ручной ввод целого числа
{
    Console.Write("Введите число: "); 
    return Convert.ToInt32(Console.ReadLine()); 
}

int GetSecondDigit(int Number) // Получение второй цифры из трехзначного числа
{
    return (Number-Number/100*100)/10;
}

Console.WriteLine("Вторая цифра полученного числа: "+GetSecondDigit(InputNumber()));