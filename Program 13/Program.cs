// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int InputNumber() // Ручной ввод целого числа
{
    Console.Write("Введите число: "); 
    return Convert.ToInt32(Console.ReadLine()); 
}

int GetThirdDigit(int Number) // Получение третьей цифры из числа
{
    if (Number<100 && Number>-100)
    {
        return -1;
    }
    else
    {
        while (Number/10>99 || Number/10<-99)
        {
            Number=Number/10;
        }
        return Number-Number/10*10;
    }
}

int ThirdDigit = GetThirdDigit(InputNumber());
if (ThirdDigit==-1)
{
    Console.WriteLine("Третьей цифры в числе нет");
}
else
{
    Console.WriteLine("Третья цифра полученного числа: "+ThirdDigit);
}
