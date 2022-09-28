// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputNumber(string text, int bottomlimit) // Ручной ввод целого числа с заданной нижней границей
{
    int number=0;
    do
    {
        Console.Write(text); 
        number=Convert.ToInt32(Console.ReadLine()); 
    }while(number<bottomlimit);
    return number; 
}

int GetDigitSum(int number) // Получение суммы цифр в числе
{
    int sum=0;
    number=Math.Abs(number);
    while(number>0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}

int number=InputNumber("Введите целое число: ",-2147483648);
Console.WriteLine("Сумма цифр в числе "+number+": "+GetDigitSum(number));